using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATC
{
    public partial class frmStartGame : Form
    {
        public double MaxTraf;

        public frmStartGame(double MT)
        {
            InitializeComponent();
            this.MaxTraf = MT;
        }

        //СТАРТ
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbtSteadyTraf.Checked)
                MaxTraf = (int)nudTraffic.Value;
            else
                MaxTraf = 0;
            tmrCloseWindow.Tag = "Start";
            tmrCloseWindow.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tmrCloseWindow.Tag = "Close";
            tmrCloseWindow.Start();
        }

        //СМЕНА ТИПА ТРАФИКА
        private void TypeOfTrafficChanged(object sender, EventArgs e)
        {
            if (rbtSteadyTraf.Checked)
                nudTraffic.Show();
            else
                nudTraffic.Hide();
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
                if (tmrCloseWindow.Tag.ToString() == "Start")
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
