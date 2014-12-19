namespace ATC
{
    partial class frmRadar
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadar));
			this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
			this.tmrHeading = new System.Windows.Forms.Timer(this.components);
			this.tmrNewPlane = new System.Windows.Forms.Timer(this.components);
			this.tmrOpenWindow = new System.Windows.Forms.Timer(this.components);
			this.tmrCloseWindow = new System.Windows.Forms.Timer(this.components);
			this.tmrExit = new System.Windows.Forms.Timer(this.components);
			this.tmrFlashing = new System.Windows.Forms.Timer(this.components);
			this.pnlString = new System.Windows.Forms.Panel();
			this.lbl7 = new System.Windows.Forms.Label();
			this.btnPause = new System.Windows.Forms.PictureBox();
			this.btnMenu = new System.Windows.Forms.PictureBox();
			this.lbl9 = new System.Windows.Forms.Label();
			this.lblSalary = new System.Windows.Forms.Label();
			this.lblOutbound = new System.Windows.Forms.Label();
			this.lblLanded = new System.Windows.Forms.Label();
			this.lbl12 = new System.Windows.Forms.Label();
			this.Radar = new System.Windows.Forms.PictureBox();
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.pnlSpeed = new System.Windows.Forms.Panel();
			this.nudSPD = new System.Windows.Forms.MaskedTextBox();
			this.btnSPDL = new System.Windows.Forms.PictureBox();
			this.lbl2 = new System.Windows.Forms.Label();
			this.btnSPDR = new System.Windows.Forms.PictureBox();
			this.pnlAltitude = new System.Windows.Forms.Panel();
			this.lbl1 = new System.Windows.Forms.Label();
			this.nudALT = new System.Windows.Forms.MaskedTextBox();
			this.btnALTL = new System.Windows.Forms.PictureBox();
			this.btnALTR = new System.Windows.Forms.PictureBox();
			this.btnControl = new System.Windows.Forms.PictureBox();
			this.btnTower = new System.Windows.Forms.PictureBox();
			this.btnApproach = new System.Windows.Forms.PictureBox();
			this.lblPlane = new System.Windows.Forms.Label();
			this.btnAssume = new System.Windows.Forms.PictureBox();
			this.pnlString.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnPause)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Radar)).BeginInit();
			this.pnlMenu.SuspendLayout();
			this.pnlSpeed.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSPDL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSPDR)).BeginInit();
			this.pnlAltitude.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnALTL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnALTR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTower)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnApproach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAssume)).BeginInit();
			this.SuspendLayout();
			// 
			// tmrRefresh
			// 
			this.tmrRefresh.Interval = 5000;
			this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
			// 
			// tmrHeading
			// 
			this.tmrHeading.Interval = 300;
			this.tmrHeading.Tick += new System.EventHandler(this.tmrHeading_Tick);
			// 
			// tmrNewPlane
			// 
			this.tmrNewPlane.Interval = 50000;
			this.tmrNewPlane.Tick += new System.EventHandler(this.tmrNewPlane_Tick);
			// 
			// tmrOpenWindow
			// 
			this.tmrOpenWindow.Enabled = true;
			this.tmrOpenWindow.Interval = 1;
			this.tmrOpenWindow.Tick += new System.EventHandler(this.tmrOpenWindow_Tick);
			// 
			// tmrCloseWindow
			// 
			this.tmrCloseWindow.Interval = 1;
			this.tmrCloseWindow.Tick += new System.EventHandler(this.tmrCloseWindow_Tick);
			// 
			// tmrExit
			// 
			this.tmrExit.Interval = 1;
			// 
			// tmrFlashing
			// 
			this.tmrFlashing.Interval = 500;
			this.tmrFlashing.Tag = "0";
			this.tmrFlashing.Tick += new System.EventHandler(this.tmrFlashing_Tick);
			// 
			// pnlString
			// 
			this.pnlString.BackColor = System.Drawing.Color.Transparent;
			this.pnlString.BackgroundImage = global::ATC.Properties.Resources._string;
			this.pnlString.Controls.Add(this.lbl7);
			this.pnlString.Controls.Add(this.btnPause);
			this.pnlString.Controls.Add(this.btnMenu);
			this.pnlString.Controls.Add(this.lbl9);
			this.pnlString.Controls.Add(this.lblSalary);
			this.pnlString.Controls.Add(this.lblOutbound);
			this.pnlString.Controls.Add(this.lblLanded);
			this.pnlString.Controls.Add(this.lbl12);
			this.pnlString.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlString.Location = new System.Drawing.Point(0, 634);
			this.pnlString.Name = "pnlString";
			this.pnlString.Size = new System.Drawing.Size(1018, 49);
			this.pnlString.TabIndex = 2;
			// 
			// lbl7
			// 
			this.lbl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl7.AutoSize = true;
			this.lbl7.BackColor = System.Drawing.Color.Transparent;
			this.lbl7.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl7.ForeColor = System.Drawing.Color.White;
			this.lbl7.Location = new System.Drawing.Point(11, 11);
			this.lbl7.Name = "lbl7";
			this.lbl7.Size = new System.Drawing.Size(106, 24);
			this.lbl7.TabIndex = 8;
			this.lbl7.Text = "Inbound:";
			// 
			// btnPause
			// 
			this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPause.BackColor = System.Drawing.Color.Transparent;
			this.btnPause.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPause.ForeColor = System.Drawing.Color.Black;
			this.btnPause.Image = global::ATC.Properties.Resources.Pause_stell;
			this.btnPause.Location = new System.Drawing.Point(670, 2);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(156, 42);
			this.btnPause.TabIndex = 4;
			this.btnPause.TabStop = false;
			this.btnPause.Tag = "Pause";
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			this.btnPause.MouseEnter += new System.EventHandler(this.ButtonOver);
			this.btnPause.MouseLeave += new System.EventHandler(this.ButtonOut);
			// 
			// btnMenu
			// 
			this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMenu.BackColor = System.Drawing.Color.Transparent;
			this.btnMenu.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMenu.ForeColor = System.Drawing.Color.Black;
			this.btnMenu.Image = global::ATC.Properties.Resources.Menu_stell;
			this.btnMenu.Location = new System.Drawing.Point(850, 3);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(156, 42);
			this.btnMenu.TabIndex = 4;
			this.btnMenu.TabStop = false;
			this.btnMenu.Tag = "Menu";
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			this.btnMenu.MouseEnter += new System.EventHandler(this.ButtonOver);
			this.btnMenu.MouseLeave += new System.EventHandler(this.ButtonOut);
			// 
			// lbl9
			// 
			this.lbl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl9.AutoSize = true;
			this.lbl9.BackColor = System.Drawing.Color.Transparent;
			this.lbl9.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl9.ForeColor = System.Drawing.Color.White;
			this.lbl9.Location = new System.Drawing.Point(152, 11);
			this.lbl9.Name = "lbl9";
			this.lbl9.Size = new System.Drawing.Size(130, 24);
			this.lbl9.TabIndex = 10;
			this.lbl9.Text = "Outbound: ";
			// 
			// lblSalary
			// 
			this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSalary.AutoSize = true;
			this.lblSalary.BackColor = System.Drawing.Color.Transparent;
			this.lblSalary.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSalary.ForeColor = System.Drawing.Color.White;
			this.lblSalary.Location = new System.Drawing.Point(422, 11);
			this.lblSalary.Name = "lblSalary";
			this.lblSalary.Size = new System.Drawing.Size(34, 24);
			this.lblSalary.TabIndex = 15;
			this.lblSalary.Text = "0$";
			// 
			// lblOutbound
			// 
			this.lblOutbound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblOutbound.AutoSize = true;
			this.lblOutbound.BackColor = System.Drawing.Color.Transparent;
			this.lblOutbound.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblOutbound.ForeColor = System.Drawing.Color.White;
			this.lblOutbound.Location = new System.Drawing.Point(278, 11);
			this.lblOutbound.Name = "lblOutbound";
			this.lblOutbound.Size = new System.Drawing.Size(22, 24);
			this.lblOutbound.TabIndex = 14;
			this.lblOutbound.Text = "0";
			// 
			// lblLanded
			// 
			this.lblLanded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblLanded.AutoSize = true;
			this.lblLanded.BackColor = System.Drawing.Color.Transparent;
			this.lblLanded.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblLanded.ForeColor = System.Drawing.Color.White;
			this.lblLanded.Location = new System.Drawing.Point(119, 11);
			this.lblLanded.Name = "lblLanded";
			this.lblLanded.Size = new System.Drawing.Size(22, 24);
			this.lblLanded.TabIndex = 13;
			this.lblLanded.Text = "0";
			// 
			// lbl12
			// 
			this.lbl12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl12.AutoSize = true;
			this.lbl12.BackColor = System.Drawing.Color.Transparent;
			this.lbl12.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl12.ForeColor = System.Drawing.Color.White;
			this.lbl12.Location = new System.Drawing.Point(322, 11);
			this.lbl12.Name = "lbl12";
			this.lbl12.Size = new System.Drawing.Size(94, 24);
			this.lbl12.TabIndex = 12;
			this.lbl12.Text = "Salary:";
			// 
			// Radar
			// 
			this.Radar.BackgroundImage = global::ATC.Properties.Resources.bg_game;
			this.Radar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Radar.Cursor = System.Windows.Forms.Cursors.Cross;
			this.Radar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Radar.Location = new System.Drawing.Point(0, 60);
			this.Radar.Name = "Radar";
			this.Radar.Size = new System.Drawing.Size(1018, 623);
			this.Radar.TabIndex = 3;
			this.Radar.TabStop = false;
			this.Radar.Click += new System.EventHandler(this.lbl1_Click);
			this.Radar.Paint += new System.Windows.Forms.PaintEventHandler(this.Radar_Paint);
			this.Radar.DoubleClick += new System.EventHandler(this.Radar_DoubleClick);
			this.Radar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Radar_Click);
			this.Radar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Radar_MouseMove);
			this.Radar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Radar_PreviewKeyDown);
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
			this.pnlMenu.BackgroundImage = global::ATC.Properties.Resources.sddd;
			this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnlMenu.Controls.Add(this.pnlSpeed);
			this.pnlMenu.Controls.Add(this.pnlAltitude);
			this.pnlMenu.Controls.Add(this.btnControl);
			this.pnlMenu.Controls.Add(this.btnTower);
			this.pnlMenu.Controls.Add(this.btnApproach);
			this.pnlMenu.Controls.Add(this.lblPlane);
			this.pnlMenu.Controls.Add(this.btnAssume);
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlMenu.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.pnlMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(1018, 60);
			this.pnlMenu.TabIndex = 0;
			this.pnlMenu.Tag = "";
			this.pnlMenu.Click += new System.EventHandler(this.lbl1_Click);
			// 
			// pnlSpeed
			// 
			this.pnlSpeed.Controls.Add(this.nudSPD);
			this.pnlSpeed.Controls.Add(this.btnSPDL);
			this.pnlSpeed.Controls.Add(this.lbl2);
			this.pnlSpeed.Controls.Add(this.btnSPDR);
			this.pnlSpeed.Location = new System.Drawing.Point(394, 3);
			this.pnlSpeed.Name = "pnlSpeed";
			this.pnlSpeed.Size = new System.Drawing.Size(160, 57);
			this.pnlSpeed.TabIndex = 16;
			this.pnlSpeed.Tag = "1";
			this.pnlSpeed.Visible = false;
			// 
			// nudSPD
			// 
			this.nudSPD.Enabled = false;
			this.nudSPD.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudSPD.Location = new System.Drawing.Point(44, 24);
			this.nudSPD.Name = "nudSPD";
			this.nudSPD.Size = new System.Drawing.Size(67, 26);
			this.nudSPD.TabIndex = 10;
			this.nudSPD.Tag = "1";
			this.nudSPD.Text = "000";
			this.nudSPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudSPD.Click += new System.EventHandler(this.lbl1_Click);
			// 
			// btnSPDL
			// 
			this.btnSPDL.BackColor = System.Drawing.Color.Transparent;
			this.btnSPDL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSPDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSPDL.Image = global::ATC.Properties.Resources.arrow_left_stell;
			this.btnSPDL.InitialImage = null;
			this.btnSPDL.Location = new System.Drawing.Point(3, 17);
			this.btnSPDL.Name = "btnSPDL";
			this.btnSPDL.Size = new System.Drawing.Size(76, 36);
			this.btnSPDL.TabIndex = 11;
			this.btnSPDL.TabStop = false;
			this.btnSPDL.Tag = "arrow_left";
			this.btnSPDL.Click += new System.EventHandler(this.btnSPDL_Click);
			this.btnSPDL.MouseLeave += new System.EventHandler(this.ButtonOut);
			this.btnSPDL.MouseHover += new System.EventHandler(this.ButtonOver);
			// 
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
			this.lbl2.Location = new System.Drawing.Point(53, 0);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(48, 17);
			this.lbl2.TabIndex = 1;
			this.lbl2.Tag = "1";
			this.lbl2.Text = "Speed";
			this.lbl2.Click += new System.EventHandler(this.lbl1_Click);
			// 
			// btnSPDR
			// 
			this.btnSPDR.BackColor = System.Drawing.Color.Transparent;
			this.btnSPDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSPDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSPDR.Image = global::ATC.Properties.Resources.arrow_right_stell;
			this.btnSPDR.InitialImage = null;
			this.btnSPDR.Location = new System.Drawing.Point(76, 17);
			this.btnSPDR.Name = "btnSPDR";
			this.btnSPDR.Size = new System.Drawing.Size(76, 36);
			this.btnSPDR.TabIndex = 11;
			this.btnSPDR.TabStop = false;
			this.btnSPDR.Tag = "arrow_right";
			this.btnSPDR.Click += new System.EventHandler(this.btnSPDR_Click);
			this.btnSPDR.MouseLeave += new System.EventHandler(this.ButtonOut);
			this.btnSPDR.MouseHover += new System.EventHandler(this.ButtonOver);
			// 
			// pnlAltitude
			// 
			this.pnlAltitude.BackColor = System.Drawing.Color.Transparent;
			this.pnlAltitude.Controls.Add(this.lbl1);
			this.pnlAltitude.Controls.Add(this.nudALT);
			this.pnlAltitude.Controls.Add(this.btnALTL);
			this.pnlAltitude.Controls.Add(this.btnALTR);
			this.pnlAltitude.Location = new System.Drawing.Point(215, 3);
			this.pnlAltitude.Name = "pnlAltitude";
			this.pnlAltitude.Size = new System.Drawing.Size(157, 57);
			this.pnlAltitude.TabIndex = 15;
			this.pnlAltitude.Tag = "approach";
			this.pnlAltitude.Visible = false;
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.BackColor = System.Drawing.Color.Transparent;
			this.lbl1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
			this.lbl1.Location = new System.Drawing.Point(41, 0);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(72, 17);
			this.lbl1.TabIndex = 1;
			this.lbl1.Tag = "1";
			this.lbl1.Text = "Altitude";
			this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
			// 
			// nudALT
			// 
			this.nudALT.Enabled = false;
			this.nudALT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudALT.Location = new System.Drawing.Point(44, 24);
			this.nudALT.Name = "nudALT";
			this.nudALT.Size = new System.Drawing.Size(67, 26);
			this.nudALT.TabIndex = 10;
			this.nudALT.Tag = "1";
			this.nudALT.Text = "00000";
			this.nudALT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudALT.Click += new System.EventHandler(this.lbl1_Click);
			// 
			// btnALTL
			// 
			this.btnALTL.BackColor = System.Drawing.Color.Transparent;
			this.btnALTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnALTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnALTL.Image = global::ATC.Properties.Resources.arrow_left_stell;
			this.btnALTL.Location = new System.Drawing.Point(3, 17);
			this.btnALTL.Name = "btnALTL";
			this.btnALTL.Size = new System.Drawing.Size(76, 36);
			this.btnALTL.TabIndex = 11;
			this.btnALTL.TabStop = false;
			this.btnALTL.Tag = "arrow_left";
			this.btnALTL.Click += new System.EventHandler(this.btnALTL_Click);
			this.btnALTL.MouseLeave += new System.EventHandler(this.ButtonOut);
			this.btnALTL.MouseHover += new System.EventHandler(this.ButtonOver);
			// 
			// btnALTR
			// 
			this.btnALTR.BackColor = System.Drawing.Color.Transparent;
			this.btnALTR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnALTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnALTR.Image = global::ATC.Properties.Resources.arrow_right_stell;
			this.btnALTR.Location = new System.Drawing.Point(76, 17);
			this.btnALTR.Name = "btnALTR";
			this.btnALTR.Size = new System.Drawing.Size(76, 36);
			this.btnALTR.TabIndex = 11;
			this.btnALTR.TabStop = false;
			this.btnALTR.Tag = "arrow_right";
			this.btnALTR.Click += new System.EventHandler(this.btnALTR_Click);
			this.btnALTR.MouseLeave += new System.EventHandler(this.ButtonOut);
			this.btnALTR.MouseHover += new System.EventHandler(this.ButtonOver);
			// 
			// btnControl
			// 
			this.btnControl.BackColor = System.Drawing.Color.Transparent;
			this.btnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnControl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnControl.ForeColor = System.Drawing.Color.Black;
			this.btnControl.Image = global::ATC.Properties.Resources.control_stell;
			this.btnControl.Location = new System.Drawing.Point(841, 29);
			this.btnControl.Margin = new System.Windows.Forms.Padding(0);
			this.btnControl.Name = "btnControl";
			this.btnControl.Size = new System.Drawing.Size(90, 23);
			this.btnControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.btnControl.TabIndex = 14;
			this.btnControl.TabStop = false;
			this.btnControl.Tag = "control";
			this.btnControl.Text = "Control";
			this.btnControl.Visible = false;
			this.btnControl.Click += new System.EventHandler(this.tsmControl_Click);
			this.btnControl.MouseLeave += new System.EventHandler(this.ButtonOut);
			this.btnControl.MouseHover += new System.EventHandler(this.ButtonOver);
			// 
			// btnTower
			// 
			this.btnTower.BackColor = System.Drawing.Color.Transparent;
			this.btnTower.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnTower.ForeColor = System.Drawing.Color.Black;
			this.btnTower.Image = global::ATC.Properties.Resources.tower_stell;
			this.btnTower.Location = new System.Drawing.Point(841, 4);
			this.btnTower.Margin = new System.Windows.Forms.Padding(0);
			this.btnTower.Name = "btnTower";
			this.btnTower.Size = new System.Drawing.Size(90, 25);
			this.btnTower.TabIndex = 14;
			this.btnTower.TabStop = false;
			this.btnTower.Tag = "tower";
			this.btnTower.Text = "Tower";
			this.btnTower.Visible = false;
			this.btnTower.Click += new System.EventHandler(this.tsmTower_Click);
			this.btnTower.MouseLeave += new System.EventHandler(this.ButtonOut);
			this.btnTower.MouseHover += new System.EventHandler(this.ButtonOver);
			// 
			// btnApproach
			// 
			this.btnApproach.BackColor = System.Drawing.Color.Transparent;
			this.btnApproach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnApproach.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApproach.ForeColor = System.Drawing.Color.Black;
			this.btnApproach.Image = global::ATC.Properties.Resources.approach_stell;
			this.btnApproach.Location = new System.Drawing.Point(619, 4);
			this.btnApproach.Margin = new System.Windows.Forms.Padding(0);
			this.btnApproach.Name = "btnApproach";
			this.btnApproach.Size = new System.Drawing.Size(170, 51);
			this.btnApproach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnApproach.TabIndex = 14;
			this.btnApproach.TabStop = false;
			this.btnApproach.Tag = "approach";
			this.btnApproach.Text = "Approach clearance";
			this.btnApproach.Visible = false;
			this.btnApproach.Click += new System.EventHandler(this.btnApproach_Click);
			this.btnApproach.MouseLeave += new System.EventHandler(this.ButtonOut);
			this.btnApproach.MouseHover += new System.EventHandler(this.ButtonOver);
			// 
			// lblPlane
			// 
			this.lblPlane.AutoSize = true;
			this.lblPlane.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlane.Location = new System.Drawing.Point(10, 9);
			this.lblPlane.Name = "lblPlane";
			this.lblPlane.Size = new System.Drawing.Size(105, 32);
			this.lblPlane.TabIndex = 8;
			this.lblPlane.Tag = "1";
			this.lblPlane.Text = "AFL526";
			this.lblPlane.Visible = false;
			this.lblPlane.Click += new System.EventHandler(this.lbl1_Click);
			// 
			// btnAssume
			// 
			this.btnAssume.BackColor = System.Drawing.Color.Transparent;
			this.btnAssume.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAssume.ForeColor = System.Drawing.Color.Black;
			this.btnAssume.Image = global::ATC.Properties.Resources.Assume_stell;
			this.btnAssume.Location = new System.Drawing.Point(9, 1);
			this.btnAssume.Name = "btnAssume";
			this.btnAssume.Size = new System.Drawing.Size(200, 50);
			this.btnAssume.TabIndex = 6;
			this.btnAssume.TabStop = false;
			this.btnAssume.Tag = "Assume";
			this.btnAssume.Visible = false;
			this.btnAssume.Click += new System.EventHandler(this.tsmAssume_Click);
			this.btnAssume.MouseEnter += new System.EventHandler(this.ButtonOver);
			this.btnAssume.MouseLeave += new System.EventHandler(this.ButtonOut);
			// 
			// frmRadar
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1018, 683);
			this.Controls.Add(this.pnlString);
			this.Controls.Add(this.Radar);
			this.Controls.Add(this.pnlMenu);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRadar";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Tag = "";
			this.Text = "ATC Simulator";
			this.TransparencyKey = System.Drawing.Color.Maroon;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.pnlString.ResumeLayout(false);
			this.pnlString.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnPause)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Radar)).EndInit();
			this.pnlMenu.ResumeLayout(false);
			this.pnlMenu.PerformLayout();
			this.pnlSpeed.ResumeLayout(false);
			this.pnlSpeed.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnSPDL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnSPDR)).EndInit();
			this.pnlAltitude.ResumeLayout(false);
			this.pnlAltitude.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnALTL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnALTR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnTower)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnApproach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnAssume)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Timer tmrHeading;
		private System.Windows.Forms.Label lblPlane;
		private System.Windows.Forms.PictureBox btnALTR;
		private System.Windows.Forms.PictureBox btnALTL;
		private System.Windows.Forms.MaskedTextBox nudALT;
        private System.Windows.Forms.MaskedTextBox nudSPD;
		private System.Windows.Forms.Timer tmrNewPlane;
		private System.Windows.Forms.PictureBox btnApproach;
		private System.Windows.Forms.PictureBox btnControl;
		private System.Windows.Forms.PictureBox btnTower;
        private System.Windows.Forms.PictureBox btnAssume;
        private System.Windows.Forms.Timer tmrOpenWindow;
        private System.Windows.Forms.Timer tmrCloseWindow;
        private System.Windows.Forms.Timer tmrExit;
        private System.Windows.Forms.Panel pnlString;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.PictureBox btnPause;
		private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblOutbound;
        private System.Windows.Forms.Label lblLanded;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.PictureBox Radar;
		private System.Windows.Forms.Timer tmrFlashing;
		private System.Windows.Forms.Panel pnlAltitude;
		private System.Windows.Forms.Panel pnlSpeed;
		private System.Windows.Forms.PictureBox btnSPDL;
		private System.Windows.Forms.PictureBox btnSPDR;
    }
}

