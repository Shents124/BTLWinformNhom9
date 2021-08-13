using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BTL.Models;
namespace BTL
{
    public partial class LapHoaDon : Form
    {
        QLBanSachContext db = new QLBanSachContext();
        static List<Cthoadon> li = new List<Cthoadon>();
        public LapHoaDon()
        {
            InitializeComponent();
        }
        Sach sach = new Sach();
        
        private void LapHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBookTrongHeThong();   
            
        }
        private bool ThemKhachHang()
        {
            Khachhang kh = new Khachhang();
           
            kh.TenKh = txtTenKhachHang.Text;
            kh.SoDt = txtSodienThoai.Text;
            kh.DiaChi = txtDiaChi.Text;
            Khachhang khtest = db.Khachhangs.FirstOrDefault(khtest => khtest.SoDt == kh.SoDt);
            if(khtest!=null)
            {
                MessageBox.Show("Khách hàng đã từng mua sản phẩm trước đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }    
            else
            {
                db.Khachhangs.Add(kh);
                int g=db.SaveChanges();
                g = db.SaveChanges();
                return true;
            }                  
        }
        private void ThemHoaDon()
        {
            Hoadon hd = new Hoadon();
            hd.NgayLap = dtNgayLapHoaDon.Value;
            hd.MaTk = 1;
            int k = db.Hoadons.ToList().Count;
            Khachhang khtest = db.Khachhangs.FirstOrDefault(khtest => khtest.SoDt == txtSodienThoai.Text);
            if (ThemKhachHang())
            {
                var query = from kh in db.Khachhangs

                            select new
                            {
                                kh.MaKh,
                            };
                var a = query.ToList();
                int i = a.Count;
                hd.MaKh = a[i - 1].MaKh;
                
            }    
            else
            {
                
             
                hd.MaKh = khtest.MaKh;
               
            }  
            db.Hoadons.Add(hd);
            
            k =db.SaveChanges();
            
            
        }
        private void ThemChiTietHoaDon()
        {
     
            var query = from h in db.Hoadons

                        select new
                        {
                            h.MaHd,
                            h.MaKh,
                        };
            var a = query.ToList();
            int dem = a.Count;

            int sum = dvgDachsachthem.Rows.Count;      
            for (int i = 0; i < sum - 1; i++)
            {
          
                Cthoadon cthd = new Cthoadon();
                cthd.MaHd = a[dem - 1].MaHd;
                var dongia = from s in db.Saches
                             where s.MaSach == int.Parse(dvgDachsachthem.Rows[i].Cells[0].Value.ToString())
                             select new
                             {
                                 s.DonGia,
                             };
                var dongia2 = dongia.ToList();
                cthd.MaSach = int.Parse(dvgDachsachthem.Rows[i].Cells[0].Value.ToString());
                cthd.SoLuong = int.Parse(dvgDachsachthem.Rows[i].Cells[2].Value.ToString());
                cthd.ThanhTien = decimal.Parse(dongia2[0].DonGia.ToString()) * cthd.SoLuong;     
                db.Cthoadons.Add(cthd);
                
            }       
            int k=db.SaveChanges();
            k = db.SaveChanges();
        }

        private bool BatLoiCTHoaDon()
        {
            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKhachHang.Focus();
                return false;
            }

            if (txtSodienThoai.Text == "")
            {
                MessageBox.Show("Bạn phải số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSodienThoai.Focus();
                return false;
            }
            else
            {
                try
                {
                    int i = int.Parse(txtSodienThoai.Text);
                }
                catch
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSodienThoai.SelectAll();
                    return false;
                }
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn phải địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }

            var query = from h in db.Hoadons

                        select new
                        {
                            h.MaHd,
                            h.MaKh,
                        };
            var a = query.ToList();
            int dem = a.Count;


            int sum = dvgDachsachthem.Rows.Count;
            if (sum == 1)
            {
                MessageBox.Show("Bạn chưa nhập thông tin sản phẩm cần mua");
                return false;
            }
            List<Cthoadon> li2 = new List<Cthoadon>();
            for (int i = 0; i < sum - 1; i++)
            {

                Cthoadon cthd = new Cthoadon();
                cthd.MaHd = a[dem - 1].MaHd +1;
                var dongia = from s in db.Saches
                             where s.MaSach == int.Parse(dvgDachsachthem.Rows[i].Cells[0].Value.ToString())
                             select new
                             {
                                 s.DonGia,
                             };

                if (dvgDachsachthem.Rows[i].Cells[0].Value == null)
                {
                    MessageBox.Show("Bạn chưa lựa chọn tên sản phẩm mua");
                    return false;
                }
                if (dvgDachsachthem.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm mua");
                    return false;
                }
                else
                {
                    try
                    {
                        int d = int.Parse(dvgDachsachthem.Rows[i].Cells[2].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Bạn nhập số lượng sản phẩm mua không đúng định dạng");

                        return false;
                    }
                }

                var dongia2 = dongia.ToList();
                cthd.MaSach = int.Parse(dvgDachsachthem.Rows[i].Cells[0].Value.ToString());
                cthd.SoLuong = int.Parse(dvgDachsachthem.Rows[i].Cells[2].Value.ToString());
                cthd.ThanhTien = decimal.Parse(dongia2[0].DonGia.ToString()) * cthd.SoLuong;
                if (li2.Contains(cthd))
                {
                    MessageBox.Show("Bạn không thể chọn 1 sản phẩn trên 2 dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                    li2.Add(cthd);

                if (db.Cthoadons.Find(cthd.MaHd,cthd.MaSach)!=null)
                {
                    MessageBox.Show("Bạn không thể chọn 1 sản phẩm trên 2 dòng hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    db.Cthoadons.Add(cthd);
                    li.Add(cthd);
                }    
                //try
                //{

                //}
                //catch
                //{

                //    MessageBox.Show("Bạn không thể chọn 1 sản phẩm trên 2 dòng hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return false;
               // }
            }
            if(li.Count>0)
                foreach (Cthoadon item in li)
                    db.Cthoadons.Remove(item);
            li.Clear();
            return true;
        }       
     
        private void HienThiDanhSachBookTrongHeThong()
        {
           
            var query = from s in db.Saches
                        select new
                        {
                            s.MaSach,
                           s.TenSach
                        };
            TenHang.DataSource = query.ToList();
            TenHang.ValueMember = "MaSach";
            TenHang.DisplayMember = "TenSach";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (BatLoiCTHoaDon())
            {
                ThemHoaDon();
                ThemChiTietHoaDon();
                XoaText();
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
        }

        int index = -1;
        private void dvgDachsachthem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index == (dvgDachsachthem.RowCount - 1))
            {
                MessageBox.Show("Dòng chọn không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dvgDachsachthem.Rows.Remove(dvgDachsachthem.Rows[index]);
        }
        private void XoaText()
        {
            dtNgayLapHoaDon.Value = DateTime.Today;
            txtDiaChi.Text = "";         
            txtSodienThoai.Text = "";
            txtTenKhachHang.Text = "";
            dvgDachsachthem.Rows.Clear();
        }
    }
}
