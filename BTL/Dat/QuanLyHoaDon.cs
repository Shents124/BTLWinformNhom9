using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BTL.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
            if (index == -1)
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
                             h.MaSachNavigation.DonGiaBan,
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
            foreach (var item in li)
            {
                tt += item.ThanhTien;
            }
            return tt;
        }

        private void Tim()
        {
            if (txtMahdtim.Text == "")
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
            if (hd != null)
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
            if (index == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng hóa đơn cần xuất");
                return;
            }
            else
            {
                int ma = int.Parse(dvgDanhSachHoaDon.Rows[index].Cells[0].Value.ToString());
                Hoadon hd = db.Hoadons.SingleOrDefault(hd => hd.MaHd == ma);
                Khachhang kh = db.Khachhangs.SingleOrDefault(kh => kh.MaKh == hd.MaKh);
                PdfPTable pdfPTable1 = new PdfPTable(2);
                pdfPTable1.DefaultCell.PaddingLeft = 30f;
                pdfPTable1.DefaultCell.PaddingRight = -10f;
                pdfPTable1.DefaultCell.BorderWidth = 0;
                pdfPTable1.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPTable1.WidthPercentage = 40f;
                pdfPTable1.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfPTable1.SpacingBefore = 20f;
                pdfPTable1.SpacingAfter = 20f;
                BaseFont bf;
                try
                {
                    bf = BaseFont.CreateFont(@"D:\Nam_3_ky_2\Window\BTLWinformNhom9\BTL\Resources\Times New Roman 400.ttf", BaseFont.IDENTITY_H, true);
                }
                catch
                {
                    MessageBox.Show("Bạn phải chọn đường dẫn đến thư mục :Time New Roman 400.ttf không chính xác.Có thể file nằm trong mục Resources của project",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Font font1 = new Font(bf, 12f);
                pdfPTable1.AddCell(new Phrase("Tên khách hàng", font1));
                pdfPTable1.AddCell(new Phrase(kh.TenKh, font1));
                pdfPTable1.AddCell(new Phrase("Số điện thoại:", font1));
                pdfPTable1.AddCell(new Phrase(kh.SoDt, font1));
                pdfPTable1.AddCell(new Phrase("Địa chỉ:", font1));
                pdfPTable1.AddCell(new Phrase(kh.DiaChi, font1));
                Taikhoan tk = db.Taikhoans.SingleOrDefault(tk => tk.MaTk == maTk);
                pdfPTable1.AddCell(new Phrase("Người bán:", font1));
                pdfPTable1.AddCell(new Phrase(tk.HoTen, font1));
                pdfPTable1.AddCell(new Phrase("Ngày mua:", font1));
                pdfPTable1.AddCell(new Phrase(hd.NgayLap.ToString(), font1));
                PdfPTable pdfPTable = new PdfPTable(5);
                pdfPTable.DefaultCell.BorderWidth = 0f;
                PdfPCell heaser1 = new PdfPCell(new Phrase("Mã sản phẩm", font1));
                PdfPCell heaser2 = new PdfPCell(new Phrase("Tên sản phẩm", font1));
                PdfPCell heaser3 = new PdfPCell(new Phrase("Đơn giá", font1));
                PdfPCell heaser4 = new PdfPCell(new Phrase("Số lượng", font1));
                PdfPCell heaser5 = new PdfPCell(new Phrase("Thành tiền", font1));
                pdfPTable.AddCell(heaser1);
                pdfPTable.AddCell(heaser2);
                pdfPTable.AddCell(heaser3);
                pdfPTable.AddCell(heaser4);
                pdfPTable.AddCell(heaser5);

                var ct = from cthd in db.Cthoadons
                         where cthd.MaHd == ma
                         select new
                         {
                             cthd.MaSach,
                             cthd.MaSachNavigation.TenSach,
                             cthd.MaSachNavigation.DonGiaBan,
                             cthd.SoLuong,
                             cthd.ThanhTien
                         };
                var li = ct.ToList();
                foreach (var item in li)
                {
                    PdfPCell cell4 = new PdfPCell(new Phrase(item.MaSach.ToString(), font1));
                    PdfPCell cell = new PdfPCell(new Phrase(item.TenSach.ToString(), font1));
                    PdfPCell cell1 = new PdfPCell(new Phrase(item.DonGiaBan.ToString(), font1));
                    PdfPCell cell2 = new PdfPCell(new Phrase(item.SoLuong.ToString(), font1));
                    PdfPCell cell3 = new PdfPCell(new Phrase(item.ThanhTien.ToString(), font1));
                    pdfPTable.AddCell(cell4);
                    pdfPTable.AddCell(cell);
                    pdfPTable.AddCell(cell1);
                    pdfPTable.AddCell(cell2);
                    pdfPTable.AddCell(cell3);

                }
                PdfPTable tt = new PdfPTable(2);
                tt.DefaultCell.BorderWidth = 0;
                tt.SpacingBefore = 10f;
                tt.WidthPercentage = 25f;
                tt.HorizontalAlignment = Element.ALIGN_RIGHT;
                tt.AddCell(new Phrase("Tổng tiền:", font1));
                Decimal sum = 0;
                foreach (var item in ct)
                {
                    sum += item.ThanhTien;
                }
                tt.AddCell(new Phrase(sum.ToString(), font1));
                string url = @"D:\Nam_3_ky_2\Window\BTLWinformNhom9\BTL\Resources\logo.png";
                Image jbp;
                try
                {
                    jbp = Image.GetInstance(url);
                }
                catch
                {
                    MessageBox.Show("Bạn phải chọn đường dẫn đến thư mục :logo.png không chính xác.Có thể file nằm trong mục Resources của project",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                jbp.Alignment = Element.ALIGN_LEFT;
                jbp.SpacingBefore = 80f;
                jbp.ScaleToFit(50f, 50f);
                Font font2 = new Font(bf, 40f);
                Paragraph pr = new Paragraph("HÓA ĐƠN", font2);
                pr.SpacingBefore = -30f;
                pr.Alignment = Element.ALIGN_CENTER;
                try
                {
                    using (FileStream stream = new FileStream("Hoadon.pdf", FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                        PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(jbp);
                        pdfdoc.Add(pr);
                        pdfdoc.Add(pdfPTable1);
                        pdfdoc.Add(pdfPTable);
                        pdfdoc.Add(tt);
                        pdfdoc.Close();
                        writer.Close();
                        stream.Close();
                        MessageBox.Show("In hóa đơn thành công. Mở thư mục Hoadon.pdf trong thư mục bin của project",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("File Hoadon.pdf vẫn chưa được đóng lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }
    }
}
