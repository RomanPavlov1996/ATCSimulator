using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
			try
			{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMenu());
			}
			catch (Exception e)
			{
			    MessageBox.Show("There was an error in the application. Please send a report.\n\n<" + e.Message + ">", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }
    }
}
