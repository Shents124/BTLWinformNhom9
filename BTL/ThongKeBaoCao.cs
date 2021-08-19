using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BTL.Models;
/*using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;*/
using Syncfusion.XlsIO;
namespace BTL
{
    public partial class ThongKeBaoCao : Form
    {
        QLBanSachContext db = new QLBanSachContext();
        public ThongKeBaoCao()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            var query = from a in db.Hoadons
                        join b in db.Cthoadons on a.MaHd equals b.MaHd
                        join c in db.Khachhangs on a.MaKh equals c.MaKh
                        select new { mahd = b.MaHd, ngaylap = a.NgayLap, tenkh = c.TenKh, thanhtien = b.ThanhTien };
            dsThongKe.Rows.Clear();
            //Hiển thị lên datagrid view
            foreach (var item in query)
            {
                dsThongKe.Rows.Add(item.mahd, Convert.ToDateTime(item.ngaylap), item.tenkh, item.thanhtien);
            }
            var query2 = from a in db.Hoadons
                         join b in db.Cthoadons on a.MaHd equals b.MaHd
                         join c in db.Khachhangs on a.MaKh equals c.MaKh
                         select new { thanhtien = b.ThanhTien };

            decimal tongDoanhThu = 0;
            foreach (var item in query2)
            {
                tongDoanhThu += item.thanhtien;
            }

            txbDoanhThu.Text = tongDoanhThu.ToString();

        }

        private void LoadForm_thongke(object sender, EventArgs e)
        {
            loadData();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn đóng form?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LocClick(object sender, EventArgs e)
        {
            try
            {
                var bd = dateTimeBD.Value;
                var kt = dateTimeKT.Value;
                if (kt < bd)
                {
                    throw new Exception("Bạn phải chọn ngày kết thúc lớn hơn hoặc bằng ngày bắt đầu");
                }
                var query = from a in db.Hoadons
                            join b in db.Cthoadons on a.MaHd equals b.MaHd
                            join c in db.Khachhangs on a.MaKh equals c.MaKh
                            where a.NgayLap >= bd && a.NgayLap <= kt
                            select new { mahd = b.MaHd, ngaylap = a.NgayLap, tenkh = c.TenKh, thanhtien = b.ThanhTien };
                dsThongKe.Rows.Clear();
                decimal tongDoanhThu = 0;
                //Hiển thị lên datagrid view
                foreach (var item in query)
                {
                    dsThongKe.Rows.Add(item.mahd, Convert.ToDateTime(item.ngaylap), item.tenkh, item.thanhtien);
                    tongDoanhThu += item.thanhtien;
                }
                txbDoanhThu.Text = tongDoanhThu.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void exportExcel(DataGridView g, string duongDan, string tenTep)
        {
            /* app obj = new app();
             obj.Application.Workbooks.Add(Type.Missing);
             obj.Columns.ColumnWidth = 25;
             for(int i=1;i<g.Columns.Count +1;i++)
             {
                 obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
             }
             for(int i = 0; i < g.Rows.Count; i++)
             {
                 for(int j=0;j<g.Columns.Count;j++)
                 {
                     if(g.Rows[i].Cells[j].Value != null)
                     {
                         obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                     }
                 }    
             }
             obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTep + ".xlsx");
             obj.ActiveWorkbook.Saved = true;*/

        }
        private void XuatThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                /*  exportExcel(dsThongKe, @"D:\", "XuatFileWWinForm");*/
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;
                    IWorkbook workbook = application.Workbooks.Create(1);
                    IWorksheet worksheet = workbook.Worksheets[0];
                    //Adding text to a cell
                    for (int i = 1; i < dsThongKe.Columns.Count + 1; i++)
                    {
                        worksheet.Range[1, i].Text = dsThongKe.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dsThongKe.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dsThongKe.Columns.Count; j++)
                        {
                            worksheet.Range[i + 2, j + 1].Text = dsThongKe.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //Saving the workbook to disk in XLSX format
                    Stream excelstream = File.Create(Path.GetFullPath(@"D:\FileWinForm.xlsx"));
                    workbook.SaveAs(excelstream);
                    excelstream.Dispose();
                    MessageBox.Show("In thành công");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
