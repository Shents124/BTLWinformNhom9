using System;
using System.Collections.Generic;

using System.Data;

using System.Linq;

using System.Windows.Forms;
using BTL.Models;

namespace BTL
{
    public partial class SuaHoaDon : Form
    {
        QLBanSachContext db = new QLBanSachContext();
        static List<Cthoadon> li = new List<Cthoadon>();
        public SuaHoaDon()
        {
            InitializeComponent();
        }

        private void SuaHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBookTrongHeThong();
            LayChiTietHoaDon();
            LayThongTinKhachHangVaHoaDon();

        }
        private void LayChiTietHoaDon()
        {
            var a = (Hoadon) this.Tag;

            var query3 = from h in db.Cthoadons
                         where h.MaHd == a.MaHd
                         select new
                         {
                             h.MaSachNavigation.TenSach,
                             h.MaSach,
                             h.MaSachNavigation.TacGia,
                             h.MaSachNavigation.NhaXuatBan,
                             h.MaSachNavigation.DonGia,
                             h.SoLuong,
                             h.ThanhTien,
                         };
            var b = query3.ToList();
            int sum = b.Count;
            for (int i = 0; i < sum; i++)
                dvgDachsachsua.Rows.Add();
            int d = 0;
            foreach (var item in b)
            {
                dvgDachsachsua.Rows[d].Cells[0].Value = item.MaSach;
                dvgDachsachsua.Rows[d].Cells[2].Value = item.SoLuong;

                d++;

            }
        }
        private void LayThongTinKhachHangVaHoaDon()
        {
            var a = (Hoadon)this.Tag;

            var query = from h in db.Hoadons
                        where h.MaHd == a.MaHd
                        select new
                        {
                            h.MaHd,
                            h.MaKh,
                            h.MaKhNavigation.TenKh,
                            h.NgayLap,
                            h.MaTkNavigation.TenDangNhap,
                        };
            var hd = query.ToList();
            dtNgayLapHoaDon.Value = hd[0].NgayLap.Value;
            txtNguoiLap.Text = hd[0].TenDangNhap;
            var query2 = from k in db.Khachhangs
                         where k.MaKh == hd[0].MaKh
                         select new
                         {
                             k.MaKh,
                             k.TenKh,
                             k.SoDt,
                             k.DiaChi
                         };
            var kh = query2.ToList();
            txtSodienThoai.Text = kh[0].SoDt;
            txtDiaChi.Text = kh[0].DiaChi;
            txtTenKhachHang.Text = kh[0].TenKh;
        }
        private void HienThiDanhSachBookTrongHeThong()
        {

            var query = from s in db.Saches
                        select new
                        {
                            s.MaSach,
                            s.TenSach
                        };
            Tensach.DataSource = query.ToList();
            Tensach.ValueMember = "MaSach";
            Tensach.DisplayMember = "TenSach";
        }
        private void Sua()
        {
            if (BatLoiHoaDon())
            {
                XoaChiTietHoaDonCu();
                ThemChiTietHoaDon();
                
            }
            else
            {
                if (li.Count > 0)
                {
                    foreach (var item in li)
                        db.Cthoadons.Remove(item);
                    li.Clear();
                }
               
            }


            //MessageBox.Show("Sửa hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //XoaText();
            //  this.Close();

        }
        private void XoaChiTietHoaDonCu()
        {
            var a = (Hoadon)this.Tag;
            var query = from ct in db.Cthoadons
                        where ct.MaHd == a.MaHd
                        select ct;
            var b = query.ToList();
          
            foreach (var item in b)
            {
                db.Cthoadons.Remove(item);         
            }
            int k=db.SaveChanges();
            k = 0;
       
        }
        private void ThemChiTietHoaDon()
        {

            var a = (Hoadon)this.Tag;

            int sum = dvgDachsachsua.Rows.Count;
        
            for (int i = 0; i < sum - 1; i++)
            {

                Cthoadon cthd = new Cthoadon();

                cthd.MaHd = a.MaHd;
                var dongia = from s in db.Saches
                             where s.MaSach == int.Parse(dvgDachsachsua.Rows[i].Cells[0].Value.ToString())
                             select new
                             {
                                 s.DonGia,
                             };

                //if (dvgDachsachsua.Rows[i].Cells[0].Value == null)
                //{
                //    MessageBox.Show("Bạn chưa lựa chọn tên sản phẩm mua");

                //    return;
                //}
                //if (dvgDachsachsua.Rows[i].Cells[2].Value == null)
                //{
                //    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm mua");

                //    return;
                //}
                //else
                //{
                //    try
                //    {
                //        int d = int.Parse(dvgDachsachsua.Rows[i].Cells[2].Value.ToString());
                //    }
                //    catch
                //    {
                //        MessageBox.Show("Bạn nhập số lượng sản phẩm mua không đúng định dạng");

                //        return;
                //    }
                //}
                var dongia2 = dongia.ToList();
                cthd.MaSach = int.Parse(dvgDachsachsua.Rows[i].Cells[0].Value.ToString());
                cthd.SoLuong = int.Parse(dvgDachsachsua.Rows[i].Cells[2].Value.ToString());
                cthd.ThanhTien = decimal.Parse(dongia2[0].DonGia.ToString()) * cthd.SoLuong;
                db.Cthoadons.Add(cthd);
                int k=db.SaveChanges();
                k = 0;
                //try
                //{
                //    db.SaveChanges();
                //}

                //catch
                //{
                //    MessageBox.Show("Bạn không thể chọn cùng 1 loại sách trên 2 dòng khác nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    db.Cthoadons.Remove(cthd);
                //    return;
                //}

            }
          
        }
        private bool BatLoiHoaDon()
        {
            var queery = from hd in db.Hoadons
                         select hd;
            int dem = queery.ToList().Count;
        
            var b = queery.ToList();

             
            int sum = dvgDachsachsua.Rows.Count;
           
            for (int i = 0; i < sum - 1; i++)
            {
                Cthoadon cthd = new Cthoadon();

                //cthd.MaHd = int.Parse(a.ToString());
                cthd.MaHd = b[dem - 1].MaHd+1;
                var dongia = from s in db.Saches
                             where s.MaSach == int.Parse(dvgDachsachsua.Rows[i].Cells[0].Value.ToString())
                             select new
                             {
                                 s.DonGia,
                             };

                if (dvgDachsachsua.Rows[i].Cells[0].Value == null)
                {
                    MessageBox.Show("Bạn chưa lựa chọn tên sản phẩm mua");
                    return false;
                }
                if (dvgDachsachsua.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm mua");
                    return false;
                }

                else
                {
                    try
                    {
                        int d = int.Parse(dvgDachsachsua.Rows[i].Cells[2].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Bạn nhập số lượng sản phẩm mua không đúng định dạng");

                        return false;
                    }
                }

                var dongia2 = dongia.ToList();
                cthd.MaSach = int.Parse(dvgDachsachsua.Rows[i].Cells[0].Value.ToString());
                cthd.SoLuong = int.Parse(dvgDachsachsua.Rows[i].Cells[2].Value.ToString());
                cthd.ThanhTien = decimal.Parse(dongia2[0].DonGia.ToString()) * cthd.SoLuong;
                if (db.Cthoadons.Find(cthd.MaHd, cthd.MaSach) != null)
                {
                    MessageBox.Show("Bạn không thể chọn 1 sản phẩn trên 2 dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    li.Add(cthd);
                    db.Cthoadons.Add(cthd);
                }        
            }
            if(li.Count>0)
            foreach (Cthoadon item in li)
                db.Cthoadons.Remove(item);
            li.Clear();
            return true;
        }
        private void XoaText()
        {
            dtNgayLapHoaDon.Value = DateTime.Today;
            txtDiaChi.Text = "";
            txtNguoiLap.Text = "";
            txtSodienThoai.Text = "";
            txtTenKhachHang.Text = "";
            dvgDachsachsua.Rows.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(index==(dvgDachsachsua.RowCount-1))
            {
                MessageBox.Show("Dòng chọn không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            dvgDachsachsua.Rows.Remove(dvgDachsachsua.Rows[index]);
        }
        static int index = -1;
        private void dvgDachsachsua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            XoaChiTietHoaDonCu();
        }
    }
}
