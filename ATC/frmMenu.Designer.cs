namespace ATC
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container ( );
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmMenu ) );
			this.tmrOpenWindow = new System.Windows.Forms.Timer ( this.components );
			this.tmrCloseWindow = new System.Windows.Forms.Timer ( this.components );
			this.btnHelp = new System.Windows.Forms.PictureBox ( );
			this.btnAbout = new System.Windows.Forms.PictureBox ( );
			this.btnExit = new System.Windows.Forms.PictureBox ( );
			this.btnHighScore = new System.Windows.Forms.PictureBox ( );
			this.btnStart = new System.Windows.Forms.PictureBox ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnHelp ) ).BeginInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnAbout ) ).BeginInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnExit ) ).BeginInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnHighScore ) ).BeginInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnStart ) ).BeginInit ( );
			this.SuspendLayout ( );
			// 
			// tmrOpenWindow
			// 
			this.tmrOpenWindow.Enabled = true;
			this.tmrOpenWindow.Interval = 1;
			this.tmrOpenWindow.Tick += new System.EventHandler ( this.tmrOpenWindow_Tick );
			// 
			// tmrCloseWindow
			// 
			this.tmrCloseWindow.Interval = 1;
			this.tmrCloseWindow.Tick += new System.EventHandler ( this.tmrCloseWindow_Tick );
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.btnHelp.BackColor = System.Drawing.Color.Transparent;
			this.btnHelp.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnHelp.ForeColor = System.Drawing.Color.Black;
			this.btnHelp.Image = global::ATC.Properties.Resources.Help_stell;
			this.btnHelp.Location = new System.Drawing.Point ( 72, 639 );
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size ( 120, 50 );
			this.btnHelp.TabIndex = 7;
			this.btnHelp.TabStop = false;
			this.btnHelp.Tag = "Help";
			this.btnHelp.Click += new System.EventHandler ( this.btnHelp_Click );
			this.btnHelp.MouseEnter += new System.EventHandler ( this.ButtonOver );
			this.btnHelp.MouseLeave += new System.EventHandler ( this.ButtonOut );
			// 
			// btnAbout
			// 
			this.btnAbout.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.btnAbout.BackColor = System.Drawing.Color.Transparent;
			this.btnAbout.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnAbout.ForeColor = System.Drawing.Color.Black;
			this.btnAbout.Image = global::ATC.Properties.Resources.About_stell;
			this.btnAbout.Location = new System.Drawing.Point ( 1068, 656 );
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size ( 200, 50 );
			this.btnAbout.TabIndex = 8;
			this.btnAbout.TabStop = false;
			this.btnAbout.Tag = "About";
			this.btnAbout.Click += new System.EventHandler ( this.btnAbout_Click );
			this.btnAbout.MouseEnter += new System.EventHandler ( this.ButtonOver );
			this.btnAbout.MouseLeave += new System.EventHandler ( this.ButtonOut );
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ( ( System.Windows.Forms.AnchorStyles ) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnExit.ForeColor = System.Drawing.Color.Black;
			this.btnExit.Image = global::ATC.Properties.Resources.Exit_stell;
			this.btnExit.Location = new System.Drawing.Point ( 1114, 241 );
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size ( 70, 50 );
			this.btnExit.TabIndex = 9;
			this.btnExit.TabStop = false;
			this.btnExit.Tag = "Exit";
			this.btnExit.Click += new System.EventHandler ( this.btnExit_Click );
			this.btnExit.MouseEnter += new System.EventHandler ( this.ButtonOver );
			this.btnExit.MouseLeave += new System.EventHandler ( this.ButtonOut );
			// 
			// btnHighScore
			// 
			this.btnHighScore.BackColor = System.Drawing.Color.Transparent;
			this.btnHighScore.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnHighScore.ForeColor = System.Drawing.Color.Black;
			this.btnHighScore.Image = global::ATC.Properties.Resources.HighScore_stell;
			this.btnHighScore.Location = new System.Drawing.Point ( 62, 271 );
			this.btnHighScore.Name = "btnHighScore";
			this.btnHighScore.Size = new System.Drawing.Size ( 200, 62 );
			this.btnHighScore.TabIndex = 5;
			this.btnHighScore.TabStop = false;
			this.btnHighScore.Tag = "HighScore";
			this.btnHighScore.Click += new System.EventHandler ( this.btnHighScore_Click );
			this.btnHighScore.MouseEnter += new System.EventHandler ( this.ButtonOver );
			this.btnHighScore.MouseLeave += new System.EventHandler ( this.ButtonOut );
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.Transparent;
			this.btnStart.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnStart.ForeColor = System.Drawing.Color.Black;
			this.btnStart.Image = global::ATC.Properties.Resources.StartGame_stell;
			this.btnStart.Location = new System.Drawing.Point ( 540, 356 );
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size ( 200, 50 );
			this.btnStart.TabIndex = 6;
			this.btnStart.TabStop = false;
			this.btnStart.Tag = "StartGame";
			this.btnStart.Click += new System.EventHandler ( this.btnStart_Click );
			this.btnStart.MouseEnter += new System.EventHandler ( this.ButtonOver );
			this.btnStart.MouseLeave += new System.EventHandler ( this.ButtonOut );
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 15F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::ATC.Properties.Resources.BG_4x3v1_2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size ( 1276, 998 );
			this.Controls.Add ( this.btnHelp );
			this.Controls.Add ( this.btnAbout );
			this.Controls.Add ( this.btnExit );
			this.Controls.Add ( this.btnHighScore );
			this.Controls.Add ( this.btnStart );
			this.Font = new System.Drawing.Font ( "Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject ( "$this.Icon" ) ) );
			this.MinimizeBox = false;
			this.Name = "frmMenu";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TransparencyKey = System.Drawing.Color.Maroon;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler ( this.frmMenu_Load );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnHelp ) ).EndInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnAbout ) ).EndInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnExit ) ).EndInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnHighScore ) ).EndInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnStart ) ).EndInit ( );
			this.ResumeLayout ( false );

        }

        #endregion

        private System.Windows.Forms.Timer tmrOpenWindow;
        private System.Windows.Forms.Timer tmrCloseWindow;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnAbout;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnHighScore;
        private System.Windows.Forms.PictureBox btnStart;
    }
}