﻿
namespace BTL
{
    partial class LapHoaDon
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
            this.dvgDachsachthem = new System.Windows.Forms.DataGridView();
            this.TenHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNguoilap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSodienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btncolse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDachsachthem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgDachsachthem
            // 
            this.dvgDachsachthem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDachsachthem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDachsachthem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.SoLuong});
            this.dvgDachsachthem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgDachsachthem.Location = new System.Drawing.Point(4, 31);
            this.dvgDachsachthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgDachsachthem.Name = "dvgDachsachthem";
            this.dvgDachsachthem.RowHeadersWidth = 51;
            this.dvgDachsachthem.RowTemplate.Height = 29;
            this.dvgDachsachthem.Size = new System.Drawing.Size(1587, 309);
            this.dvgDachsachthem.TabIndex = 8;
            this.dvgDachsachthem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDachsachthem_CellClick);
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Tên sản phẩm";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(157, 685);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 63);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(267, 685);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 63);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa 1 dòng";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNguoilap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSodienThoai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtNgayLapHoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1595, 339);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(532, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lập hóa đơn";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(287, 91);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(250, 34);
            this.txtTenKhachHang.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txtNguoilap
            // 
            this.txtNguoilap.Location = new System.Drawing.Point(287, 234);
            this.txtNguoilap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNguoilap.Name = "txtNguoilap";
            this.txtNguoilap.ReadOnly = true;
            this.txtNguoilap.Size = new System.Drawing.Size(250, 34);
            this.txtNguoilap.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(287, 186);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 34);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtSodienThoai
            // 
            this.txtSodienThoai.Location = new System.Drawing.Point(287, 139);
            this.txtSodienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSodienThoai.Name = "txtSodienThoai";
            this.txtSodienThoai.Size = new System.Drawing.Size(250, 34);
            this.txtSodienThoai.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Người Lập";
            // 
            // dtNgayLapHoaDon
            // 
            this.dtNgayLapHoaDon.CustomFormat = "";
            this.dtNgayLapHoaDon.Enabled = false;
            this.dtNgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapHoaDon.Location = new System.Drawing.Point(287, 281);
            this.dtNgayLapHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtNgayLapHoaDon.Name = "dtNgayLapHoaDon";
            this.dtNgayLapHoaDon.Size = new System.Drawing.Size(250, 34);
            this.dtNgayLapHoaDon.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvgDachsachthem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 339);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1595, 344);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(414, 685);
            this.btnXoaAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(161, 63);
            this.btnXoaAll.TabIndex = 18;
            this.btnXoaAll.Text = "Xóa ALL dòng";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btncolse
            // 
            this.btncolse.Location = new System.Drawing.Point(583, 685);
            this.btncolse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncolse.Name = "btncolse";
            this.btncolse.Size = new System.Drawing.Size(138, 63);
            this.btncolse.TabIndex = 19;
            this.btncolse.Text = "Đóng";
            this.btncolse.UseVisualStyleBackColor = true;
            this.btncolse.Click += new System.EventHandler(this.btncolse_Click);
            // 
            // LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1595, 906);
            this.Controls.Add(this.btncolse);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapHoaDon";
            this.Load += new System.EventHandler(this.LapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDachsachthem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgDachsachthem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNguoilap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSodienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayLapHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btncolse;
        private System.Windows.Forms.Label label6;
    }
}