using System;
using System.Windows.Forms;
using BTL.Models;
namespace BTL
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DangNhap dangNhap = new DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(dangNhap.MaTK));
            }
            else
                Application.Exit();
        }
    }
}
