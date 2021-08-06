using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL.Models;
namespace BTL
{
    public partial class LapHoaDon : Form
    {
        QLBanSachContext db = new QLBanSachContext();
        
        public LapHoaDon()
        {
            InitializeComponent();
        }
        Sach sach = new Sach();
        
        private void LapHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBookTrongHeThong();   
            
        }
        private void ThemKhachHang()
        {
            Khachhang kh = new Khachhang();
            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenKhachHang.Focus();
                return;
             
            }    
               
            if(txtSodienThoai.Text=="")
            {
                MessageBox.Show("Bạn phải số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSodienThoai.Focus();
                return;
               
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
                    return;
                }
            }  
            if(txtDiaChi.Text=="")
            {
                MessageBox.Show("Bạn phải địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return;
            }    
            kh.TenKh = txtTenKhachHang.Text;
            kh.SoDt = txtSodienThoai.Text;
            kh.DiaChi = txtDiaChi.Text;
            db.Khachhangs.Add(kh);
            db.SaveChanges();
        }
        private void ThemHoaDon()
        {
            var query = from kh in db.Khachhangs
                        
                        select new
                        {
                            kh.MaKh,
                        };
            var a = query.ToList();
            int i = a.Count;
            Hoadon hd = new Hoadon();
            hd.NgayLap = dtNgayLapHoaDon.Value;
            hd.MaTk = 1;
            hd.MaKh = a[i - 1].MaKh;
            db.Hoadons.Add(hd);
            db.SaveChanges();
            
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
            int index = a.Count;

           

            int sum = dvgDachsachthem.Rows.Count;      
            for (int i = 0; i < sum - 1; i++)
            {
                Cthoadon cthd = new Cthoadon();
                cthd.MaHd = a[index - 1].MaHd;
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
            db.SaveChanges();
        }
        private bool BatLoiCTHoaDon()
        {
            var query = from h in db.Hoadons

                        select new
                        {
                            h.MaHd,
                            h.MaKh,
                        };
            var a = query.ToList();
            int index = a.Count;


            int sum = dvgDachsachthem.Rows.Count;
            if (sum == 1)
            {
                MessageBox.Show("Bạn chưa nhập thông tin sản phẩm cần mua");
                return false;
            }
            List<Cthoadon> li = new List<Cthoadon>();
            for (int i = 0; i < sum - 1; i++)
            {

                Cthoadon cthd = new Cthoadon();
                cthd.MaHd = a[index - 1].MaHd + 1;
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

                li.Add(cthd);
                try
                {
                    db.Cthoadons.Add(cthd);

                }
                catch
                {

                    foreach (Cthoadon item in li)
                        db.Cthoadons.Remove(item);
                    MessageBox.Show("Bạn không thể chọn 1 sản phẩn trên 2 dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            MessageBox.Show("cc");
            foreach (Cthoadon item in li)
                db.Cthoadons.Remove(item);
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
                ThemKhachHang();
                ThemHoaDon();
                ThemChiTietHoaDon();
                
            }
            else
            {
                MessageBox.Show("san pham da ton tai 2");
                return;
            }

        }

       
    }
}
