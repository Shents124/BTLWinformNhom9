
namespace BTL
{
    partial class FormQuanLyThongTinKH
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
            this.grDanhSachKH = new System.Windows.Forms.GroupBox();
            this.dvgDanhsachKH = new System.Windows.Forms.DataGridView();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChikh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMakh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmenucon = new System.Windows.Forms.Label();
            this.tnXemThongtin = new System.Windows.Forms.Button();
            this.dvgDanhsachchitietdonkh = new System.Windows.Forms.DataGridView();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.grChiTietKH = new System.Windows.Forms.GroupBox();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSolanmuamax = new System.Windows.Forms.TextBox();
            this.txtSolanmuamin = new System.Windows.Forms.TextBox();
            this.txtMakhTim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnboloc = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.grDanhSachKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDanhsachKH)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDanhsachchitietdonkh)).BeginInit();
            this.grChiTietKH.SuspendLayout();
            this.grChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDanhSachKH
            // 
            this.grDanhSachKH.Controls.Add(this.dvgDanhsachKH);
            this.grDanhSachKH.Location = new System.Drawing.Point(12, 48);
            this.grDanhSachKH.Name = "grDanhSachKH";
            this.grDanhSachKH.Size = new System.Drawing.Size(1020, 152);
            this.grDanhSachKH.TabIndex = 17;
            this.grDanhSachKH.TabStop = false;
            this.grDanhSachKH.Text = "Danh Sách Khách Hàng";
            // 
            // dvgDanhsachKH
            // 
            this.dvgDanhsachKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDanhsachKH.Location = new System.Drawing.Point(9, 23);
            this.dvgDanhsachKH.Name = "dvgDanhsachKH";
            this.dvgDanhsachKH.RowHeadersWidth = 51;
            this.dvgDanhsachKH.RowTemplate.Height = 29;
            this.dvgDanhsachKH.Size = new System.Drawing.Size(744, 123);
            this.dvgDanhsachKH.TabIndex = 0;
            this.dvgDanhsachKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDanhsachKH_CellClick);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(144, 140);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ReadOnly = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(222, 27);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Điện thoại";
            // 
            // txtDiaChikh
            // 
            this.txtDiaChikh.Location = new System.Drawing.Point(144, 107);
            this.txtDiaChikh.Name = "txtDiaChikh";
            this.txtDiaChikh.ReadOnly = true;
            this.txtDiaChikh.Size = new System.Drawing.Size(222, 27);
            this.txtDiaChikh.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // txtTenkh
            // 
            this.txtTenkh.Location = new System.Drawing.Point(144, 74);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.ReadOnly = true;
            this.txtTenkh.Size = new System.Drawing.Size(222, 27);
            this.txtTenkh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng";
            // 
            // txtMakh
            // 
            this.txtMakh.Location = new System.Drawing.Point(144, 41);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.ReadOnly = true;
            this.txtMakh.Size = new System.Drawing.Size(222, 27);
            this.txtMakh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý thông tin khách hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnmenucon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 36);
            this.panel1.TabIndex = 16;
            // 
            // btnmenucon
            // 
            this.btnmenucon.AutoSize = true;
            this.btnmenucon.Location = new System.Drawing.Point(12, 9);
            this.btnmenucon.Name = "btnmenucon";
            this.btnmenucon.Size = new System.Drawing.Size(70, 20);
            this.btnmenucon.TabIndex = 0;
            this.btnmenucon.Text = "Menucon";
            // 
            // tnXemThongtin
            // 
            this.tnXemThongtin.Location = new System.Drawing.Point(548, 37);
            this.tnXemThongtin.Name = "tnXemThongtin";
            this.tnXemThongtin.Size = new System.Drawing.Size(125, 79);
            this.tnXemThongtin.TabIndex = 0;
            this.tnXemThongtin.Text = "Xem Thông Tin";
            this.tnXemThongtin.UseVisualStyleBackColor = true;
            this.tnXemThongtin.Click += new System.EventHandler(this.tnXemThongtin_Click);
            // 
            // dvgDanhsachchitietdonkh
            // 
            this.dvgDanhsachchitietdonkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDanhsachchitietdonkh.Location = new System.Drawing.Point(400, 41);
            this.dvgDanhsachchitietdonkh.Name = "dvgDanhsachchitietdonkh";
            this.dvgDanhsachchitietdonkh.RowHeadersWidth = 51;
            this.dvgDanhsachchitietdonkh.RowTemplate.Height = 29;
            this.dvgDanhsachchitietdonkh.Size = new System.Drawing.Size(350, 161);
            this.dvgDanhsachchitietdonkh.TabIndex = 1;
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(746, 37);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(119, 79);
            this.btnSuaThongTin.TabIndex = 7;
            this.btnSuaThongTin.Text = "Sửa Thông Tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // grChiTietKH
            // 
            this.grChiTietKH.Controls.Add(this.txtSoDienThoai);
            this.grChiTietKH.Controls.Add(this.label5);
            this.grChiTietKH.Controls.Add(this.txtDiaChikh);
            this.grChiTietKH.Controls.Add(this.label4);
            this.grChiTietKH.Controls.Add(this.txtTenkh);
            this.grChiTietKH.Controls.Add(this.label3);
            this.grChiTietKH.Controls.Add(this.txtMakh);
            this.grChiTietKH.Controls.Add(this.label2);
            this.grChiTietKH.Controls.Add(this.dvgDanhsachchitietdonkh);
            this.grChiTietKH.Location = new System.Drawing.Point(15, 206);
            this.grChiTietKH.Name = "grChiTietKH";
            this.grChiTietKH.Size = new System.Drawing.Size(1017, 266);
            this.grChiTietKH.TabIndex = 18;
            this.grChiTietKH.TabStop = false;
            this.grChiTietKH.Text = "Chi Tiết Khách Hàng";
            // 
            // grChucNang
            // 
            this.grChucNang.Controls.Add(this.btnTim);
            this.grChucNang.Controls.Add(this.txtSolanmuamax);
            this.grChucNang.Controls.Add(this.txtSolanmuamin);
            this.grChucNang.Controls.Add(this.txtMakhTim);
            this.grChucNang.Controls.Add(this.label8);
            this.grChucNang.Controls.Add(this.label7);
            this.grChucNang.Controls.Add(this.label6);
            this.grChucNang.Controls.Add(this.btnboloc);
            this.grChucNang.Controls.Add(this.btnLoc);
            this.grChucNang.Controls.Add(this.btnSuaThongTin);
            this.grChucNang.Controls.Add(this.tnXemThongtin);
            this.grChucNang.Location = new System.Drawing.Point(12, 478);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(1020, 153);
            this.grChucNang.TabIndex = 19;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức Năng";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(289, 29);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 29);
            this.btnTim.TabIndex = 21;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSolanmuamax
            // 
            this.txtSolanmuamax.Location = new System.Drawing.Point(138, 117);
            this.txtSolanmuamax.Name = "txtSolanmuamax";
            this.txtSolanmuamax.Size = new System.Drawing.Size(125, 27);
            this.txtSolanmuamax.TabIndex = 20;
            // 
            // txtSolanmuamin
            // 
            this.txtSolanmuamin.Location = new System.Drawing.Point(138, 73);
            this.txtSolanmuamin.Name = "txtSolanmuamin";
            this.txtSolanmuamin.Size = new System.Drawing.Size(125, 27);
            this.txtSolanmuamin.TabIndex = 19;
            // 
            // txtMakhTim
            // 
            this.txtMakhTim.Location = new System.Drawing.Point(138, 30);
            this.txtMakhTim.Name = "txtMakhTim";
            this.txtMakhTim.Size = new System.Drawing.Size(125, 27);
            this.txtMakhTim.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Số lần mua max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lần mua min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số điện thoại";
            // 
            // btnboloc
            // 
            this.btnboloc.Image = global::BTL.Properties.Resources.icons8_refresh_48__1_;
            this.btnboloc.Location = new System.Drawing.Point(403, 84);
            this.btnboloc.Name = "btnboloc";
            this.btnboloc.Size = new System.Drawing.Size(94, 53);
            this.btnboloc.TabIndex = 14;
            this.btnboloc.UseVisualStyleBackColor = true;
            this.btnboloc.Click += new System.EventHandler(this.btnboloc_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Image = global::BTL.Properties.Resources.icons8_filter_48__1_;
            this.btnLoc.Location = new System.Drawing.Point(289, 84);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(94, 51);
            this.btnLoc.TabIndex = 13;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // FormQuanLyThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 636);
            this.Controls.Add(this.grDanhSachKH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grChiTietKH);
            this.Controls.Add(this.grChucNang);
            this.Name = "FormQuanLyThongTinKH";
            this.Text = "FormQuanLyThongTinKH";
            this.Load += new System.EventHandler(this.FormQuanLyThongTinKH_Load);
            this.grDanhSachKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDanhsachKH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDanhsachchitietdonkh)).EndInit();
            this.grChiTietKH.ResumeLayout(false);
            this.grChiTietKH.PerformLayout();
            this.grChucNang.ResumeLayout(false);
            this.grChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSachKH;
        private System.Windows.Forms.DataGridView dvgDanhsachKH;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChikh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMakh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnmenucon;
        private System.Windows.Forms.Button tnXemThongtin;
        private System.Windows.Forms.DataGridView dvgDanhsachchitietdonkh;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.GroupBox grChiTietKH;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnboloc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSolanmuamax;
        private System.Windows.Forms.TextBox txtSolanmuamin;
        private System.Windows.Forms.TextBox txtMakhTim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}