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
    public partial class ThongKeQuy : Form
    {
        public ThongKeQuy()
        {
            InitializeComponent();
        }

        private void XuatBaoCao(object sender, EventArgs e)
        {
            try
            {
             BieuMauThongKe f = new BieuMauThongKe();
                         List<string> listItem = new List<string>();
                        string sComboboxQ = cbbQuy.SelectedItem.ToString();
                        
               
                        string sComboboxN = cbbNam.SelectedItem.ToString();
                        if(sComboboxQ == null)
                        {
                            throw new Exception("Bạn phải chọn quý trước khi xuất báo cáo");
                        }
                        if (sComboboxN == null)
                        {
                            throw new Exception("Bạn phải chọn năm trước khi xuất báo cáo");
                        }
                listItem.Add(sComboboxQ);
                        listItem.Add(sComboboxN);
                        f.Tag = listItem;
                        f.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void load_Tk(object sender, EventArgs e)
        {
            for(int i = DateTime.Today.Year; i >= 1973; i--)
            {
                cbbNam.Items.Add(i);
            }
        }
    }
}
