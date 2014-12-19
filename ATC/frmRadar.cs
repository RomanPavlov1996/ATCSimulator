using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;

namespace ATC
{
	public partial class frmRadar : Form
	{
		//Locations
		public static class Locations
		{
			public static class Inbound
			{
				public static int in1x;
				public static int in1y;
				public static int in2x;
				public static int in2y;
			}

			public static class Outbound
			{
				public static int out1x;
				public static int out1y;
			}

			public static class Runway
			{
				public static int locx;
				public static int locy;
			}
		}

		//Statistics
		public static class Statistics
		{
			public static int Landed = 0;
			public static int Outbound = 0;
			public static int Salary = 0;
			public static int Highscore = 0;
		}

		#region Lists
		public static List<Plane> Planes = new List<Plane> ( );
		public static List<string> VAC = new List<string> ( );
		public static List<string> Dangerouses = new List<string> ( );
		#endregion

		public static class Preferences
		{
			public static double MaxTrafficCount;
			public static bool TrafficIsSteady = false;
			public static bool TCASIsOn = true;
		}

		public static class VERA
		{
			public static int CurrentX = 0;
			public static int CurrentY = 0;
			public static int? ConstX = null;
			public static int? ConstY = null;
			public static double Distance = 0;
			public static double Heading = 0;
			public static bool isDetached = true;
		}

		public static Random rnd = new Random ( );
		public static Plane SelectedPlane;
		bool WaitForKey = false;
		int KeyCase = 0;
		string KeyValue = "";
		Form MenuForm;

		#region Sounds
		SoundPlayer alert = new SoundPlayer ( Properties.Resources.alert );
		SoundPlayer alert2 = new SoundPlayer ( Properties.Resources.alert2 );
		SoundPlayer tcas = new SoundPlayer ( Properties.Resources.tcas );
		SoundPlayer alarm = new SoundPlayer ( Properties.Resources.alarm );
		#endregion

		public frmRadar ( double MT, Form form )
		{
			InitializeComponent ( );
			MenuForm = form;

			#region Traffic type select
			if ( MT != 0 )
			{
				Preferences.TrafficIsSteady = true;
				Preferences.MaxTrafficCount = MT;
			}
			#endregion
		}

		private void frmMain_Load ( object sender, EventArgs e )
		{
			#region Locations settings

			this.MinimumSize = this.Size;

			Locations.Runway.locx = this.Width / 2 - 200;
			Locations.Runway.locy = this.Height / 2;

			Locations.Inbound.in1x = 0;
			Locations.Inbound.in1y = Locations.Runway.locy / 2 - 50;
			Locations.Inbound.in2x = Locations.Runway.locx + ( this.Width - Locations.Runway.locx ) / 2 - 50;
			Locations.Inbound.in2y = 0;
			Locations.Outbound.out1x = this.Width - 20;
			Locations.Outbound.out1y = Locations.Runway.locy + ( this.Height - Locations.Runway.locy ) / 2 - 120;
			#endregion

			#region Airlines
			VAC.Add ( "AFL" );
			VAC.Add ( "SDM" );
			VAC.Add ( "TSO" );
			VAC.Add ( "SBI" );
			VAC.Add ( "UTA" );
			VAC.Add ( "DNV" );
			#endregion

			#region Start
			Planes.Clear ( );

			CreatePlane ( "TWR" );

			tmrRefresh.Start ( );
			tmrHeading.Start ( );
			tmrNewPlane.Start ( );
			#endregion

			#region Reading last record from file
			try
			{
				if ( System.IO.File.ReadAllText ( Application.UserAppDataPath
					+ "\\last.stat" ) != null )
					Statistics.Highscore = Convert.ToInt32 ( System.IO.File.ReadAllText ( Application.UserAppDataPath
						+ "\\last.stat" ) );
			}
			catch
			{
			}

			#endregion
		}

		//Creation of the plane
		private void CreatePlane ( string Position )
		{
			Plane plane = new Plane ( Position );
			Planes.Add ( plane );
			alert.Play ( );
		}

		//Pause
		private void btnPause_Click ( object sender, EventArgs e )
		{
			tmrRefresh.Stop ( );
			tmrHeading.Stop ( );
			tmrNewPlane.Stop ( );
			alert.Play ( );

			frmPaused form = new frmPaused ( );
			form.ShowDialog ( );

			tmrRefresh.Start ( );
			tmrHeading.Start ( );
			tmrNewPlane.Start ( );
			alert.Play ( );
		}

