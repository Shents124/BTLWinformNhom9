﻿using System;
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
    public partial class BaoTriDanhMucSach : Form
    {
       /* List<Loaisach> dsLoaiSach = new List<Loaisach>();*/
        QLBanSachContext db = new QLBanSachContext();
        public BaoTriDanhMucSach()
        {
            InitializeComponent();

        }
        public void LoadData()
        {
            var query = from s in db.Loaisaches
                        select new
                        {
                            map = s.MaLoai,
                            tensp = s.TenLoai
                        };
            dsDanhMuc.Rows.Clear();
            //Hiển thị lên datagrid view
            foreach (var item in query)
            {
                dsDanhMuc.Rows.Add(item.map, item.tensp);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu từ bảng Sản phẩm
            var query = from s in db.Loaisaches
                        where s.TenLoai.Contains(txbTim.Text)
                        select new
                        {
                            map = s.MaLoai,
                            tensp = s.TenLoai
                        };
            dsDanhMuc.Rows.Clear();
            //Hiển thị lên datagrid view
            foreach (var item in query)
            {
                dsDanhMuc.Rows.Add(item.map, item.tensp);
            }
        }

        private void BaoTriDanhMuc_Load(object sender, EventArgs e)
        {
            LoadData();
           /* dsLoaiSach = db.Loaisaches.Select(x => x).ToList();*/
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDanhMucSach f = new ThemDanhMucSach();
            f.Show();
           
        }

        private void ChonDong(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index < 0) throw new Exception("Không có dòng được chọn!");
                DataGridViewRow dr = dsDanhMuc.Rows[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dsDanhMuc.CurrentCell.RowIndex;
                if (index < 0) throw new Exception("Bạn chưa chọn dòng để xóa!");
                DataGridViewRow row = dsDanhMuc.Rows[index];
                string tenLoaiXoa = dsDanhMuc.Rows[index].Cells[1].Value.ToString();
                try
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa loại sách này", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //lấy ra sản phẩm muốn xóa
                        Loaisach spXoa = (from s in db.Loaisaches
                                          where s.TenLoai == tenLoaiXoa
                                          select s).FirstOrDefault();
                        //Xóa đối tượng khỏi tập hợp 
                        db.Loaisaches.Remove(spXoa);
                        //Cập nhật thay đổi vào csdl    
                        db.SaveChanges();
                        //Hiển thị lại dữ liệu
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dsDanhMuc.CurrentCell.RowIndex;
                if (index < 0) throw new Exception("Bạn chưa chọn dòng để sửa!");
                DataGridViewRow row = dsDanhMuc.Rows[index];
                int maloai = Convert.ToInt32(dsDanhMuc.Rows[index].Cells[0].Value.ToString());
                var item = (from c in db.Loaisaches
                            where c.MaLoai == maloai
                            select c).SingleOrDefault();
                Loaisach a = (Loaisach)item;
                SuaDanhMucSach f = new SuaDanhMucSach();
                f.Tag = a;
                f.Show();

            }

            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var query = from s in db.Loaisaches

                        select new
                        {
                            map = s.MaLoai,
                            tensp = s.TenLoai
                        };
            dsDanhMuc.Rows.Clear();
            foreach (var item in query)
            {
                dsDanhMuc.Rows.Add(item.map, item.tensp);
            }
        }

        private void btnSap_Click(object sender, EventArgs e)
        {
            var query = from s in db.Loaisaches
                        orderby s.TenLoai
                        select new
                        {
                            map = s.MaLoai,
                            tensp = s.TenLoai
                        };
            dsDanhMuc.Rows.Clear();
            //Hiển thị lên datagrid view
            foreach (var item in query)
            {
                dsDanhMuc.Rows.Add(item.map, item.tensp);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn đóng form?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
