namespace ATC
{
    partial class frmLooser
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
			this.lblMessage = new System.Windows.Forms.Label ( );
			this.btnMenu = new System.Windows.Forms.PictureBox ( );
			this.tmrOpenWindow = new System.Windows.Forms.Timer ( this.components );
			this.tmrCloseWindow = new System.Windows.Forms.Timer ( this.components );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnMenu ) ).BeginInit ( );
			this.SuspendLayout ( );
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.BackColor = System.Drawing.Color.Transparent;
			this.lblMessage.Font = new System.Drawing.Font ( "Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
			this.lblMessage.ForeColor = System.Drawing.Color.White;
			this.lblMessage.Location = new System.Drawing.Point ( 7, 9 );
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size ( 639, 129 );
			this.lblMessage.TabIndex = 9;
			this.lblMessage.Text = "AFL000 and AFL001 were crashed!\r\nInbound: 0\r\nOutbound: 0\r\n";
			// 
			// btnMenu
			// 
			this.btnMenu.BackColor = System.Drawing.Color.Transparent;
			this.btnMenu.Font = new System.Drawing.Font ( "Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.btnMenu.ForeColor = System.Drawing.Color.Black;
			this.btnMenu.Image = global::ATC.Properties.Resources.Menu_stell;
			this.btnMenu.Location = new System.Drawing.Point ( 12, 257 );
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size ( 147, 50 );
			this.btnMenu.TabIndex = 20;
			this.btnMenu.TabStop = false;
			this.btnMenu.Tag = "Menu";
			this.btnMenu.Click += new System.EventHandler ( this.btnBack_Click );
			this.btnMenu.MouseEnter += new System.EventHandler ( this.ButtonOver );
			this.btnMenu.MouseLeave += new System.EventHandler ( this.ButtonOut );
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
			// frmLooser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF ( 7F, 15F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = global::ATC.Properties.Resources.Back;
			this.ClientSize = new System.Drawing.Size ( 747, 319 );
			this.Controls.Add ( this.btnMenu );
			this.Controls.Add ( this.lblMessage );
			this.Font = new System.Drawing.Font ( "Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 204 ) ) );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimizeBox = false;
			this.Name = "frmLooser";
			this.Opacity = 0D;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TransparencyKey = System.Drawing.Color.Black;
			this.Load += new System.EventHandler ( this.frmLooser_Load );
			( ( System.ComponentModel.ISupportInitialize ) ( this.btnMenu ) ).EndInit ( );
			this.ResumeLayout ( false );
			this.PerformLayout ( );

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Timer tmrOpenWindow;
        private System.Windows.Forms.Timer tmrCloseWindow;
    }
}