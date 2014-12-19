using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATC
{
    public partial class frmMenu : Form
    {
        double MaxTraf;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void ButtonOver(object sender, EventArgs e)
        {
            PictureBox num = (PictureBox)sender;
            num.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(num.Tag + "_push");
        }

        private void ButtonOut(object sender, EventArgs e)
        {
            PictureBox num = (PictureBox)sender;
            num.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(num.Tag + "_stell");
        }

        private void tmrOpenWindow_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.1;
            else
                tmrOpenWindow.Stop();
        }

        private void tmrCloseWindow_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
                this.Opacity -= 0.1;
            else
            {
                tmrCloseWindow.Stop();
                Application.Exit();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            #region Оформление окна

            this.MinimumSize = this.Size;

            //Start game
            btnStart.Top = (int)((double)this.Height / 2.88);
            btnStart.Left = this.Width / 2 - 100;

            //Highscore
            btnHighScore.Top = (int)((double)this.Height / 3.36);
            btnHighScore.Left = this.Width / 4 - 100;

            //Exit
            btnExit.Top = (int)((double)this.Height / 3.30);
            btnExit.Left = this.Width / 4 * 3 - 35;

            //Help
            btnHelp.Top = (int)((double)this.Height * 0.62);
            btnHelp.Left = (int)(this.Width / 8 - 60);

            //About
            btnAbout.Top = (int)((double)this.Height * 0.62);
            btnAbout.Left = (int)(this.Width / 8 * 7 - 100);


            if ((double)this.Width / (double)this.Height >= 1.5)
            {
				this.BackgroundImage = Properties.Resources.BG_16x9v1_2;
                //Start game
                btnStart.Top = (int)((double)this.Height / 2.48);
                //Help
                btnHelp.Top = (int)((double)this.Height * 0.73);
                //About
                btnAbout.Top = (int)((double)this.Height * 0.73);
            }

            #endregion
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            frmHighScore form = new frmHighScore();
            form.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmStartGame form = new frmStartGame(MaxTraf);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
				MaxTraf = form.MaxTraf;
                frmRadar radarForm = new frmRadar(MaxTraf, this);
                radarForm.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            tmrCloseWindow.Start();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp form = new frmHelp();
            form.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.ShowDialog();
        }
    }
}
