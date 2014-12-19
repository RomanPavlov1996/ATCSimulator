namespace ATC
{
    partial class frmStartGame
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmStartGame ) );
			this.rbtSteadyTraf = new System.Windows.Forms.RadioButton ( );
			this.rbnIncreasingTraf = new System.Windows.Forms.RadioButton ( );
			this.label1 = new System.Windows.Forms.Label ( );
			this.nudTraffic = new System.Windows.Forms.NumericUpDown ( );
			this.btnStart = new System.Windows.Forms.PictureBox ( );
			this.btnBack = new System.Windows.Forms.PictureBox ( );
			this.tmrOpenWindow = new System.Windows.Forms.Timer ( this.components );
			this.tmrCloseWindow = new System.Windows.Forms.Timer ( this.components );
			( ( System.ComponentModel.ISupportInitialize ) ( this.nudTraffic ) ).BeginInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnStart ) ).BeginInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnBack ) ).BeginInit ( );
			this.SuspendLayout ( );
			// 
			// rbtSteadyTraf
			// 
			this.rbtSteadyTraf.AutoSize = true;
			this.rbtSteadyTraf.BackColor = System.Drawing.Color.Transparent;
			this.rbtSteadyTraf.Font = new System.Drawing.Font ( "Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
			this.rbtSteadyTraf.ForeColor = System.Drawing.Color.White;
			this.rbtSteadyTraf.Location = new System.Drawing.Point ( 93, 128 );
			this.rbtSteadyTraf.Name = "rbtSteadyTraf";
			this.rbtSteadyTraf.Size = new System.Drawing.Size ( 256, 28 );
			this.rbtSteadyTraf.TabIndex = 17;
			this.rbtSteadyTraf.Text = "Steady traffic flow";
			this.rbtSteadyTraf.UseVisualStyleBackColor = false;
			this.rbtSteadyTraf.CheckedChanged += new System.EventHandler ( this.TypeOfTrafficChanged );
			// 
			// rbnIncreasingTraf
			// 
			this.rbnIncreasingTraf.AutoSize = true;
			this.rbnIncreasingTraf.BackColor = System.Drawing.Color.Transparent;
			this.rbnIncreasingTraf.Checked = true;
			this.rbnIncreasingTraf.Font = new System.Drawing.Font ( "Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
			this.rbnIncreasingTraf.ForeColor = System.Drawing.Color.White;
			this.rbnIncreasingTraf.Location = new System.Drawing.Point ( 93, 85 );
			this.rbnIncreasingTraf.Name = "rbnIncreasingTraf";
			this.rbnIncreasingTraf.Size = new System.Drawing.Size ( 304, 28 );
			this.rbnIncreasingTraf.TabIndex = 18;
			this.rbnIncreasingTraf.TabStop = true;
			this.rbnIncreasingTraf.Text = "Increasing traffic flow";
			this.rbnIncreasingTraf.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font ( "Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point ( 49, 15 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size ( 399, 43 );
			this.label1.TabIndex = 16;
			this.label1.Text = "Traffic preferences";
			// 
			// nudTraffic
			// 
			this.nudTraffic.Font = new System.Drawing.Font ( "Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
			this.nudTraffic.Location = new System.Drawing.Point ( 148, 162 );
			this.nudTraffic.Maximum = new decimal ( new int [ ] {
            20,
            0,
            0,
            0} );
			this.nudTraffic.Minimum = new decimal ( new int [ ] {
            2,
            0,
            0,
            0} );
			this.nudTraffic.Name = "nudTraffic";
			this.nudTraffic.Size = new System.Drawing.Size ( 80, 51 );
			this.nudTraffic.TabIndex = 15;
			this.nudTraffic.Value = new decimal ( new int [ ] {
            10,
            0,
            0,
            0} );
			this.nudTraffic.Visible = false;
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.Transparent;
			this.btnStart.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnStart.ForeColor = System.Drawing.Color.Black;
			this.btnStart.Image = global::ATC.Properties.Resources.Start_stell;
			this.btnStart.Location = new System.Drawing.Point ( 635, 242 );
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size ( 100, 50 );
			this.btnStart.TabIndex = 19;
			this.btnStart.TabStop = false;
			this.btnStart.Tag = "Start";
			this.btnStart.Click += new System.EventHandler ( this.btnStart_Click );
			this.btnStart.MouseEnter += new System.EventHandler ( this.ButtonOver );
			this.btnStart.MouseLeave += new System.EventHandler ( this.ButtonOut );
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.Transparent;
			this.btnBack.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnBack.ForeColor = System.Drawing.Color.Black;
			this.btnBack.Image = global::ATC.Properties.Resources.Back_stell;
			this.btnBack.Location = new System.Drawing.Point ( 26, 242 );
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size ( 100, 50 );
			this.btnBack.TabIndex = 19;
			this.btnBack.TabStop = false;
			this.btnBack.Tag = "Back";
			this.btnBack.Click += new System.EventHandler ( this.btnBack_Click );
			this.btnBack.MouseEnter += new System.EventHandler ( this.ButtonOver );
			this.btnBack.MouseLeave += new System.EventHandler ( this.ButtonOut );
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
			this.tmrCloseWindow.Tag = "Cancel";
			this.tmrCloseWindow.Tick += new System.EventHandler ( this.tmrCloseWindow_Tick );
			// 
			// frmStartGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::ATC.Properties.Resources.Back;
			this.ClientSize = new System.Drawing.Size ( 747, 319 );
			this.Controls.Add ( this.btnBack );
			this.Controls.Add ( this.btnStart );
			this.Controls.Add ( this.rbtSteadyTraf );
			this.Controls.Add ( this.rbnIncreasingTraf );
			this.Controls.Add ( this.label1 );
			this.Controls.Add ( this.nudTraffic );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject ( "$this.Icon" ) ) );
			this.Name = "frmStartGame";
			this.Opacity = 0D;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmStartGame";
			this.TransparencyKey = System.Drawing.Color.Maroon;
			( ( System.ComponentModel.ISupportInitialize ) ( this.nudTraffic ) ).EndInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnStart ) ).EndInit ( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnBack ) ).EndInit ( );
			this.ResumeLayout ( false );
			this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtSteadyTraf;
        private System.Windows.Forms.RadioButton rbnIncreasingTraf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTraffic;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Timer tmrOpenWindow;
        private System.Windows.Forms.Timer tmrCloseWindow;
    }
}