namespace ATC
{
    partial class frmAbout
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			this.lbl1 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.PictureBox();
			this.tmrOpenWindow = new System.Windows.Forms.Timer(this.components);
			this.tmrCloseWindow = new System.Windows.Forms.Timer(this.components);
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl3 = new System.Windows.Forms.Label();
			this.lbl4 = new System.Windows.Forms.Label();
			this.lbl5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.BackColor = System.Drawing.Color.Transparent;
			this.lbl1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl1.ForeColor = System.Drawing.Color.White;
			this.lbl1.Location = new System.Drawing.Point(12, 9);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(719, 68);
			this.lbl1.TabIndex = 9;
			this.lbl1.Text = "Air Traffic Control Training Simulator v 1.2\r\n        NWD-Group";
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.Transparent;
			this.btnBack.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBack.ForeColor = System.Drawing.Color.Black;
			this.btnBack.Image = global::ATC.Properties.Resources.Back_stell;
			this.btnBack.Location = new System.Drawing.Point(12, 257);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(100, 50);
			this.btnBack.TabIndex = 20;
			this.btnBack.TabStop = false;
			this.btnBack.Tag = "Back";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			this.btnBack.MouseEnter += new System.EventHandler(this.ButtonOver);
			this.btnBack.MouseLeave += new System.EventHandler(this.ButtonOut);
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
			// lbl2
			// 
			this.lbl2.AutoSize = true;
			this.lbl2.BackColor = System.Drawing.Color.Transparent;
			this.lbl2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl2.ForeColor = System.Drawing.Color.White;
			this.lbl2.Location = new System.Drawing.Point(15, 111);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(72, 57);
			this.lbl2.TabIndex = 21;
			this.lbl2.Text = "Site:\r\nE-mail:\r\nAuthor:";
			// 
			// lbl3
			// 
			this.lbl3.AutoSize = true;
			this.lbl3.BackColor = System.Drawing.Color.Transparent;
			this.lbl3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl3.ForeColor = System.Drawing.Color.White;
			this.lbl3.Location = new System.Drawing.Point(91, 111);
			this.lbl3.Name = "lbl3";
			this.lbl3.Size = new System.Drawing.Size(225, 57);
			this.lbl3.TabIndex = 21;
			this.lbl3.Text = "http://atc.nwd-group.com\r\nprogramer@nwd-group.com\r\nRoman Pavlov";
			// 
			// lbl4
			// 
			this.lbl4.AutoSize = true;
			this.lbl4.BackColor = System.Drawing.Color.Transparent;
			this.lbl4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl4.ForeColor = System.Drawing.Color.White;
			this.lbl4.Location = new System.Drawing.Point(460, 147);
			this.lbl4.Name = "lbl4";
			this.lbl4.Size = new System.Drawing.Size(90, 22);
			this.lbl4.TabIndex = 22;
			this.lbl4.Text = "Credits:";
			// 
			// lbl5
			// 
			this.lbl5.AutoSize = true;
			this.lbl5.BackColor = System.Drawing.Color.Transparent;
			this.lbl5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl5.ForeColor = System.Drawing.Color.White;
			this.lbl5.Location = new System.Drawing.Point(388, 184);
			this.lbl5.Name = "lbl5";
			this.lbl5.Size = new System.Drawing.Size(126, 57);
			this.lbl5.TabIndex = 23;
			this.lbl5.Text = "Design:\r\nHelp:\r\nBeta-testing:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(520, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 57);
			this.label1.TabIndex = 21;
			this.label1.Text = "Artem Kharkov\r\nAndrew Menshenin\r\nRU-IVAO-DIVISION";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(115, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 24);
			this.label2.TabIndex = 24;
			this.label2.Text = "©";
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.BackgroundImage = global::ATC.Properties.Resources.Back;
			this.ClientSize = new System.Drawing.Size(747, 319);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbl5);
			this.Controls.Add(this.lbl4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl3);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.lbl1);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.Opacity = 0D;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TransparencyKey = System.Drawing.Color.Maroon;
			((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Timer tmrOpenWindow;
        private System.Windows.Forms.Timer tmrCloseWindow;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}