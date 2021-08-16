using BTL.Models;
using System;
using System.Linq;
using System.Windows.Forms;


namespace BTL
{
    public partial class DangNhap : Form
    {
        QLBanSachContext qLBanSachContext = new QLBanSachContext();
        public int MaTK { get; set; }

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (isValidUser())
            {
                //this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
            this.DialogResult = DialogResult.OK;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isValidUser()
        {
            try
            {
                Check();

                var taikhoan = from tk in qLBanSachContext.Taikhoans
                               where tk.TenDangNhap == txtTenDangNhap.Text && tk.MatKhau == txtMatKhau.Text
                               select tk;
                MaTK = taikhoan.ToList()[0].MaTk;

                if (taikhoan.Any())
                    return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }

        private void Check()
        {
            if (txtTenDangNhap.Text == String.Empty)
                throw new Exception("Tên đăng nhập không được để trống");

            if (txtMatKhau.Text == string.Empty)
                throw new Exception("Mật khẩu không được để trống");
        }

    }
}
