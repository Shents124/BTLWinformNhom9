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
    public partial class QuanLyHoaDonForm : Form
    {
        QLBanSachContext db = new QLBanSachContext();
        private Form activeForm = null;
        public QuanLyHoaDonForm()
        {
            InitializeComponent();
        }
        int index = -1;
        private void dvgDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
        private void HienThiDanhSachHoaDon()
        {
            var query = from h in db.Hoadons
                        select new
                        {
                            h.MaHd,
                            h.NgayLap,
                            h.MaKhNavigation.TenKh,
                            h.MaTkNavigation.HoTen,
                        };

            dvgDanhSachHoaDon.DataSource = query.ToList();
            dvgDanhSachHoaDon.Columns[0].Width = 200;
            dvgDanhSachHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dvgDanhSachHoaDon.Columns[1].Width = 200;
            dvgDanhSachHoaDon.Columns[1].HeaderText = "Ngày lập";
            dvgDanhSachHoaDon.Columns[2].Width = 200;
            dvgDanhSachHoaDon.Columns[3].HeaderText = "Tên khách hàng";
            dvgDanhSachHoaDon.Columns[3].Width = 200;
        }
        private void HienThiChiTietHoaDon()
        {
            if(index==-1)
            {
                MessageBox.Show("Bạn chưa chọn dòng hóa đơn cần xem");
                return;
            }
            var query = from h in db.Hoadons
                        where h.MaHd == int.Parse(dvgDanhSachHoaDon.Rows[index].Cells[0].Value.ToString())
                        select new
                        {
                            h.MaHd,
                            h.NgayLap,
                            h.MaKh,
                            h.MaTk,
                            h.MaKhNavigation.TenKh,
                        };
            var a = query.ToList();
            txtMahoadon.Text = a[0].MaHd.ToString();
            txtNgaylap.Text = a[0].NgayLap.ToString();
            txtNguoilap.Text = a[0].TenKh.ToString();
           
            var query2 = from kh in db.Khachhangs
                         where kh.MaKh == a[0].MaKh
                         select new
                         {
                             kh.MaKh,
                             kh.TenKh,
                             kh.DiaChi,
                             kh.SoDt,
                         };

            var b = query2.ToList();
            txtMakhachhang.Text = b[0].MaKh.ToString();
            txtTenkhachhang.Text = b[0].TenKh.ToString();
            txtDiachi.Text = b[0].DiaChi.ToString();
            txtSodienthoai.Text = b[0].SoDt.ToString();

            var query3 = from h in db.Cthoadons
                         where h.MaHd == int.Parse(dvgDanhSachHoaDon.Rows[index].Cells[0].Value.ToString())
                         select new
                         {
                             h.MaSachNavigation.TenSach,
                             h.MaSachNavigation.TacGia,
                             h.MaSachNavigation.NhaXuatBan,
                             h.MaSachNavigation.DonGia,
                             h.SoLuong,
                             h.ThanhTien,
                         };
            dvgDanhsachchitietsach.DataSource = query3.ToList();
            dvgDanhsachchitietsach.Columns[0].Width = 200;
            dvgDanhsachchitietsach.Columns[0].HeaderText = "Tên sách";
            dvgDanhsachchitietsach.Columns[1].Width = 150;
            dvgDanhsachchitietsach.Columns[1].HeaderText = "Tác giả";
            dvgDanhsachchitietsach.Columns[2].Width = 200;
            dvgDanhsachchitietsach.Columns[2].HeaderText = "Nhà xuất bản";
            dvgDanhsachchitietsach.Columns[3].Width = 150;
            dvgDanhsachchitietsach.Columns[3].HeaderText = "Đơn giá";
            dvgDanhsachchitietsach.Columns[4].Width = 100;
            dvgDanhsachchitietsach.Columns[4].HeaderText = "Số lượng";
            dvgDanhsachchitietsach.Columns[5].Width = 200;
            dvgDanhsachchitietsach.Columns[5].HeaderText = "Thành tiền";
            txtTongTien.Text = ThanhTien(a[0].MaHd).ToString();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon();
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            HienThiChiTietHoaDon();
        }
        
        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            LapHoaDon myForm = new LapHoaDon();
           // myForm.MdiParent = this;
            if (activeForm != null)
                activeForm.Close();
            activeForm = myForm;
            //myForm.TopLevel = false;
            //QuanLyHoaDonForm.ActiveForm.Activate();
            //QuanLyHoaDonForm.ActiveForm.Controls.Add(myForm);
            //QuanLyHoaDonForm.ActiveForm.Tag = myForm;
            myForm.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var query = from h in db.Hoadons
                        where dtNgaybatdau.Value <= h.NgayLap && h.NgayLap <= dtNgayketthuc.Value
                        select new
                        {
                            h.MaHd,
                            h.NgayLap,
                            h.MaKh,
                            h.MaTk,
                        };
            dvgDanhSachHoaDon.DataSource = query.ToList();
        }

        private void btnSuahoadon_Click(object sender, EventArgs e)
        {
            SuaHoaDon myform = new SuaHoaDon();
            if(index == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng hóa đơn cần xem");
                return;
            }
            else
            {
                int ma = int.Parse(dvgDanhSachHoaDon.Rows[index].Cells[0].Value.ToString());
                Hoadon hd = db.Hoadons.SingleOrDefault(hd => hd.MaHd == ma);             
                myform.Tag = hd;
                myform.Show();
            }    
            
        }
        private decimal ThanhTien(int ma)
        {
            var query = from ct in db.Cthoadons
                        where ct.MaHd == ma
                        select new
                        {
                            ct.ThanhTien
                        };
            var li = query.ToList();
            decimal tt = 0;
            foreach(var item in li)
            {
                tt += item.ThanhTien;
            }
            return tt;
        }
        private void btnboloc_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Tim();
        }
        private void Tim()
        {
            if(txtMahdtim.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMahdtim.Focus();
                return;
            } 
            else
            {
                try
                {
                    int ma = int.Parse(txtMahdtim.Text);
                }
                catch
                {
                    MessageBox.Show("Bạn nhập mã hóa đơn không đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMahdtim.SelectAll();
                    return;
                }
            }    
            Hoadon hd = db.Hoadons.SingleOrDefault(hd => hd.MaHd == int.Parse(txtMahdtim.Text));
            if(hd!=null)
            {
                var query = from h in db.Hoadons
                            where h.MaHd == int.Parse(txtMahdtim.Text)
                            select new
                            {
                                h.MaHd,
                                h.NgayLap,
                                h.MaKhNavigation.TenKh,
                                h.MaTkNavigation.HoTen,
                            };

                dvgDanhSachHoaDon.DataSource = query.ToList();
                dvgDanhSachHoaDon.Columns[0].Width = 200;
                dvgDanhSachHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
                dvgDanhSachHoaDon.Columns[1].Width = 200;
                dvgDanhSachHoaDon.Columns[1].HeaderText = "Ngày lập";
                dvgDanhSachHoaDon.Columns[2].Width = 200;
                dvgDanhSachHoaDon.Columns[3].HeaderText = "Tên khách hàng";
                dvgDanhSachHoaDon.Columns[3].Width = 200;
          
            } 
            else
            {
                MessageBox.Show("Hóa đơn không có trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }
    }
}
