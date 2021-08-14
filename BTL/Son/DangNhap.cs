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
        public string MatKhau { get; set; }

        public string HoTen { get; set; }

        public string TenDN { get; set; }

        public bool isAdmin { get; set; }

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
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isValidUser()
        {
            if (Check())
            {
                var taikhoan = (from tk in qLBanSachContext.Taikhoans
                                where tk.TenDangNhap == txtTenDangNhap.Text && tk.MatKhau == txtMatKhau.Text
                                select tk).SingleOrDefault();

                if (taikhoan != null)
                {
                    MaTK = taikhoan.MaTk;
                    MatKhau = taikhoan.MatKhau;
                    HoTen = taikhoan.HoTen;
                    TenDN = taikhoan.TenDangNhap;
                    isAdmin = taikhoan.LoaiTk;
                    return true;
                }                   
            }

            return false;
        }

        private bool Check()
        {
            if (txtTenDangNhap.Text == String.Empty)
            {
                MessageBox.Show("Tên đăng nhập không được để trống");
                return false;
            }


            if (txtMatKhau.Text == string.Empty)
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return false;
            }
            return true;
        }

    }
}
