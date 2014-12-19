using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATC
{
    public partial class frmHelp : Form
    {
        public frmHelp()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            tmrCloseWindow.Start();
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
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
