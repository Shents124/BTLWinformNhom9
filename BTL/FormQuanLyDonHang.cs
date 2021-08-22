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
        int index;
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
            dataGridView1.Columns[0].HeaderText = "Mã phiếu nhập";
            dataGridView1.Columns[1].HeaderText = "Tên nhà cung cấp";
            dataGridView1.Columns[2].HeaderText = "Ngày nhập";
            dataGridView1.Columns[3].HeaderText = "Mã đơn đặt hàng";
        }

        private void ShowChiTiet()
        {
            dataGridView2.Rows.Clear();
            var query = from s in obj.Ctpnhaps
                        where s.MaPn == mapn
                        select s;
            List<Ctpnhap> list = query.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Sach s = obj.Saches.SingleOrDefault(s => s.MaSach == list[i].MaSach);
                DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                row.Cells[0].Value = s.TenSach;
                row.Cells[1].Value = list[i].SlNhap;
                row.Cells[2].Value = list[i].DgNhap;
                double tt = Convert.ToInt32(list[i].SlNhap) * Convert.ToDouble(list[i].DgNhap);
                row.Cells[3].Value = tt.ToString("N1");
                dataGridView2.Rows.Add(row);
            }
            string[] tien = (from DataGridViewRow r in dataGridView2.Rows
                             where r.Cells[3].FormattedValue.ToString() != string.Empty
                             select r.Cells[3].FormattedValue.ToString()).ToArray();
            double tong = 0;
            for (int i = 0; i < tien.Length; i++)
                tong += double.Parse(tien[i]);
            DataGridViewRow rw = (DataGridViewRow)dataGridView2.Rows[0].Clone();
            rw.Cells[2].Value = "Tổng tiền";
            rw.Cells[3].Value = tong.ToString("N1");
            dataGridView2.Rows.Add(rw);
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
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Pnhap pn = obj.Pnhaps.SingleOrDefault(s => s.MaPn == mapn);
                obj.Pnhaps.Remove(pn);
                obj.SaveChanges();
                ShowDanhSach();
                txtMaPhieu.Text = "...";
                txtTenNCC.Text = "...";
                txtNgayNhap.Text = "...";
                txtMaDonDH.Text = "...";
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
                dataGridView1.CurrentCell = null;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Pnhap pn = obj.Pnhaps.SingleOrDefault(s => s.MaPn == int.Parse(txtTimPhieu.Text));
            if (pn != null)
            {
                int[] mp = (from DataGridViewRow row in dataGridView1.Rows
                           where row.Cells[0].FormattedValue.ToString() != string.Empty
                           select Convert.ToInt32(row.Cells[0].FormattedValue)).ToArray();
                for (int i = 0; i < mp.Length; i++)
                    if (pn.MaPn == mp[i])
                    {
                        mapn = mp[i];
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[i].Cells[0].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        txtMaPhieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        txtTenNCC.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        txtNgayNhap.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        txtMaDonDH.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        ShowChiTiet();
                        txtTimPhieu.Clear();
                    }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã phiếu : " + txtTimPhieu.Text, "Thất bại");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime bd = dtpBD.Value;
            DateTime kt = dtpKT.Value;
            var query = from p in obj.Pnhaps
                        where p.NgayNhap >= bd && p.NgayNhap <= kt
                        select new
                        {
                            p.MaPn,
                            p.MaDonDhNavigation.MaNhaCcNavigation.TenNhaCc,
                            p.NgayNhap,
                            p.MaDonDh
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDanhSach();
            txtMaPhieu.Text = "...";
            txtTenNCC.Text = "...";
            txtNgayNhap.Text = "...";
            txtMaDonDH.Text = "...";
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView1.CurrentCell = null;
        }
    }
}
