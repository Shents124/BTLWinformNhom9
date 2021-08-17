using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BTL.Models;

namespace BTL
{
    public partial class QuanLyHoaDonForm : Form
    {
        QLBanSachContext db = new QLBanSachContext();
   
        private int maTk;
        public QuanLyHoaDonForm(int maTk)
        {
            this.maTk = maTk;
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
            dvgDanhSachHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dvgDanhSachHoaDon.Columns[1].HeaderText = "Ngày lập";
            dvgDanhSachHoaDon.Columns[2].HeaderText = "Tên khách hàng";
            dvgDanhSachHoaDon.Columns[3].HeaderText = "Tên người lập";
        }
        private void HienThiChiTietHoaDon()
        {
            if(index==-1)
            {
                MessageBox.Show("Bạn chưa chọn dòng hóa đơn cần xem");
                return;
            }
            int ma = int.Parse(dvgDanhSachHoaDon.Rows[index].Cells[0].Value.ToString());
       
            Hoadon hd = db.Hoadons.SingleOrDefault(hd => hd.MaHd == ma);
            txtMahoadon.Text = hd.MaHd.ToString();
            txtNgaylap.Text = hd.NgayLap.ToString();
            Taikhoan tk = db.Taikhoans.SingleOrDefault(tk => tk.MaTk == hd.MaTk);
            txtNguoilap.Text = tk.HoTen;
            
       
            Khachhang kh = db.Khachhangs.SingleOrDefault(kh => kh.MaKh == hd.MaKh);     
            txtMakhachhang.Text = kh.MaKh.ToString();
            txtTenkhachhang.Text = kh.TenKh.ToString();
            txtDiachi.Text = kh.DiaChi.ToString();
            txtSodienthoai.Text = kh.SoDt.ToString();

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
            dvgDanhsachchitietsach.Columns[0].HeaderText = "Tên sách";
            dvgDanhsachchitietsach.Columns[1].HeaderText = "Tác giả";  
            dvgDanhsachchitietsach.Columns[2].HeaderText = "Nhà xuất bản";
            dvgDanhsachchitietsach.Columns[3].HeaderText = "Đơn giá";      
            dvgDanhsachchitietsach.Columns[4].HeaderText = "Số lượng";
            dvgDanhsachchitietsach.Columns[5].HeaderText = "Thành tiền";
            txtTongTien.Text = ThanhTien(hd.MaHd).ToString();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon();
           
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
   
                dvgDanhSachHoaDon.Columns[0].HeaderText = "Mã hóa đơn";

                dvgDanhSachHoaDon.Columns[1].HeaderText = "Ngày lập";
                dvgDanhSachHoaDon.Columns[2].HeaderText = "Tên khách hàng";
                dvgDanhSachHoaDon.Columns[3].HeaderText = "Tên người lập";

          
            } 
            else
            {
                MessageBox.Show("Hóa đơn không có trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }

       
        private void btnLoc_Click_2(object sender, EventArgs e)
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

        private void btnboloc_Click_1(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            Tim();
        }

        private void btnSuahoadon_Click_1(object sender, EventArgs e)
        {
            SuaHoaDon myform = new SuaHoaDon(maTk);
            if (index == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng hóa đơn cần sửa");
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
        private void btnXem_Click(object sender, EventArgs e)
        {
            HienThiChiTietHoaDon();
        }

        private void btnLapHoaDon_Click_1(object sender, EventArgs e)
        {
            LapHoaDon myForm = new LapHoaDon(maTk);
          
            myForm.Show();
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(dvgDanhSachHoaDon.Rows[index].Cells[0].Value.ToString());
            //Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
            //worksheet.Name = "hoadon";
            //worksheet.Columns.AutoFit();
            //int d = 11;
            //var query = from ct in db.Cthoadons
            //            where ct.MaHd == ma
            //            select ct;
            //var cthd = query.ToList();
            //for(int i=0;i<=cthd.Count;i++)
            //{
            //    worksheet.Cells[d + i, 1] = cthd[i].MaSach;
            //    worksheet.Cells[d + i, 2] = cthd[i].MaSachNavigation.TenSach;
            //    worksheet.Cells[d + 1, 3] = cthd[i].SoLuong;
            //    worksheet.Cells[d + 1, 4] = cthd[i].MaSachNavigation.DonGia;
            //    worksheet.Cells[d + 1, 5] = cthd[i].ThanhTien;
            //    d++;
            //}
            //worksheet.Columns.AutoFit();
            // string filename = "C:\Users\ADMIN\Documents\hoadon.xlsx";
            // workbook.SaveAs(filename);
            // workbook.Close();
            // excel.Quit();
            //// excel.Visible = true;
         //   LocalReport report = new LocalReport();
        }
    }
}
