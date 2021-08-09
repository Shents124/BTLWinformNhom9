using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormQuanLyDonHang : Form
    {
        public FormQuanLyDonHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region HoverButton
        private void btnSearch_MouseMove(object sender, MouseEventArgs e)
        {
            btnSearch.Image = Properties.Resources.icons8_google_web_search_48__1_;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.Image = Properties.Resources.icons8_google_web_search_48;
        }

        private void btnFilter_MouseMove(object sender, MouseEventArgs e)
        {
            btnFilter.Image = Properties.Resources.icons8_filter_48__1_;
            btnFilter.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnFilter_MouseLeave(object sender, EventArgs e)
        {
            btnFilter.Image = Properties.Resources.icons8_filter_48;
            btnFilter.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void btnRefresh_MouseMove(object sender, MouseEventArgs e)
        {
            btnRefresh.Image = Properties.Resources.icons8_refresh_48__1_;
            btnRefresh.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnRefresh_MouseLeave(object sender, EventArgs e)
        {
            btnRefresh.Image = Properties.Resources.icons8_refresh_48;
            btnRefresh.Font = new Font("Arial", 12, FontStyle.Regular);
        }
        #endregion

        private void FormQuanLyDonHang_Load(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            FormQuanLyDonHang_Them frmQLDH_Them = new FormQuanLyDonHang_Them();
            if (Application.OpenForms[frmQLDH_Them.Name] == null)
            {
                frmQLDH_Them.Show();
            }
            else
                Application.OpenForms[frmQLDH_Them.Name].Focus();
        }
    }
}
