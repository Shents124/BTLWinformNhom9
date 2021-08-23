using System;
using System.Windows.Forms;

namespace BTL
{
    public partial class DialogCustomForMainForm : Form
    {
        MainForm mainForm;

        public DialogCustomForMainForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No; 
        }
    }
}