		//Radar refresh ( 5 sec. )
		private void tmrRefresh_Tick ( object sender, EventArgs e )
		{
			foreach ( Plane plane in Planes )
			{
				plane.isWarned = false;
				plane.isCircled = false;
			}

			List<Plane> PlanesToDelete = new List<Plane> ( );

			foreach ( Plane plane in Planes )
			{
				#region Moving the dots of the plane
				plane.Dots [ 9 ] = plane.Dots [ 7 ];
				plane.Dots [ 8 ] = plane.Dots [ 6 ];
				plane.Dots [ 7 ] = plane.Dots [ 5 ];
				plane.Dots [ 6 ] = plane.Dots [ 4 ];
				plane.Dots [ 5 ] = plane.Dots [ 3 ];
				plane.Dots [ 4 ] = plane.Dots [ 2 ];
				plane.Dots [ 3 ] = plane.Dots [ 1 ];
				plane.Dots [ 2 ] = plane.Dots [ 0 ];
				plane.Dots [ 1 ] = plane.X;
				plane.Dots [ 0 ] = plane.Y;
				#endregion

				#region TCAS
				if ( Planes.Count > 1 )
				{
					foreach ( Plane plane2 in Planes )
					{
						if ( plane != plane2 )
						{
							double Distance = Math.Sqrt ( Math.Pow ( plane2.X - plane.X, 2 ) + Math.Pow ( plane2.Y - plane.Y, 2 ) );

							if ( ( Math.Abs ( plane.CurAlt - plane2.CurAlt ) < 1000 ) && ( plane.CurAlt >= 2000 && plane2.CurAlt >= 2000 ) )
							{
								if ( Distance < 90 )
								{
									plane.isCircled = true;
									plane2.isCircled = true;

									if ( Distance < 60 )
									{
										plane.isWarned = true;
										plane2.isWarned = true;

										if ( !Dangerouses.Contains ( plane.Callsign + plane2.Callsign ) )
										{
											msgBox ( "Separation error!\nPenalty: - 1000$" );
											tcas.Play ( );

											Statistics.Salary -= 1000;
											lblSalary.Text = Statistics.Salary.ToString ( ) + "$";

											Dangerouses.Add ( plane.Callsign + plane2.Callsign );
										}

										if ( Distance < 5 && ( plane.CurAlt - plane2.CurAlt <= 100 || plane2.CurAlt - plane.CurAlt <= 100 ) )
										{
											tmrHeading.Stop ( );
											tmrNewPlane.Stop ( );
											tmrRefresh.Stop ( );
											ScoreCheck ( );
											alert.Play ( );

											frmLooser form = new frmLooser ( "Crash!\nInbound: " + Statistics.Landed.ToString ( ) + "\nOutbound: " + Statistics.Outbound.ToString ( ) );
											form.ShowDialog ( );
											form.Dispose ( );
											ScoreCheck ( );
											this.TopMost = true;
											MenuForm.Show ( );
											tmrCloseWindow.Start ( );
										}
									}
									else
									{
										if ( Dangerouses.Contains ( plane.Callsign + plane2.Callsign ) )
											Dangerouses.Remove ( plane.Callsign + plane2.Callsign );
									}
								}
							}
						}
					}
				}
				#endregion

				#region Speed
				if ( Math.Abs ( plane.SetSpd - plane.CurSpd ) <= 4 )
				{
					plane.CurSpd = plane.SetSpd;
				}
				else
				{
					int SpdIncrement = -2;

					if ( plane.SetSpd > plane.CurSpd )
						SpdIncrement *= -1;

					if ( plane.CurAlt <= 5000 )
						SpdIncrement *= 2;

					plane.CurSpd += SpdIncrement;
				}
				#endregion

				#region Altitude
				int AltIncrement = rnd.Next ( 250, 300 );	//If UP below FL100

				if ( plane.SetAlt > plane.CurAlt )
				{
					if ( plane.CurAlt >= 10000 )
						AltIncrement = rnd.Next ( 100, 150 );
				}
				else if ( plane.SetAlt < plane.CurAlt )
				{
					if ( plane.CurAlt >= 10000 )
						AltIncrement *= -1;
					else
						AltIncrement = rnd.Next ( 70, 120 ) * -1;
				}


				if ( Math.Abs ( plane.SetAlt - plane.CurAlt ) < 250 )
					plane.CurAlt = plane.SetAlt;
				else
					plane.CurAlt += AltIncrement;
				#endregion

				#region Position
				plane.X = ( int ) ( plane.X + ( plane.CurSpd / 20 * Math.Cos ( ( double ) ( plane.CurHdg - 90 ) / 180 * Math.PI ) ) );
				plane.Y = ( int ) ( plane.Y + ( plane.CurSpd / 20 * Math.Sin ( ( double ) ( plane.CurHdg - 90 ) / 180 * Math.PI ) ) );
				#endregion

				#region Heading
				plane.CurHdg = plane.CalcHdg;
				#endregion

				#region Landing/Outbound/FlyOut

				#region Correction of approach
				if ( plane.isClearedForApproach )
				{
					if ( plane.Y > Locations.Runway.locy - 15 && plane.Y < Locations.Runway.locy )
						plane.SetHdg = 260;
					else if ( plane.Y < Locations.Runway.locy + 15 && plane.Y > Locations.Runway.locy )
						plane.SetHdg = 280;

					if ( plane.Y > Locations.Runway.locy - 2 && plane.Y < Locations.Runway.locy + 2 )
						plane.SetHdg = 270;
				}
				#endregion

				#region Glide/Landing
				if ( plane.Controller == "TWR" && !plane.isOutgoing )
				{
					if ( plane.X <= Locations.Runway.locx + 200 )
					{
						plane.SetSpd = 160;
						plane.SetAlt = 1000;
					}

					if ( plane.X <= Locations.Runway.locx + 150 )
					{
						plane.SetAlt = 0;
						plane.SetSpd = 130;
					}

					if ( (plane.X > Locations.Runway.locx + 25 && plane.X < Locations.Runway.locx + 50) || plane.CurAlt <= 200)
					{
						PlanesToDelete.Add ( plane );

						Statistics.Landed++;
						lblLanded.Text = Statistics.Landed.ToString ( );

						Statistics.Salary += 2000;
						lblSalary.Text = Statistics.Salary.ToString ( ) + "$";
					}
				}
				#endregion

				#region Outbound
				if ( plane.Controller == "CTR" && plane.isOutgoing )
				{
					if ( plane.X > Locations.Outbound.out1x && plane.Y > Locations.Outbound.out1y && plane.Y < Locations.Outbound.out1y + 100 )
					{
						PlanesToDelete.Add ( plane );

						Statistics.Salary += 2000;
						lblSalary.Text = Statistics.Salary.ToString ( ) + "$";

						Statistics.Outbound++;
						lblOutbound.Text = Statistics.Outbound.ToString ( );
					}
				}
				#endregion

				#region Fly out of sector
				if ( plane.X < -20 || plane.X > Radar.Width + 20 || plane.Y < -20 || plane.Y > Radar.Height + 20 )
				{
					msgBox ( plane.Callsign + " flyed out from your sector! Penalty: -2000$" );

					Statistics.Salary -= 1000;
					lblSalary.Text = Statistics.Salary.ToString ( ) + "$";

					PlanesToDelete.Add ( plane );
				}
				#endregion

				#endregion

				#region Setting of borders
				plane.Border.Left = plane.X;
				plane.Border.Right = plane.X + 90;
				plane.Border.Top = plane.Y - 40;
				plane.Border.Bottom = plane.Y - 10;
				#endregion
			}

			if ( !VERA.isDetached && SelectedPlane != null && VERA.ConstX != null )
			{
				VERA.ConstX = SelectedPlane.X;
				VERA.ConstY = SelectedPlane.Y;
			}

			foreach ( Plane plane in PlanesToDelete )
			{
				Planes.Remove ( plane );
				if ( SelectedPlane == plane )
					SelectedPlane = null;
			}

			Menu_Refresh ( SelectedPlane );
			Radar.Invalidate ( );
		}

