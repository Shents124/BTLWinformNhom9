using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BTL.Models;

namespace BTL
{
    public partial class QuanLyNhaCC : Form
    {
        QLBanSachContext db = new QLBanSachContext();
        public QuanLyNhaCC()
        {
            InitializeComponent();
        }

        private void QuanLyNhaCC_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhaCungCap();
        }
        private void HienThiDanhSachNhaCungCap()
        {
            var query = from n in db.Nhaccs
                        select new
                        {
                            n.MaNhaCc,
                            n.TenNhaCc,
                            n.DiaChi,
                            n.DienThoai,
                        };
            var nhacc = query.ToList();
            dvgDanhSachNhaCungCap.DataSource = nhacc;
         //   dvgDanhSachNhaCungCap.Rows[1].Cells[4].Value = nhacc[0].DiaChi;
        }
        private void HienThiChiTietNhaCungCap()
        {
            if(index==-1)
            {
                MessageBox.Show("Bạn chưa chọn dòng chứa nhà cung cấp", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
            else
            {
                txtManhaCC.Text = dvgDanhSachNhaCungCap.Rows[index].Cells[0].Value.ToString();
                txtTenNhaCC.Text= dvgDanhSachNhaCungCap.Rows[index].Cells[1].Value.ToString();
                txtDiaChi.Text= dvgDanhSachNhaCungCap.Rows[index].Cells[2].Value.ToString();
                txtSoDienThoai.Text= dvgDanhSachNhaCungCap.Rows[index].Cells[3].Value.ToString();
                var query = from ct in db.Dondhs
                            where ct.MaNhaCc == int.Parse(dvgDanhSachNhaCungCap.Rows[index].Cells[0].Value.ToString())
                            select new
                            {
                                ct.MaDonDh,
                                ct.NgayDh,
                              
                            };
                dvgDanhsachchitietdondh.DataSource = query.ToList();
            }    
            
        }
        static int index=-1;
        private void dvgDanhSachNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void tnXemThongtin_Click(object sender, EventArgs e)
        {
            HienThiChiTietNhaCungCap();
        }
    }
}
