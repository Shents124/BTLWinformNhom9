using System;
using System.Windows.Forms;

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
<<<<<<< HEAD
            //DangNhap dangNhap = new DangNhap();
            //if (dangNhap.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new MainForm(dangNhap.MaTK, dangNhap.TenDN, dangNhap.MatKhau, dangNhap.HoTen, dangNhap.isAdmin));
            //}
            //else
            //    Application.Exit();
=======

            DangNhap dangNhap = new DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(dangNhap.MaTK, dangNhap.TenDN, dangNhap.MatKhau, dangNhap.HoTen, dangNhap.isAdmin));
            }
            else
                Application.Exit();
>>>>>>> sonV2
        }
    }
}
