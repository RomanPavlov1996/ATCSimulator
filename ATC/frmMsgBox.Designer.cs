namespace ATC
{
    partial class frmMsgBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager ( typeof ( frmMsgBox ) );
			this.lblText = new System.Windows.Forms.Label ( );
			this.tmrOpenWindow = new System.Windows.Forms.Timer ( this.components );
			this.tmrCloseWindow = new System.Windows.Forms.Timer ( this.components );
			this.tmrDelay = new System.Windows.Forms.Timer ( this.components );
			this.SuspendLayout ( );
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.BackColor = System.Drawing.Color.Transparent;
			this.lblText.Font = new System.Drawing.Font ( "Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
			this.lblText.ForeColor = System.Drawing.Color.White;
			this.lblText.Location = new System.Drawing.Point ( 3, 2 );
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size ( 130, 22 );
			this.lblText.TabIndex = 9;
			this.lblText.Text = "Message text";
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
			// tmrDelay
			// 
			this.tmrDelay.Interval = 1000;
			this.tmrDelay.Tick += new System.EventHandler ( this.tmrDelay_Tick );
			// 
			// frmMsgBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 15F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 1 ) ) ) ), ( ( int ) ( ( ( byte ) ( 1 ) ) ) ), ( ( int ) ( ( ( byte ) ( 1 ) ) ) ) );
			this.BackgroundImage = global::ATC.Properties.Resources.msgBack;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size ( 226, 43 );
			this.Controls.Add ( this.lblText );
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font ( "Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject ( "$this.Icon" ) ) );
			this.Location = new System.Drawing.Point ( 50, 100 );
			this.MinimizeBox = false;
			this.Name = "frmMsgBox";
			this.Opacity = 0D;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.FromArgb ( ( ( int ) ( ( ( byte ) ( 1 ) ) ) ), ( ( int ) ( ( ( byte ) ( 1 ) ) ) ), ( ( int ) ( ( ( byte ) ( 1 ) ) ) ) );
			this.Load += new System.EventHandler ( this.frmMsgBox_Load );
			this.ResumeLayout ( false );
			this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Timer tmrOpenWindow;
        private System.Windows.Forms.Timer tmrCloseWindow;
        private System.Windows.Forms.Timer tmrDelay;
    }
}