﻿using BTL.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace BTL
{
    public partial class DangNhap : Form
    {
        QLBanSachContext qLBanSachContext = new QLBanSachContext();

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
                MessageBox.Show("Đăng nhập thành công");
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
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
