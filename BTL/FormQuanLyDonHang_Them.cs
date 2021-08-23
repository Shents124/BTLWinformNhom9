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
        int madondh;
        int index;
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
                      where d.TrangThai == "Chưa nhập" || d.TrangThai == "Nhập thiếu"
                      select d.MaDonDh);
            codelist = dh.ToArray();
            for (int i = 0; i < codelist.Length; i++)
                collection1.Add(codelist[i].ToString());
            this.txtMaDonHang.AutoCompleteCustomSource = collection1;

            //lay thong tin ctdondh
            var ct = from c in obj.Ctdondhs
                     where c.MaDonDh == madondh
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

        private void LoadBooksList()
        {
            for (int i = 0; i < li4.Count; i++)
            {
                Sach s = obj.Saches.SingleOrDefault(s => s.MaSach == li4[i].MaSach);
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = s.MaSach;
                row.Cells[1].Value = s.TenSach;
                Loaisach l = obj.Loaisaches.SingleOrDefault(l => l.MaLoai == s.MaLoai);
                row.Cells[2].Value = l.TenLoai;
                row.Cells[3].Value = s.TacGia;
                row.Cells[4].Value = s.NhaXuatBan;
                row.Cells[5].Value = li4[i].SlDat;
                row.Cells[6].Value = s.DonGiaNhap;
                double tt = int.Parse(li4[i].SlDat.ToString()) * double.Parse(s.DonGiaNhap.ToString());
                row.Cells[7].Value = tt.ToString("N1");
                row.Cells[8].Value = "Xóa";
                dataGridView1.Rows.Add(row);
                TongTien();
            }
        }
        #endregion

        private void FormQuanLyDonHang_Them_Load(object sender, EventArgs e)
        {
            madondh = (int)this.Tag;
            GetData();
            panel2.Hide();
            txtMaDonHang.Text = madondh.ToString();
            txtMaDonHang.ReadOnly = true;
            LoadBooksList();
        }

        private void btnThem_Click(object sender, EventArgs e) //nut Sua
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            int mas = int.Parse(selectedRow.Cells[0].Value.ToString());
            int sldRAW = 0;

            selectedRow.Cells[5].Value = txtSoluong.Text;
            double tt = int.Parse(txtSoluong.Text) * double.Parse(selectedRow.Cells[6].Value.ToString());
            selectedRow.Cells[7].Value = tt.ToString("N1");
            TongTien();
            foreach (Ctdondh c in li4)
                if (c.MaSach == mas)
                    c.SlDat -= 1;
            ClearTextBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                txtTenSach.Text = selectedRow.Cells[1].Value.ToString();
                txtTheloai.Text = selectedRow.Cells[2].Value.ToString();
                txtTacgia.Text = selectedRow.Cells[3].Value.ToString();
                foreach (Ctdondh item in li4)
                    if (item.MaSach == int.Parse(selectedRow.Cells[0].Value.ToString()))
                        txtMaxSL.Text = item.SlDat + "";
                txtSoluong.Text = selectedRow.Cells[5].Value.ToString();
                txtDongia.Text = selectedRow.Cells[6].Value.ToString();
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
            catch (Exception)
            {
                return;
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            //TextBox t = sender as TextBox;

            //for (int i = 0; i < bookslist.Length; i++)
            //    if (t.Text == bookslist[i])
            //    {
            //        foreach (Ctdondh c in li4)
            //        {
            //            Sach s = obj.Saches.SingleOrDefault(sa => sa.TenSach == bookslist[i]);
            //            if (s != null && s.MaSach == c.MaSach)
            //            {
            //                Loaisach ls = obj.Loaisaches.SingleOrDefault(l => l.MaLoai == s.MaLoai);
            //                txtTheloai.Text = ls.TenLoai;
            //                txtTacgia.Text = s.TacGia;
            //                txtMaxSL.Text = Convert.ToString(c.SlDat);
            //                txtDongia.Text = (s.DonGiaNhap).ToString("N1");
            //            }
            //        }
            //    }
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

            int d = 0;
            Dondh dh = obj.Dondhs.SingleOrDefault(s => s.MaDonDh == p.MaDonDh);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Ctpnhap ctpn = new Ctpnhap();
                ctpn.MaPn = p.MaPn;
                ctpn.MaSach = ms[i];
                ctpn.SlNhap = sl[i];
                ctpn.DgNhap = dg[i];
                
                
                Ctdondh ctdh = obj.Ctdondhs.SingleOrDefault(s => s.MaDonDh == p.MaDonDh && s.MaSach == ms[i]);
                if (ctdh.SlDat != sl[i])
                {
                    dh.TrangThai = "Nhập thiếu";
                    ctdh.SlDat -= sl[i];
                    obj.SaveChanges();
                }
                else
                    d++;

                obj.Ctpnhaps.Add(ctpn);
            }
            
            if (d == dataGridView1.Rows.Count - 1)
                dh.TrangThai = "Nhập đủ";

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
                s += i + " - " + bookslist[i] + "\n";
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            var r = from vr in obj.Ctdondhs
                    where vr.MaDonDh == madondh
                    select new
                    {
                        vr.MaSach,
                        vr.SlDat
                    };
            var raw = r.ToList();
        }
    }
}