		//Turn of the plane timer
		private void tmrHeading_Tick ( object sender, EventArgs e )
		{
			foreach ( Plane plane in Planes )
			{
				if ( plane.CalcHdg != plane.SetHdg )
				{
					if ( plane.CalcHdg - plane.SetHdg <= -180 )
					{
						if ( plane.CalcHdg == 1 )
							plane.CalcHdg = 360;
						else
							plane.CalcHdg--;
					}
					else if ( plane.CalcHdg - plane.SetHdg > -180 && plane.CalcHdg - plane.SetHdg < 0 )
					{
						if ( plane.CalcHdg == 360 )
							plane.CalcHdg = 1;
						else
							plane.CalcHdg++;
					}
					else if ( plane.CalcHdg - plane.SetHdg > 0 && plane.CalcHdg - plane.SetHdg < 180 )
					{
						if ( plane.CalcHdg == 1 )
							plane.CalcHdg = 360;
						else
							plane.CalcHdg--;
					}
					else if ( plane.CalcHdg - plane.SetHdg >= 180 )
					{
						if ( plane.CalcHdg == 360 )
							plane.CalcHdg = 1;
						else
							plane.CalcHdg++;
					}
				}
			}
		}

		private void btnSPDR_Click ( object sender, EventArgs e )
		{
			double spd = Convert.ToInt16 ( nudSPD.Text );

			if ( spd != 270 )
			{
				nudSPD.Text = ( spd + 10 ).ToString ( );
				SelectedPlane.SetSpd = Convert.ToInt16 ( nudSPD.Text );
			}

			Radar.Focus ( );
		}

		private void btnSPDL_Click ( object sender, EventArgs e )
		{
			double spd = Convert.ToInt16 ( nudSPD.Text );

			if ( spd != 120 )
			{
				nudSPD.Text = ( spd - 10 ).ToString ( );
				SelectedPlane.SetSpd = Convert.ToInt16 ( nudSPD.Text );
			}

			Radar.Focus ( );
		}

		private void btnALTL_Click ( object sender, EventArgs e )
		{
			int alt = Convert.ToInt32 ( nudALT.Text );

			if ( alt != 2000 )
			{
				nudALT.Text = ( alt - 1000 ).ToString ( );
				SelectedPlane.SetAlt = Convert.ToInt32 ( nudALT.Text );
			}

			Radar.Focus ( );
		}

		private void btnALTR_Click ( object sender, EventArgs e )
		{
			int alt = Convert.ToInt32 ( nudALT.Text );

			if ( alt != 10000 )
			{
				nudALT.Text = ( alt + 1000 ).ToString ( );
				SelectedPlane.SetAlt = Convert.ToInt32 ( nudALT.Text );
			}

			Radar.Focus ( );
		}

