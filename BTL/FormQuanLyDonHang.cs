using BTL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormQuanLyDonHang : Form
    {
        QLBanSachContext obj = new QLBanSachContext();
        int mapn;
        public FormQuanLyDonHang()
        {
            InitializeComponent();
        }
        private void ShowDanhSach()
        {
            var query = from p in obj.Pnhaps
                        select new
                        {
                            p.MaPn,
                            p.MaDonDhNavigation.MaNhaCcNavigation.TenNhaCc,
                            p.NgayNhap,
                            p.MaDonDh
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void ShowChiTiet()
        {
            var query = from p in obj.Ctpnhaps
                        where p.MaPn == mapn
                        select new
                        {
                            p.MaSachNavigation.TenSach,
                            p.SlNhap,
                            p.DgNhap,
                        };
            dataGridView2.DataSource = query.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region HoverButton
        private void btnSearch_MouseMove(object sender, MouseEventArgs e)
        {
            btnSearch.Image = Properties.Resources.icons8_google_web_search_48__1_;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.Image = Properties.Resources.icons8_google_web_search_48;
        }

        private void btnFilter_MouseMove(object sender, MouseEventArgs e)
        {
            btnFilter.Image = Properties.Resources.icons8_filter_48__1_;
        }

        private void btnFilter_MouseLeave(object sender, EventArgs e)
        {
            btnFilter.Image = Properties.Resources.icons8_filter_48;
        }

        private void btnRefresh_MouseMove(object sender, MouseEventArgs e)
        {
            btnRefresh.Image = Properties.Resources.icons8_refresh_48__1_;
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.Image = Properties.Resources.icons8_refresh_48;
        }
        #endregion

        private void FormQuanLyDonHang_Load(object sender, EventArgs e)
        {
            ShowDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormQuanLyDonHang_Them frmQLDH_Them = new FormQuanLyDonHang_Them();
            if (Application.OpenForms[frmQLDH_Them.Name] == null)
            {
                frmQLDH_Them.ShowDialog();
            }
            else
                Application.OpenForms[frmQLDH_Them.Name].Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                txtMaPhieu.Text = selectedRow.Cells[0].Value.ToString();
                mapn = int.Parse(selectedRow.Cells[0].Value.ToString());
                txtTenNCC.Text = selectedRow.Cells[1].Value.ToString();
                txtNgayNhap.Text = selectedRow.Cells[2].Value.ToString();
                txtMaDonDH.Text = selectedRow.Cells[3].Value.ToString();
                ShowChiTiet();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error");
                return;
            }
        }

        private void FormQuanLyDonHang_Activated(object sender, EventArgs e)
        {
            ShowDanhSach();
        }
    }
}
