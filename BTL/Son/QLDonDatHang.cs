using BTL.Models;
using BTL.Son;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


namespace BTL
{
    public partial class QLDonDatHang : Form
    {
        QLBanSachContext qLBanSachContext = new QLBanSachContext();
        List<Dondh> dsDondh = new List<Dondh>();
        List<Ctdondh> ctdondhs = new List<Ctdondh>();

        private decimal tongTien = 0;
        private int index;
        private bool isSearchWithDate = false;
        private List<string> trangThai = new List<string>();

        public QLDonDatHang()
        {
            InitializeComponent();
        }

        private void QLDonDatHang_Load(object sender, EventArgs e)
        {
            LoadDonDatHang(GetDonDatHang());
        }

        public List<Dondh> GetDonDatHang()
        {
            var ddh = qLBanSachContext.Dondhs
                .Include("MaNhaCcNavigation");
            return ddh.ToList();
        }

        public void LoadDonDatHang(List<Dondh> dondhs)
        {
            dsDondh = dondhs;

            dgvDSDonDH.Rows.Clear();
            foreach (var item in dsDondh)
            {
                DataGridViewRow row = (DataGridViewRow)dgvDSDonDH.Rows[0].Clone();
                row.Cells[0].Value = item.MaDonDh;
                DateTime time = (DateTime)item.NgayDh;
                row.Cells[1].Value = time.ToShortDateString();
                row.Cells[2].Value = item.MaNhaCcNavigation.TenNhaCc;
                row.Cells[3].Value = item.TrangThai;
                dgvDSDonDH.Rows.Add(row);
            }
        }

        private List<Ctdondh> GetChiTietDonHang(int maDonDh)
        {
            var ddh = qLBanSachContext.Ctdondhs
                .Where(s => s.MaDonDh == maDonDh)
                .Include("MaSachNavigation")
                .ToList();

            return ddh;
        }

        private void HienThiChiTietDDH(int maDonDh)
        {
            ctdondhs = GetChiTietDonHang(maDonDh);

            dgvThongTinSach.Rows.Clear();

            foreach (var item in ctdondhs)
            {
                DataGridViewRow row = (DataGridViewRow)dgvThongTinSach.Rows[0].Clone();
                row.Cells[0].Value = item.MaSach;
                row.Cells[1].Value = item.MaSachNavigation.TenSach;
                row.Cells[2].Value = item.SlDat;
                row.Cells[3].Value = item.MaSachNavigation.DonGiaNhap;
                row.Cells[4].Value = string.Format(new CultureInfo("vi-Vn"), "{0:#,##0.00}", item.ThanhTien);
                tongTien += item.ThanhTien;

                dgvThongTinSach.Rows.Add(row);
            }

            lblTongTien.Text = string.Format(new CultureInfo("vi-Vn"), "{0:#,##0.00}", tongTien);
        }

        private List<Dondh> LocDonDatHang()
        {
            DateTime dayFrom = dtpFrom.Value;
            DateTime dayTo = dtpTo.Value;
            if(isSearchWithDate == true)
            {
                var ddh = qLBanSachContext.Dondhs
                .Where(s => s.NgayDh >= dayFrom && s.NgayDh <= dayTo &&
                (s.TrangThai == trangThai[0] || s.TrangThai == trangThai[1] || s.TrangThai == trangThai[2] || s.TrangThai == trangThai[3]))
                .ToList();
                return ddh;
            }
            return null; 
        }

        private void SetListTrangThai()
        {
            trangThai.Add("Chưa nhập");
            trangThai.Add("Nhập đủ");
            trangThai.Add("Chưa nhập đủ");
            trangThai.Add("Đã hủy");

        }

        private void ThemDonDatHang()
        {
            ThemDonDatHang themDonDatHang = new ThemDonDatHang(this);
            themDonDatHang.ShowDialog();
        }

        private void HuyDonDH()
        {
            int maDDH = int.Parse(dgvDSDonDH.Rows[index].Cells[0].Value.ToString());

            var xoa = qLBanSachContext.Dondhs
                .Where(s => s.MaDonDh == maDDH)
                .SingleOrDefault();

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn hủy đơn đặt hàng", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                xoa.TrangThai = "Đã hủy";
                qLBanSachContext.SaveChanges();
            }

            LoadDonDatHang(GetDonDatHang());
            dgvThongTinSach.Rows.Clear();       }

        private void InDonDatHang()
        {

        }

        private void dgvDSDonDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            try
            {
                if (index < 0 || index > dgvDSDonDH.RowCount - 1)
                    throw new Exception("Dòng bạn chọn không tồn tại");
                int maDonDh = int.Parse(dgvDSDonDH.Rows[index].Cells[0].Value.ToString());
                HienThiChiTietDDH(maDonDh);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemDonDatHang();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            LoadDonDatHang(LocDonDatHang());
        }

        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            LoadDonDatHang(GetDonDatHang());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HuyDonDH();
        }
    }
}
