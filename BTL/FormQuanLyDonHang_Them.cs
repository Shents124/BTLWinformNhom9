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
        List<Nhacc> li2 = new List<Nhacc>();
        List<Dondh> li3 = new List<Dondh>();
        List<Ctdondh> li4 = new List<Ctdondh>();
        AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection collection1 = new AutoCompleteStringCollection();
        int[] codelist; //chua tat ca ma don dat hang
        string[] bookslist; //chua ten sach trong ctdondh
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
            li2 = ncc.ToList();

            //thong tin sach, loai sach
            var sach = from s in obj.Saches
                       select s;
            li = sach.ToList();
            var loai = from l in obj.Loaisaches
                       select l;
            li1 = loai.ToList();

            //thong tin don dat hang
            var dondh = from d in obj.Dondhs
                        select d;
            li3 = dondh.ToList();

            //goi y ma don dat hang
            var dh = (from d in obj.Dondhs
                      select d.MaDonDh);
            codelist = dh.ToArray();
            for (int i = 0; i < codelist.Length; i++)
                collection1.Add(codelist[i].ToString());
            this.txtMaDonHang.AutoCompleteCustomSource = collection1;

            //lay thong tin ctdondh
            var ct = from c in obj.Ctdondhs
                     select c;
            li4 = ct.ToList();
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
            txtMaxSL.Clear();
            txtTenSach.Focus();
        }
        #endregion

        private void FormQuanLyDonHang_Them_Load(object sender, EventArgs e)
        {
            GetData();
            panel2.Hide();
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
                row.Cells[6].Value = double.Parse(txtDongia.Text);
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
            
            for (int i = 0; i < bookslist.Length; i++)
                if (t.Text == bookslist[i])
                {
                    foreach (Ctdondh c in li4)
                    {
                        Sach s = obj.Saches.SingleOrDefault(sa => sa.TenSach == bookslist[i]);
                        if (s != null && s.MaSach == c.MaSach)
                        {
                            Loaisach ls = obj.Loaisaches.SingleOrDefault(l => l.MaLoai == s.MaLoai);
                            txtTheloai.Text = ls.TenLoai;
                            txtTacgia.Text = s.TacGia;
                            txtMaxSL.Text = Convert.ToString(c.SlDat);
                            txtDongia.Text = (s.DonGiaNhap).ToString("N1");
                        }
                    }
                    errorProvider1.SetError(txtTenSach, null);
                }
                else
                    errorProvider1.SetError(txtTenSach, "Sai tên sách hoặc không có sách này");
            if(txtTenSach.Text == bookslist[0]) errorProvider1.SetError(txtTenSach, null);
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
            pn.MaDonDh = int.Parse(txtMaDonHang.Text);
            pn.NgayNhap = dateTimePicker1.Value;
            obj.Pnhaps.Add(pn);
            obj.SaveChanges();

            //them chi tiet phieu nhap
            var p = obj.Pnhaps
                .OrderBy(s => s.MaPn)
                .LastOrDefault();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
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

        private void txtMaDonHang_TextChanged(object sender, EventArgs e)
        {
            int x = -1;
            string name = "";
            bool k = false;
            TextBox t = sender as TextBox;
            for (int i = 0; i < codelist.Length; i++)
                if (t.Text == codelist[i].ToString())
                {
                    foreach (Dondh d in li3)
                        if (d.MaDonDh == codelist[i])
                        {
                            x = (int)d.MaNhaCc;
                        }
                    k = true;
                }
            foreach (Nhacc n in li2)
                if (n.MaNhaCc == x)
                    name = n.TenNhaCc;
            txtTenNCC.Text = name;

            if (k)
            {
                txtMaDonHang.ReadOnly = true;

                //goi y ten sach co trong ctdondh
                var ts = from s in obj.Ctdondhs
                         where s.MaSach == s.MaSachNavigation.MaSach && s.MaDonDh == int.Parse(txtMaDonHang.Text)
                         select s.MaSachNavigation.TenSach;
                bookslist = ts.ToArray();
                collection.AddRange(bookslist);
                this.txtTenSach.AutoCompleteCustomSource = collection;

                panel2.Show();
            }
        }

        private void txtMaDonHang_DoubleClick(object sender, EventArgs e)
        {
            txtMaDonHang.ReadOnly = false;
            panel2.Hide();
            ClearTextBox();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            collection.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < bookslist.Length; i++)
                s += i +" - "+ bookslist[i] + "\n";
            MessageBox.Show(s);
        }

        private void txtSoluong_TextChanged(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            try
            {
                if (int.Parse(t.Text) > int.Parse(txtMaxSL.Text))
                {
                    DialogResult dr = MessageBox.Show("Bạn đang nhập số lượng quá số lượng đặt, tiếp tục ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No)
                    {
                        txtSoluong.Clear();
                        txtSoluong.Focus();
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}

