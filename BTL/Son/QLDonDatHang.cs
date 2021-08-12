﻿using BTL.Models;
using BTL.Son;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace BTL
{
    public partial class QLDonDatHang : Form
    {
        QLBanSachContext qLBanSachContext = new QLBanSachContext();
        List<Dondh> dsDondh = new List<Dondh>();
        List<Ctdondh> ctdondhs = new List<Ctdondh>();

        private int index;

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
                row.Cells[1].Value = item.NgayDh;
                row.Cells[2].Value = item.MaNhaCcNavigation.TenNhaCc;
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
                dgvThongTinSach.Rows.Add(row);
            }
        }

        private List<Dondh> LocDonDatHang()
        {
            DateTime dayFrom = dtpFrom.Value;
            DateTime dayTo = dtpTo.Value;

            var ddh = qLBanSachContext.Dondhs
                .Where(s => s.NgayDh >= dayFrom && s.NgayDh <= dayTo)
                .ToList();
            return ddh;
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

            if(rs == DialogResult.Yes)
            {
                qLBanSachContext.Dondhs.Remove(xoa);
                qLBanSachContext.SaveChanges();
            }

            LoadDonDatHang(GetDonDatHang());
        }

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
    }
}