		private void tsmTower_Click ( object sender, EventArgs e )
		{
			SelectedPlane.Controller = "TWR";

			Menu_Refresh ( SelectedPlane );
			btnTower.Hide ( );

			msgBox ( SelectedPlane.Callsign + " is transferred to Tower." );

			Radar.Invalidate ( );
			alert2.Play ( );
		}

		private void tsmControl_Click ( object sender, EventArgs e )
		{
			SelectedPlane.Controller = "CTR";

			Menu_Refresh ( SelectedPlane );
			btnControl.Hide ( );

			msgBox ( SelectedPlane.Callsign + " is transferred to Control." );

			Radar.Invalidate ( );
			alert2.Play ( );
		}

		private void tsmAssume_Click ( object sender, EventArgs e )
		{
			SelectedPlane.Controller = "APP";
			SelectedPlane.isAssumed = true;

			Menu_Refresh ( SelectedPlane );
			btnAssume.Hide ( );

			Radar.Invalidate ( );

			msgBox ( "You have control of " + SelectedPlane.Callsign );

			alert2.Play ( );
		}

		//New plane timer
		private void tmrNewPlane_Tick ( object sender, EventArgs e )
		{
			if ( !Preferences.TrafficIsSteady )
				Preferences.MaxTrafficCount += 0.5;

			if ( Convert.ToDouble ( Planes.Count ) < Preferences.MaxTrafficCount )
			{
				switch ( rnd.Next ( 3 ) )
				{
					case 0:
						CreatePlane ( "TWR" );
						break;
					case 1:
						CreatePlane ( "CTR" );
						break;
					default:
						CreatePlane ( "CTR2" );
						break;
				}
			}

			tmrNewPlane.Interval = rnd.Next ( 30000, 50000 );
		}

		//Approach
		private void btnApproach_Click ( object sender, EventArgs e )
		{
			#region If plane is not cleared for approach
			if ( !SelectedPlane.isClearedForApproach )
			{
				if ( SelectedPlane.X < Locations.Runway.locx + 200 && SelectedPlane.Y > Locations.Runway.locy - 100 && ( int ) SelectedPlane.Y < Locations.Runway.locy + 110 )
				{
					msgBox ( "Unavailable to approach from current position!" );
				}
				else
				{
					SelectedPlane.isClearedForApproach = true;
					Menu_Refresh ( SelectedPlane );

					SelectedPlane.SetAlt = 2000;

					if ( SelectedPlane.Y < Locations.Runway.locy )
						SelectedPlane.SetHdg = 240;
					else
						if ( SelectedPlane.Y > Locations.Runway.locy + 20 )
							SelectedPlane.SetHdg = 300;
						else
							SelectedPlane.SetHdg = 270;
				}
			}
			#endregion

			#region If already cleared
			else
			{
				SelectedPlane.isClearedForApproach = false;
				SelectedPlane.SetAlt = 3000;
				SelectedPlane.SetSpd = 180;
				Menu_Refresh ( SelectedPlane );
			}
			#endregion;

			alert.Play ( );
		}

