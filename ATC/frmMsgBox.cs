using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATC
{
    public partial class frmMsgBox : Form
    {
        string text;

        public frmMsgBox(string mText)
        {
            InitializeComponent();
            text = mText;
        }

        private void tmrOpenWindow_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.1;
            else
            {
                tmrOpenWindow.Stop();
                tmrDelay.Start();
            }
        }

        private void tmrCloseWindow_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
                this.Opacity -= 0.1;
            else
            {
                tmrCloseWindow.Stop();
                this.Dispose();
            }
        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            tmrDelay.Stop();
            tmrCloseWindow.Start();
        }

        private void frmMsgBox_Load(object sender, EventArgs e)
        {
            lblText.Text = text;
        }
    }
}
