using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BTL.Models;
namespace BTL
{
    public partial class BaoTriSach : Form
    {
        QLBanSachContext db = new QLBanSachContext();
        public BaoTriSach()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var query = from c in db.Saches
                        select new {c.MaSach,c.TenSach,c.MaLoaiNavigation.TenLoai,c.DonGia,c.TacGia,c.NhaXuatBan};
            dsSach.Rows.Clear();
            foreach (var item in query)
            {
                dsSach.Rows.Add(item.MaSach, item.TenSach, item.TenLoai, item.DonGia, item.TacGia, item.NhaXuatBan);
            }  
        }

        private void BaoTriSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var query = from s in db.Saches
                        where s.TenSach.Contains(txbTim.Text)
                        select new
                        {
                            map = s.MaLoai,
                            tensp = s.TenSach,
                            tenl = s.MaLoaiNavigation.TenLoai,
                            gia  =s.DonGia,
                            tg = s.TacGia,
                            nxb = s.NhaXuatBan
                        };
            dsSach.Rows.Clear();
            //Hiển thị lên datagrid view
            foreach (var item in query)
            {
                dsSach.Rows.Add(item.map, item.tensp,item.tenl,item.gia,item.gia,item.tg,item.nxb);
            }
        }

        private void Resert_Click(object sender, EventArgs e)
        {
            var query = from c in db.Saches
                        select new { c.MaSach, c.TenSach, c.MaLoaiNavigation.TenLoai, c.DonGia, c.TacGia, c.NhaXuatBan };
            dsSach.Rows.Clear();
            foreach (var item in query)
            {
                dsSach.Rows.Add(item.MaSach, item.TenSach, item.TenLoai, item.DonGia, item.TacGia, item.NhaXuatBan);
            }
            txbTim.Clear();
        }

        private void ChonDong(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index < 0) throw new Exception("Không có dòng được chọn!");
                DataGridViewRow dr = dsSach.Rows[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn đóng form?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SapXep_Click(object sender, EventArgs e)
        {
            var query = from s in db.Saches
                        orderby s.TenSach
                        select new
                        {
                            map = s.MaLoai,
                            tensp = s.TenSach,
                            tenl = s.MaLoaiNavigation.TenLoai,
                            gia = s.DonGia,
                            tg = s.TacGia,
                            nxb = s.NhaXuatBan
                        };
            dsSach.Rows.Clear();
            //Hiển thị lên datagrid view
            foreach (var item in query)
            {
                dsSach.Rows.Add(item.map, item.tensp, item.tenl, item.gia, item.gia, item.tg, item.nxb);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dsSach.CurrentCell.RowIndex;
                if (index < 0) throw new Exception("Bạn chưa chọn dòng để xóa!");
                DataGridViewRow row = dsSach.Rows[index];
                int maSachXoa = Convert.ToInt32(dsSach.Rows[index].Cells[0].Value.ToString());
                try
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa sách này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //lấy ra sản phẩm muốn xóa
                        Sach sachXoa = (from s in db.Saches
                                          where s.MaSach == maSachXoa
                                          select s).FirstOrDefault();
 
                        db.Saches.Remove(sachXoa); 
                        db.SaveChanges();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            ThemSach f = new ThemSach();
            f.Show();
        }

        private void SuaClick(object sender, EventArgs e)
        {
            try
            {
                int index = dsSach.CurrentCell.RowIndex;
                if (index < 0) throw new Exception("Bạn chưa chọn dòng để sửa!");
                DataGridViewRow row = dsSach.Rows[index];
                int masach = Convert.ToInt32(dsSach.Rows[index].Cells[0].Value.ToString());
                var item = (from c in db.Saches
                            where c.MaSach == masach
                            select c).SingleOrDefault();
                Sach a = (Sach)item;
                SuaSach f = new SuaSach();
                f.Tag = a;
                f.Show();

            }

            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }
    }
}