		//Rendering
		private void Radar_Paint ( object sender, PaintEventArgs e )
		{
			Graphics Radar = e.Graphics;
			Pen WhitePen = new Pen ( Color.White, 1 );
			Pen GrayPen = new Pen ( Color.Gray, 1 );
			Brush WhiteBrush = Brushes.White;
			Brush BlackBrush = Brushes.Black;
			Font Font = new Font ( "Consolas", 9 );

			Radar.SmoothingMode = SmoothingMode.HighQuality;

			//Runway/Inbounds/Outbounds
			Radar.DrawImage ( Properties.Resources.runway, Locations.Runway.locx, Locations.Runway.locy - 10, 300, 20 );

			Radar.DrawImage ( Properties.Resources.arrows_horizontal, Locations.Inbound.in1x - 40, Locations.Inbound.in1y, 131, 101 );
			Radar.DrawImage ( Properties.Resources.arrows_vertical, Locations.Inbound.in2x, Locations.Inbound.in2y - 40, 101, 131 );
			Radar.DrawImage ( Properties.Resources.arrows_horizontal, Locations.Outbound.out1x - 100, Locations.Outbound.out1y, 131, 101 );

			foreach ( Plane plane in Planes )
			{
				int X = plane.X - 1;
				int Y = plane.Y - 1;

				WhiteBrush = Brushes.White;

				if ( plane.isCircled )
					Radar.DrawEllipse ( WhitePen, X - 30, Y - 30, 60, 60 );

				//Вектор
				WhitePen.EndCap = LineCap.ArrowAnchor;
				WhitePen.StartCap = LineCap.RoundAnchor;

				float X2 = ( float ) ( X + ( plane.CurSpd / 10 * Math.Cos ( ( double ) ( plane.CurHdg - 90 ) / 180 * Math.PI ) ) );
				float Y2 = ( float ) ( Y + ( plane.CurSpd / 10 * Math.Sin ( ( double ) ( plane.CurHdg - 90 ) / 180 * Math.PI ) ) );

				Radar.DrawLine ( WhitePen, X, Y, X2, Y2 );

				if ( plane == SelectedPlane )
					WhiteBrush = Brushes.ForestGreen;

				if ( !plane.isAssumed )
					WhiteBrush = Brushes.Orange;

				if ( plane.isWarned )
					WhiteBrush = Brushes.Red;

				string arrow = "↓";
				if ( plane.isOutgoing )
					arrow = "↑";

				Radar.DrawString ( plane.Callsign + " " + plane.Controller [ 0 ].ToString ( ) + arrow, Font, WhiteBrush, X + 20, Y - 40 );

				string AltitudeString = plane.CurAlt.ToString ( ).Remove ( plane.CurAlt.ToString ( ).Length - 2 ).PadLeft ( 3, '0' );
				if(plane.SetAlt > plane.CurAlt)
				{
					AltitudeString += "↗";
					AltitudeString += plane.SetAlt.ToString ( ).Remove ( plane.SetAlt.ToString ( ).Length - 2 ).PadLeft ( 3, '0' );
				}
				else if ( plane.SetAlt < plane.CurAlt && plane.SetAlt != 0 )
				{
					AltitudeString += "↘";
					AltitudeString += plane.SetAlt.ToString ( ).Remove ( plane.SetAlt.ToString ( ).Length - 2 ).PadLeft ( 3, '0' );
				}
				else if ( plane.SetAlt != 0 )
				{
					AltitudeString += "C";
				}
				else
				{
					AltitudeString += "↘LAND";
				}

				Radar.DrawString ( AltitudeString, Font, WhiteBrush, X + 20, Y - 30 );

				string SpeedString = plane.CurSpd.ToString ( ).Remove ( plane.CurSpd.ToString ( ).Length - 1 ).PadLeft ( 3, '0' );
				if ( plane.SetSpd > plane.CurSpd )
				{
					SpeedString += "↗";
					SpeedString += plane.SetSpd.ToString ( ).Remove ( plane.SetSpd.ToString ( ).Length - 1 ).PadLeft ( 3, '0' );
				}
				else if ( plane.SetSpd < plane.CurSpd )
				{
					SpeedString += "↘";
					SpeedString += plane.SetSpd.ToString ( ).Remove ( plane.SetSpd.ToString ( ).Length - 1 ).PadLeft ( 3, '0' );
				}
				else
				{
					SpeedString += "C";
				}

				Radar.DrawString ( SpeedString, Font, WhiteBrush, X + 20, Y - 20 );

				if ( plane.Dots [ 1 ] != 0 && plane.Dots [ 0 ] != 0 )
					Radar.FillEllipse ( WhiteBrush,
						plane.Dots [ 1 ] - 3,
						plane.Dots [ 0 ] - 3,
						4,
						4
					);
				if ( plane.Dots [ 3 ] != 0 && plane.Dots [ 2 ] != 0 )
					Radar.FillEllipse ( WhiteBrush,
						plane.Dots [ 3 ] - 3,
						plane.Dots [ 2 ] - 3,
						4,
						4
					);
				if ( plane.Dots [ 5 ] != 0 && plane.Dots [ 4 ] != 0 )
					Radar.FillEllipse ( WhiteBrush,
						plane.Dots [ 5 ] - 3,
						plane.Dots [ 4 ] - 3,
						4,
						4
					);
				if ( plane.Dots [ 7 ] != 0 && plane.Dots [ 6 ] != 0 )
					Radar.FillEllipse ( WhiteBrush,
						plane.Dots [ 7 ] - 3,
						plane.Dots [ 6 ] - 3,
						4,
						4
					);
				if ( plane.Dots [ 9 ] != 0 && plane.Dots [ 8 ] != 0 )
					Radar.FillEllipse ( WhiteBrush,
						plane.Dots [ 9 ] - 3,
						plane.Dots [ 8 ] - 3,
						4,
						4
					);
			}

			if ( VERA.ConstX != null && VERA.ConstY != null )
			{
				WhitePen.Color = Color.White;
				WhiteBrush = Brushes.White;
				Radar.DrawLine ( WhitePen, ( int ) VERA.ConstX, ( int ) VERA.ConstY, VERA.CurrentX, VERA.CurrentY );
				Radar.DrawString ( VERA.Heading + "°   " + VERA.Distance + " nm", Font, WhiteBrush, VERA.CurrentX - 20, VERA.CurrentY + 10 );
			}
		}

		//Form closing
		private void frmMain_FormClosing ( object sender, FormClosingEventArgs e )
		{
			ScoreCheck ( );
			this.TopMost = true;
			MenuForm.Show ( );
			tmrCloseWindow.Start ( );
		}

