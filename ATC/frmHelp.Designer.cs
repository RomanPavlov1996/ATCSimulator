namespace ATC
{
    partial class frmHelp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmHelp ) );
			this.lbl1 = new System.Windows.Forms.Label ( );
			this.btnBack = new System.Windows.Forms.PictureBox ( );
			this.tmrOpenWindow = new System.Windows.Forms.Timer ( this.components );
			this.tmrCloseWindow = new System.Windows.Forms.Timer ( this.components );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnBack ) ).BeginInit ( );
			this.SuspendLayout ( );
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.BackColor = System.Drawing.Color.Transparent;
			this.lbl1.Font = new System.Drawing.Font ( "Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.lbl1.ForeColor = System.Drawing.Color.White;
			this.lbl1.Location = new System.Drawing.Point ( 12, 26 );
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size ( 694, 96 );
			this.lbl1.TabIndex = 9;
			this.lbl1.Text = "- In Exit-zone send plane to Control.\r\n- After approach send plane to Tower.\r\n- T" +
				"he orange label means plane is not assumed.\r\n- The planes should leave your cont" +
				"rol zone above 7000ft.\r\n";
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.Transparent;
			this.btnBack.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnBack.ForeColor = System.Drawing.Color.Black;
			this.btnBack.Image = global::ATC.Properties.Resources.Back_stell;
			this.btnBack.Location = new System.Drawing.Point ( 12, 257 );
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size ( 100, 50 );
			this.btnBack.TabIndex = 20;
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
			this.tmrCloseWindow.Tick += new System.EventHandler ( this.tmrCloseWindow_Tick );
			// 
			// frmHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 15F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::ATC.Properties.Resources.Back;
			this.ClientSize = new System.Drawing.Size ( 747, 319 );
			this.Controls.Add ( this.btnBack );
			this.Controls.Add ( this.lbl1 );
			this.Font = new System.Drawing.Font ( "Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject ( "$this.Icon" ) ) );
			this.MinimizeBox = false;
			this.Name = "frmHelp";
			this.Opacity = 0D;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TransparencyKey = System.Drawing.Color.Maroon;
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnBack ) ).EndInit ( );
			this.ResumeLayout ( false );
			this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Timer tmrOpenWindow;
        private System.Windows.Forms.Timer tmrCloseWindow;
    }
}