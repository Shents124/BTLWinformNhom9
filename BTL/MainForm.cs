﻿using System;
using BTL.Son;
using System.Windows.Forms;
using BTL.Son;

namespace BTL
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;

        private int maTK;
        private string tenDN;
        private string matKhau;
        private string hoTen;
<<<<<<< HEAD
=======

>>>>>>> sonV2
        private bool isAdmin;

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }
<<<<<<< HEAD
        public MainForm(int maTK, string tenDN, string matKhau, string hoTen,bool admin)
=======
        public MainForm(int maTK, string tenDN, string matKhau, string hoTen, bool admin)
>>>>>>> sonV2
        {
            InitializeComponent();

            this.maTK = maTK;
            this.tenDN = tenDN;
            this.matKhau = matKhau;
            this.hoTen = hoTen;
            isAdmin = admin;
            CustomizeDesign();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        #region Ẩn hiện thị subpanel
        private void CustomizeDesign()
        {
            if(isAdmin == true)
            {
                panelQLTaiKhoan.Visible = false;
                panelDHNhapXuat.Visible = false;
                panelSach.Visible = false;
                btnQLTK.Visible = false;
            }
            else
            {
                panelQLTaiKhoan.Visible = false;
                panelDHNhapXuat.Visible = false;
                panelSach.Visible = false;

                btnBaoTriTK.Visible = false;
                btnDHNhapXuat.Visible = false;
                btnSach.Visible = false;
            }
        }

        private void HideSubMenu()
        {
            if (panelQLTaiKhoan.Visible == true)
                panelQLTaiKhoan.Visible = false;
            if (panelDHNhapXuat.Visible == true)
                panelDHNhapXuat.Visible = false;
            if (panelSach.Visible == true)
                panelSach.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #endregion

        #region Quản lý tài khoản
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelQLTaiKhoan);
        }

        private void btnBaoTriTK_Click(object sender, EventArgs e)
        {
            // Hiển thị form bảo trì tài khoản
            HideSubMenu();
            OpenChildForm(new frmBaoTriTK(), sender);
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            // Hiển thị form quản lý tài khoản
            HideSubMenu();
            OpenChildForm(new frmQLTaiKhoanCaNhan(maTK, hoTen, tenDN, matKhau), null);
            lblTitle.Text = "Quản lý thông tin cá nhân";
<<<<<<< HEAD
=======

>>>>>>> sonV2
        }
        #endregion

        #region Quản lý hóa đơn 
        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            // Hiển thị form quản lý hóa đơn
            OpenChildForm(new QuanLyHoaDonForm(maTK), sender);
            HideSubMenu();
        }
        #endregion

        #region Quản lý nhập xuất đơn đặt hàng
        private void btnDHNhapXuat_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDHNhapXuat);
        }

        private void btnQLDonDatHang_Click(object sender, EventArgs e)
        {
            // Hiển thị form quản lý đơn đặt hàng
            HideSubMenu();
            OpenChildForm(new QLDonDatHang(), sender);
        }

        private void btnQLDonNhapHang_Click(object sender, EventArgs e)
        {
            // Hiển thị form quản lý đơn nhập hàng
            OpenChildForm(new FormQuanLyDonHang(), sender);
            HideSubMenu();
        }

        private void btnQLNhaCungCap_Click(object sender, EventArgs e)
        {
            // Hiển thị form quản lý nhà cung cấp
            OpenChildForm(new QuanLyNhaCC(), sender);
            HideSubMenu();
        }
        #endregion

        #region Quản lý sách
        private void btnSach_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSach);
        }

        private void btnBaoTriSach_Click(object sender, EventArgs e)
        {
            // Hiển thị form bảo trì sách
            HideSubMenu();
        }

        private void btnBaoTriDMSach_Click(object sender, EventArgs e)
        {
            // Hiển thị form bải trì danh mục sách
            HideSubMenu();
        }
        #endregion

        #region Quản lý thông tin khách hàng
        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            // Hiển thị form quản lý thông tin khách hàng
            OpenChildForm(new FormQuanLyThongTinKH(), sender);
            HideSubMenu();
        }
        #endregion

        #region Thống kê báo cáo
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Hiển thị form thống kê báo cáo
            HideSubMenu();
        }
        #endregion

        #region Hiển thị child form

        // Chỉ mở được một form trên panel
        // Gọi hàm này khi nhấn các button mở form ở panel, tham số là form muốn mở
        private void OpenChildForm(Form childForm, object sender)
        {
            // Đóng form đang mở
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            if (sender != null)
                lblTitle.Text = (sender as Button).Text;
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Quay lại màn hình đăng nhập", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                //DangNhap dn = new DangNhap();
                //dn.ShowDialog();
            }
            else
                e.Cancel = true;
        }
    }
}