		//Menu refresh
		private void Menu_Refresh ( Plane plane )
		{
			#region Hidding of all elements
			foreach ( Control ctr in pnlMenu.Controls )
			{
				ctr.Visible = false;
			}
			#endregion

			if ( plane != null )
			{
				#region If plane is not assumed
				if ( plane.Controller != "APP" )
					btnAssume.Show ( );
				#endregion

				#region If plane is assumed
				else
				{
					if ( plane.isClearedForApproach && plane.CurAlt <= 3000 )
						btnTower.Show ( );

					if ( plane.isOutgoing && plane.CurAlt >= 7000 )
						btnControl.Show ( );

					if ( !WaitForKey )
					{
						nudALT.Text = plane.SetAlt.ToString ( );
						nudSPD.Text = plane.SetSpd.ToString ( );
					}

					lblPlane.Text = SelectedPlane.Callsign;

					foreach ( Control ctr in pnlMenu.Controls )
					{
						if ( ctr.Tag.ToString ( ) == "1" )
							ctr.Visible = true;
					}

					if ( plane.isClearedForApproach )
					{
						btnApproach.Tag = "cancel";
						btnApproach.Image = Properties.Resources.cancel_stell;
						btnApproach.Visible = true;
					}
					else
					{
						btnApproach.Tag = "approach";
						btnApproach.Image = Properties.Resources.approach_stell;

						foreach ( Control ctr in pnlMenu.Controls )
						{
							if ( ctr.Tag.ToString ( ) == "approach" )
								ctr.Visible = true;
						}
					}

					if ( plane.isOutgoing || plane.CurAlt > 5000 )
						btnApproach.Visible = false;
				}
				#endregion
			}
		}

		//Score check
		private void ScoreCheck ( )
		{
			if ( Statistics.Salary > Statistics.Highscore )
			{
				using ( TextWriter s
					= new StreamWriter ( File.Create ( Application.UserAppDataPath
					+ "\\last.stat" ) ) )
				{
					s.WriteLine ( Statistics.Salary.ToString ( ) );
				}
			}
		}

		private void tmrOpenWindow_Tick ( object sender, EventArgs e )
		{
			if ( this.Opacity < 1 )
				this.Opacity += 0.1;
			else
			{
				tmrOpenWindow.Stop ( );
				MenuForm.Hide ( );
			}
		}

		private void tmrCloseWindow_Tick ( object sender, EventArgs e )
		{
			if ( this.Opacity > 0.0 )
				this.Opacity -= 0.1;
			else
			{
				tmrCloseWindow.Stop ( );
				this.Close ( );
			}
		}

		private void ButtonOver ( object sender, EventArgs e )
		{
			PictureBox num = ( PictureBox ) sender;
			num.Image = ( Bitmap ) Properties.Resources.ResourceManager.GetObject ( num.Tag + "_push" );
		}

		private void ButtonOut ( object sender, EventArgs e )
		{
			PictureBox num = ( PictureBox ) sender;
			num.Image = ( Bitmap ) Properties.Resources.ResourceManager.GetObject ( num.Tag + "_stell" );
		}

		private void btnMenu_Click ( object sender, EventArgs e )
		{
			ScoreCheck ( );
			this.TopMost = true;
			MenuForm.Show ( );
			tmrCloseWindow.Start ( );
			alert.Play ( );
		}

		private void msgBox ( string text )
		{
			frmMsgBox messageForm = new frmMsgBox ( text );
			messageForm.Show ( );
			Radar.Focus ( );
			alert.Play ( );
		}

		//Touch of the radar
		private void Radar_Click ( object sender, MouseEventArgs e )
		{
			if ( VERA.ConstX == null && VERA.ConstY == null )
			{
				SelectedPlane = null;

				foreach ( Plane plane in Planes )
				{
					if ( VERA.CurrentX > plane.Border.Left && VERA.CurrentX < plane.Border.Right && VERA.CurrentY > plane.Border.Top && VERA.CurrentY < plane.Border.Bottom )
						SelectedPlane = plane;
				}

				Menu_Refresh ( SelectedPlane );
				Radar.Invalidate ( );
			}
			else if ( !VERA.isDetached && e.Button == System.Windows.Forms.MouseButtons.Right && SelectedPlane.isAssumed )
			{
				SelectedPlane.SetHdg = ( int ) VERA.Heading;
				VERA.ConstX = null;
				VERA.ConstY = null;
				alert.Play ( );
			}
		}

		private void Radar_DoubleClick ( object sender, EventArgs e )
		{
			if ( VERA.ConstX == null && VERA.ConstY == null )
			{
				if ( SelectedPlane == null )
				{
					VERA.ConstX = VERA.CurrentX;
					VERA.ConstY = VERA.CurrentY;
					VERA.isDetached = true;
				}
				else
				{
					VERA.ConstX = SelectedPlane.X - 1;
					VERA.ConstY = SelectedPlane.Y - 1;
					VERA.isDetached = false;
				}
			}
			else
			{
				VERA.ConstX = null;
				VERA.ConstY = null;
			}
		}

