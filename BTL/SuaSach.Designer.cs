
namespace BTL
{
    partial class SuaSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbNXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTenLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMaSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(463, 360);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(232, 360);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.Update_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tên sách";
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(367, 61);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(215, 27);
            this.txbTenSach.TabIndex = 41;
            this.txbTenSach.Validated += new System.EventHandler(this.tenSach);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txbNXB
            // 
            this.txbNXB.Location = new System.Drawing.Point(367, 261);
            this.txbNXB.Name = "txbNXB";
            this.txbNXB.Size = new System.Drawing.Size(215, 27);
            this.txbNXB.TabIndex = 51;
            this.txbNXB.Validated += new System.EventHandler(this.nxb);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Nhà xuất bản";
            // 
            // txbTacGia
            // 
            this.txbTacGia.Location = new System.Drawing.Point(367, 214);
            this.txbTacGia.Name = "txbTacGia";
            this.txbTacGia.Size = new System.Drawing.Size(215, 27);
            this.txbTacGia.TabIndex = 49;
            this.txbTacGia.Validated += new System.EventHandler(this.tacGia);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tác giả";
            // 
            // txbGia
            // 
            this.txbGia.Location = new System.Drawing.Point(367, 161);
            this.txbGia.Name = "txbGia";
            this.txbGia.Size = new System.Drawing.Size(215, 27);
            this.txbGia.TabIndex = 47;
            this.txbGia.Validated += new System.EventHandler(this.gia);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Giá sách";
            // 
            // cbbTenLoai
            // 
            this.cbbTenLoai.FormattingEnabled = true;
            this.cbbTenLoai.Location = new System.Drawing.Point(367, 108);
            this.cbbTenLoai.Name = "cbbTenLoai";
            this.cbbTenLoai.Size = new System.Drawing.Size(215, 28);
            this.cbbTenLoai.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên loại sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Mã sách";
            // 
            // txbMaSach
            // 
            this.txbMaSach.Location = new System.Drawing.Point(367, 22);
            this.txbMaSach.Name = "txbMaSach";
            this.txbMaSach.ReadOnly = true;
            this.txbMaSach.Size = new System.Drawing.Size(215, 27);
            this.txbMaSach.TabIndex = 53;
            // 
            // SuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbMaSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenSach);
            this.Controls.Add(this.txbNXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTacGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbTenLoai);
            this.Controls.Add(this.label2);
            this.Name = "SuaSach";
            this.Text = "SuaSach";
            this.Load += new System.EventHandler(this.LoadForm_Sua);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txbNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTenLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMaSach;
        private System.Windows.Forms.Label label6;
    }
}