using System;
using System.Collections.Generic;
using System.Text;

namespace ATC
{
    public class Plane
    {
        static Random rnd = frmRadar.rnd;

        public Plane(string Position)
        {
            #region Choosing airline
            string vac = frmRadar.VAC[rnd.Next(0, 5)];
            Callsign = vac + rnd.Next(9).ToString() + rnd.Next(9).ToString() + rnd.Next(9).ToString();
            #endregion

            #region Checking if callsign is in use
            foreach (Plane plane in frmRadar.Planes)
            {
                if (Callsign == plane.Callsign)
                {
                    vac = frmRadar.VAC[rnd.Next(0, 7)];
                    Callsign = vac + rnd.Next(9).ToString() + rnd.Next(9).ToString() + rnd.Next(9).ToString();
                }
            }
            #endregion

            #region Plane parameters
            if (Position == "TWR")
            {
                CurAlt = rnd.Next(100, 150);
                SetAlt = 4000;
                CurSpd = rnd.Next(140, 160);
                SetSpd = 200;
                CurHdg = 270;
				CalcHdg = 270;
                SetHdg = 270;
                X = frmRadar.Locations.Runway.locx + 5;
                Y = frmRadar.Locations.Runway.locy;
                isOutgoing = true;
				Controller = "TWR";
            }
            if (Position == "CTR2")
            {
                CurAlt = rnd.Next(11000, 13000);
                SetAlt = 9000;
                CurSpd = rnd.Next(260, 300);
                SetSpd = 250;
                CurHdg = 90;
				CalcHdg = 90;
                SetHdg = 90;
                X = 0;
                Y = frmRadar.Locations.Inbound.in1y + 50;
            }
            #endregion

            #region Creating dots
            for (int n = 0; n < 10; n++)
                Dots.Add(0);
            #endregion

            #region Setting borders
            Border.Left = X;
            Border.Right = X + 90;
            Border.Top = Y - 40;
            Border.Bottom = Y - 10;
            #endregion
        }

        public Borders Border = new Borders();

        public string Callsign;
        //Default parameters
        public int CurAlt = rnd.Next(11000, 13000);
        public int SetAlt = 10000;
        public int CurSpd = rnd.Next(250, 290);
        public int SetSpd = 250;
        public int CurHdg = 180;
		public int CalcHdg = 180;
        public int SetHdg = 180;
        public int X = frmRadar.Locations.Inbound.in2x + 50;
        public int Y = 0;
        public string Controller = "CTR";
        public bool isAssumed = false;
        public bool isWarned = false;
        public bool isCircled = false;
        public bool isOutgoing = false;
        public bool isClearedForApproach = false;

        public List<int> Dots = new List<int>();
    }

    public class Borders
    {
        public int Left;
        public int Right;
        public int Top;
        public int Bottom;
    }
}
