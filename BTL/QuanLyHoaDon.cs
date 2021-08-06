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
    public partial class QuanLyHoaDon : Form
    {
        QLBanSachContext db = new QLBanSachContext();
        public QuanLyHoaDon()
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
                            h.MaKh,
                            h.MaTk,
                        };

            dvgDanhSachHoaDon.DataSource = query.ToList();
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
            //   int.Parse(dvgDanhSachHoaDon.Rows[1].Cells[3].Value.ToString())
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
            //myForm.MdiParent = this;
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
            var b = a[0].MaHd;
            myform.Tag = b;
            myform.Show();
        }

        private void btnboloc_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHoaDon();
        }
    }
}