		private void Radar_MouseMove ( object sender, MouseEventArgs e )
		{
			VERA.CurrentX = e.Location.X;
			VERA.CurrentY = e.Location.Y;

			if ( VERA.ConstX != null && VERA.ConstY != null )
			{
				int X = VERA.CurrentX - ( int ) VERA.ConstX;
				int Y = VERA.CurrentY - ( int ) VERA.ConstY;

				double aheading = 0;
				int headingIncrease = 0;

				if ( X >= 0 && Y > 0 )
				{
					aheading = Math.Atan ( ( double ) Math.Abs ( Y ) / ( double ) Math.Abs ( X ) );
					headingIncrease = 90;
				}
				else if ( X > 0 && Y <= 0 )
				{
					aheading = Math.Atan ( ( double ) Math.Abs ( X ) / ( double ) Math.Abs ( Y ) );
				}
				else if ( X <= 0 && Y < 0 )
				{
					aheading = Math.Atan ( ( double ) Math.Abs ( Y ) / ( double ) Math.Abs ( X ) );
					headingIncrease = 270;
				}
				else if ( X < 0 && Y >= 0 )
				{
					aheading = Math.Atan ( ( double ) Math.Abs ( X ) / ( double ) Math.Abs ( Y ) );
					headingIncrease = 180;
				}
				else if ( X > 0 && Y < 1 && Y > -1 )
				{
					aheading = Math.PI * 0.5;
				}
				else if ( X < 0 && Y < 1 && Y > -1 )
				{
					aheading = Math.PI * 1.5;
				}
				else if ( X < 1 && X > -1 && Y > 0 )
				{
					aheading = Math.PI * 2;
				}
				else if ( X < 1 && X > -1 && Y < 0 )
				{
					aheading = Math.PI;
				}

				VERA.Distance = Math.Round(0.035 * Math.Sqrt ( Math.Pow ( X, 2 ) + Math.Pow ( Y, 2 ) ), 2);

				VERA.Heading = Convert.ToInt16 ( aheading * 180 / Math.PI ) + headingIncrease;

				Radar.Invalidate ( );
			}
		}

