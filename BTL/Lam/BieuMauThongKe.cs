using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.Lam
{
    public partial class BieuMauThongKe : Form
    {
        public BieuMauThongKe()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            int today = DateTime.Today.Day;
            int month = DateTime.Today.Month;
            int year = DateTime.Today.Year;           
            tbngaytk.Text = " Ngày "+ today.ToString() + " Tháng " + month.ToString() + " Năm " + year.ToString();
            tbngaytk2.Text = "Hà nội, "+ " Ngày " + today.ToString() + " Tháng " + month.ToString() + " Năm " + year.ToString();
            string[] TongSoTK = new string[] { "Tổng số sách bán ra", "Tổng số sách nhập","Tổng số danh doanh" };
            string[] DonViTinh = new string[] { "Cuốn sách", "Cuốn sách", "Triệu đồng" };
            dataThongKe.Rows.Clear();
            for(int i = 0; i < 3; i++)
            {
                dataThongKe.Rows.Add((i+1),TongSoTK[i],DonViTinh[i],"0","0","0","0");
            }
            List<string> a = (List<string>)this.Tag;
            lblQuy.Text = a[0] +" Năm "+ a[1];
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BieuMauThongKe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbngaytk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
