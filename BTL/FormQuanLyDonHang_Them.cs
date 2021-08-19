using BTL.Models;
using System;
using System.Collections;
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
    public partial class FormQuanLyDonHang_Them : Form
    {
        #region Declare
        QLBanSachContext obj = new QLBanSachContext();
        int masach = 0;
        List<Sach> li = new List<Sach>();
        List<Loaisach> li1 = new List<Loaisach>();
        AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        string[] arr;
        #endregion

        public FormQuanLyDonHang_Them()
        {
            InitializeComponent();
        }

        #region UserMethods
        private void GetData()
        {
            //ma phieu
            int maph = (from m in obj.Pnhaps
                        orderby m.MaPn
                        select m.MaPn).LastOrDefault();
            txtMaPhieu.Text = maph + 1 + "";
            //thong tin nha cung cap
            var ncc = from n in obj.Nhaccs
                      select n;
            cbbNhaCC.DataSource = ncc.ToList();
            cbbNhaCC.DisplayMember = "TenNhaCc";
            cbbNhaCC.ValueMember = "MaNhaCc";

            //thong tin sach, loai sach
            var sach = from s in obj.Saches
                       select s;
            li = sach.ToList();
            var loai = from l in obj.Loaisaches
                       select l;
            li1 = loai.ToList();

            //goi y ten sach
            var ts = from s in obj.Saches
                     select s.TenSach;
            arr = ts.ToArray();
            collection.AddRange(arr);
            this.txtTenSach.AutoCompleteCustomSource = collection;
        }

        private void TongTien()
        {
            double t = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[7].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum();
            txtTongTien.Text = t.ToString("N1");
        }

        private void ClearTextBox()
        {
            txtTenSach.Clear();
            txtSoluong.Clear();
            txtDongia.Clear();
            txtTheloai.Clear();
            txtTacgia.Clear();
            txtTenSach.Focus();
        }
        #endregion

        private void FormQuanLyDonHang_Them_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool k = false;
            foreach (Sach item in li)
                if (item.TenSach == txtTenSach.Text)
                {
                    k = true;
                    masach = item.MaSach;
                }
            if (k)
            {
                Sach s = obj.Saches.SingleOrDefault(s => s.MaSach == masach);
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = s.MaSach;
                row.Cells[1].Value = s.TenSach;
                row.Cells[2].Value = txtTheloai.Text;
                row.Cells[3].Value = txtTacgia.Text;
                row.Cells[4].Value = s.NhaXuatBan;
                row.Cells[5].Value = txtSoluong.Text;
                row.Cells[6].Value = txtDongia.Text;
                double tt = int.Parse(txtSoluong.Text) * double.Parse(txtDongia.Text);
                row.Cells[7].Value = tt.ToString("N1");
                row.Cells[8].Value = "Xóa";
                dataGridView1.Rows.Add(row);
                TongTien();
                ClearTextBox();
            }
            else
                MessageBox.Show("Không tồn tại sách trong đơn đặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            if (e.ColumnIndex == dataGridView1.Columns["Column9"].Index)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(selectedRow);
                    TongTien();
                }
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            for (int i = 0; i < arr.Length; i++)
                if (t.Text == arr[i])
                    foreach (Sach s in li)
                        if (s.TenSach == arr[i])
                        {
                            Loaisach ls = obj.Loaisaches.SingleOrDefault(l => l.MaLoai == s.MaLoai);
                            txtTheloai.Text = ls.TenLoai;
                            txtTacgia.Text = s.TacGia;
                        }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //lay thong tin tu datagridview
            int[] ms = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[0].FormattedValue.ToString() != string.Empty
                        select Convert.ToInt32(row.Cells[0].FormattedValue)).ToArray();

            int[] sl = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[5].FormattedValue.ToString() != string.Empty
                        select Convert.ToInt32(row.Cells[5].FormattedValue)).ToArray();

            int[] dg = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[6].FormattedValue.ToString() != string.Empty
                        select Convert.ToInt32(row.Cells[6].FormattedValue)).ToArray();
            //them phieu nhap
            Pnhap pn = new Pnhap();
            pn.NgayNhap = dateTimePicker1.Value;
            obj.Pnhaps.Add(pn);
            obj.SaveChanges();
            
            //them chi tiet phieu nhap
            var p = obj.Pnhaps
                .OrderBy(s => s.MaPn)
                .LastOrDefault();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                Ctpnhap ctpn = new Ctpnhap();
                ctpn.MaPn = p.MaPn;
                ctpn.MaSach = ms[i];
                ctpn.SlNhap = sl[i];
                ctpn.DgNhap = dg[i];

                obj.Ctpnhaps.Add(ctpn);
            }
            obj.SaveChanges();

            //dong form sau khi them
            this.Close();
        }
    }
}