		private void Radar_PreviewKeyDown ( object sender, PreviewKeyDownEventArgs e )
		{
			if ( SelectedPlane != null )
			{
				if ( SelectedPlane.isAssumed )
				{
					if ( WaitForKey )
					{
						int count = KeyValue.Length;

						#region Switch of Numeric Keys
						switch ( e.KeyData )
						{
							case Keys.D0:
								KeyValue += "0";
								break;
							case Keys.D1:
								KeyValue += "1";
								break;
							case Keys.D2:
								KeyValue += "2";
								break;
							case Keys.D3:
								KeyValue += "3";
								break;
							case Keys.D4:
								KeyValue += "4";
								break;
							case Keys.D5:
								KeyValue += "5";
								break;
							case Keys.D6:
								KeyValue += "6";
								break;
							case Keys.D7:
								KeyValue += "7";
								break;
							case Keys.D8:
								KeyValue += "8";
								break;
							case Keys.D9:
								KeyValue += "9";
								break;
							case Keys.NumPad0:
								KeyValue += "0";
								break;
							case Keys.NumPad1:
								KeyValue += "1";
								break;
							case Keys.NumPad2:
								KeyValue += "2";
								break;
							case Keys.NumPad3:
								KeyValue += "3";
								break;
							case Keys.NumPad4:
								KeyValue += "4";
								break;
							case Keys.NumPad5:
								KeyValue += "5";
								break;
							case Keys.NumPad6:
								KeyValue += "6";
								break;
							case Keys.NumPad7:
								KeyValue += "7";
								break;
							case Keys.NumPad8:
								KeyValue += "8";
								break;
							case Keys.NumPad9:
								KeyValue += "9";
								break;
							case Keys.Back:
								KeyValue = "";
								WaitForKey = false;
								KeyCase = 0;
								tmrFlashing.Stop ( );
								nudALT.Text = SelectedPlane.SetAlt.ToString();
								nudSPD.Text = SelectedPlane.SetSpd.ToString();
								alert.Play ( );
								break;
						}
						#endregion

						if ( KeyValue.Length > count )
						{
							#region Switch of KeyCases
							switch ( KeyCase )
							{
								case 0:
									if ( KeyValue.Length == 4 && Convert.ToInt16 ( KeyValue ) >= 2000 || Convert.ToInt16 ( KeyValue ) == 10000 )
									{
										string value = KeyValue.Remove ( KeyValue.Length - 3 );
										value += "000";
										SelectedPlane.SetAlt = Convert.ToInt16 ( value );
										tmrFlashing.Stop ( );
										nudALT.Text = KeyValue;
										KeyValue = "";
										WaitForKey = false;
									}
									else if ( KeyValue.Length > 5 )
									{
										KeyValue = "";
										WaitForKey = false;
										KeyCase = 0;
										tmrFlashing.Stop ( );
									}
									else
									{
										tmrFlashing.Stop ( );
										if ( nudALT.Text != "" )
										{
											if ( nudALT.Text [ nudALT.Text.Length - 1 ] == '_' )
											{
												nudALT.Text = nudALT.Text.Remove ( nudALT.Text.Length - 1 );
											}
										}
										nudALT.Text += KeyValue [ KeyValue.Length - 1 ];
										tmrFlashing.Start ( );
									}
									break;
								case 1:
									if ( KeyValue.Length == 3 && Convert.ToInt16 ( KeyValue ) > 120 && Convert.ToInt16 ( KeyValue ) < 270 )
									{
										string value = KeyValue.Remove ( KeyValue.Length - 1 );
										value += "0";
										SelectedPlane.SetSpd = Convert.ToInt16 ( value );
										tmrFlashing.Stop ( );
										nudSPD.Text = KeyValue;
										KeyValue = "";
										WaitForKey = false;
									}
									else if ( KeyValue.Length > 3 )
									{
										KeyValue = "";
										WaitForKey = false;
										KeyCase = 0;
										tmrFlashing.Stop ( );
									}
									else
									{
										tmrFlashing.Stop ( );
										if ( nudSPD.Text != "" )
										{
											if ( nudSPD.Text [ nudSPD.Text.Length - 1 ] == '_' )
											{
												nudSPD.Text = nudSPD.Text.Remove ( nudSPD.Text.Length - 1 );
											}
										}
										nudSPD.Text += KeyValue [ KeyValue.Length - 1 ];
										tmrFlashing.Start ( );
									}
									break;
							}
							#endregion
						}
					}
					else
					{
						#region Switch of Main Keys
						switch ( e.KeyData )
						{
							case Keys.A:
								KeyCase = 0;
								WaitForKey = true;
								nudALT.Text = "_";
								tmrFlashing.Tag = 0;
								tmrFlashing.Start ( );
								alert.Play ( );
								break;
							case Keys.S:
								KeyCase = 1;
								WaitForKey = true;
								nudSPD.Text = "_";
								tmrFlashing.Tag = 0;
								tmrFlashing.Start ( );
								alert.Play ( );
								break;
							case Keys.T:
								if ( btnTower.Visible )
								{
									SelectedPlane.Controller = "TWR";

									Menu_Refresh ( SelectedPlane );
									btnTower.Hide ( );

									msgBox ( SelectedPlane.Callsign + " is transferred to Tower." );

									Radar.Invalidate ( );
								}
								break;
							case Keys.C:
								if ( btnControl.Visible )
								{
									SelectedPlane.Controller = "CTR";

									Menu_Refresh ( SelectedPlane );
									btnControl.Hide ( );

									msgBox ( SelectedPlane.Callsign + " is transferred to Control." );

									Radar.Invalidate ( );
								}
								break;
							case Keys.P:
								if ( btnApproach.Visible )
								{
									#region If plane is not cleared for approach
									if ( !SelectedPlane.isClearedForApproach )
									{
										if ( SelectedPlane.X < Locations.Runway.locx + 200 && SelectedPlane.Y > Locations.Runway.locy - 100 && ( int ) SelectedPlane.Y < Locations.Runway.locy + 110 )
										{
											msgBox ( "Unavailable to approach from current position!" );
										}
										else
										{
											SelectedPlane.isClearedForApproach = true;
											Menu_Refresh ( SelectedPlane );

											SelectedPlane.SetAlt = 2000;

											if ( SelectedPlane.Y < Locations.Runway.locy )
												SelectedPlane.SetHdg = 240;
											else
												if ( SelectedPlane.Y > Locations.Runway.locy + 20 )
													SelectedPlane.SetHdg = 300;
												else
													SelectedPlane.SetHdg = 270;
										}
									}
									#endregion

									#region If already cleared
									else
									{
										SelectedPlane.isClearedForApproach = false;
										SelectedPlane.SetAlt = 3000;
										SelectedPlane.SetSpd = 180;
										Menu_Refresh ( SelectedPlane );
									}
									#endregion;

									alert.Play ( );
								}
									break;
						}
						#endregion
					}
				}
				else
				{
					if ( e.KeyData == Keys.A )
					{
						SelectedPlane.Controller = "APP";
						SelectedPlane.isAssumed = true;

						Menu_Refresh ( SelectedPlane );
						btnAssume.Hide ( );

						Radar.Invalidate ( );

						msgBox ( "You have control of " + SelectedPlane.Callsign );
					}
				}
			}
			else
			{
				KeyValue = "";
				WaitForKey = false;
				KeyCase = 0;
			}
		}

		//Focusing on picRadar
		private void lbl1_Click ( object sender, EventArgs e )
		{
			Radar.Focus ( );
		}

		private void tmrFlashing_Tick ( object sender, EventArgs e )
		{
			if ( KeyCase == 0 )
			{
				if ( nudALT.Text == "" )
				{
					nudALT.Text += "_";
				}
				else if ( nudALT.Text [ nudALT.Text.Length - 1 ] != '_' )
				{
					nudALT.Text += "_";
				} 
				else
				{
					nudALT.Text = nudALT.Text.Remove ( nudALT.Text.Length - 1 );
				}
			}
			else if(KeyCase == 1)
			{
				if ( nudSPD.Text == "" )
				{
					nudSPD.Text += "_";
				}
				else if ( nudSPD.Text [ nudSPD.Text.Length - 1 ] != '_' )
				{
					nudSPD.Text += "_";
				}
				else
				{
					nudSPD.Text = nudSPD.Text.Remove ( nudSPD.Text.Length - 1 );
				}
			}
		}
	}
}