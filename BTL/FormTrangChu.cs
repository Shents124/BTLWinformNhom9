using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormTrangChu : Form
    {
        Dictionary<DayOfWeek, string> translateDay = new Dictionary<DayOfWeek, string>();

        public FormTrangChu()
        {
            InitializeComponent();
            Dich();
        }

        private void Dich()
        {
            translateDay.Add(DayOfWeek.Monday, "Thứ hai");
            translateDay.Add(DayOfWeek.Tuesday, "Thứ ba");
            translateDay.Add(DayOfWeek.Wednesday, "Thứ tư");
            translateDay.Add(DayOfWeek.Thursday, "Thứ năm");
            translateDay.Add(DayOfWeek.Friday, "Thứ sáu");
            translateDay.Add(DayOfWeek.Saturday, "Thứ bảy");
            translateDay.Add(DayOfWeek.Sunday, "Chủ nhật");
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            DayOfWeek dow = dt.DayOfWeek;
            string tenThu = "";
            foreach (KeyValuePair<DayOfWeek, string> kvp in translateDay)
                if (kvp.Key == dow)
                    tenThu = kvp.Value;
            txtNgay.Text = tenThu + ", ngày " + dt.Day + " tháng " + dt.Month + " năm " + dt.Year;
            txtHello.Text = "Xin chào, " + MainForm.ten;
        }
    }
}
