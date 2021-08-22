
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
            this.dvgDansachthem = new System.Windows.Forms.DataGridView();
            this.SanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btncolse = new System.Windows.Forms.Button();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDansachthem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(114, 489);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 45);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(194, 489);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 45);
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
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 242);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(387, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lập hóa đơn";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(209, 65);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(125, 27);
            this.txtTenKhachHang.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // txtNguoilap
            // 
            this.txtNguoilap.Location = new System.Drawing.Point(209, 167);
            this.txtNguoilap.Name = "txtNguoilap";
            this.txtNguoilap.ReadOnly = true;
            this.txtNguoilap.Size = new System.Drawing.Size(125, 27);
            this.txtNguoilap.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(209, 133);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(125, 27);
            this.txtDiaChi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtSodienThoai
            // 
            this.txtSodienThoai.Location = new System.Drawing.Point(209, 99);
            this.txtSodienThoai.Name = "txtSodienThoai";
            this.txtSodienThoai.Size = new System.Drawing.Size(125, 27);
            this.txtSodienThoai.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Người Lập";
            // 
            // dtNgayLapHoaDon
            // 
            this.dtNgayLapHoaDon.CustomFormat = "";
            this.dtNgayLapHoaDon.Enabled = false;
            this.dtNgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapHoaDon.Location = new System.Drawing.Point(209, 201);
            this.dtNgayLapHoaDon.Name = "dtNgayLapHoaDon";
            this.dtNgayLapHoaDon.Size = new System.Drawing.Size(125, 27);
            this.dtNgayLapHoaDon.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvgDansachthem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1160, 246);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dvgDansachthem
            // 
            this.dvgDansachthem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDansachthem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDansachthem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SanPham,
            this.dataGridViewTextBoxColumn1,
            this.DonGia,
            this.ThanhTien,
            this.Button});
            this.dvgDansachthem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgDansachthem.Location = new System.Drawing.Point(3, 23);
            this.dvgDansachthem.Name = "dvgDansachthem";
            this.dvgDansachthem.RowHeadersWidth = 51;
            this.dvgDansachthem.RowTemplate.Height = 29;
            this.dvgDansachthem.Size = new System.Drawing.Size(1154, 220);
            this.dvgDansachthem.TabIndex = 0;
            // 
            // SanPham
            // 
            this.SanPham.HeaderText = "Tên Sản Phẩm";
            this.SanPham.MinimumWidth = 6;
            this.SanPham.Name = "SanPham";
            this.SanPham.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // Button
            // 
            this.Button.HeaderText = "";
            this.Button.MinimumWidth = 6;
            this.Button.Name = "Button";
            this.Button.Text = "Xóa";
            this.Button.UseColumnTextForButtonValue = true;
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(301, 489);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(117, 45);
            this.btnXoaAll.TabIndex = 18;
            this.btnXoaAll.Text = "Xóa ALL dòng";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btncolse
            // 
            this.btncolse.Location = new System.Drawing.Point(424, 489);
            this.btncolse.Name = "btncolse";
            this.btncolse.Size = new System.Drawing.Size(100, 45);
            this.btncolse.TabIndex = 19;
            this.btncolse.Text = "Đóng";
            this.btncolse.UseVisualStyleBackColor = true;
            this.btncolse.Click += new System.EventHandler(this.btncolse_Click);
            // 
            // TenHang
            // 
            this.TenHang.FillWeight = 141.9786F;
            this.TenHang.HeaderText = "Tên sản phẩm";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            this.TenHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenHang.Width = 521;
            // 
            // SoLuong
            // 
            this.SoLuong.FillWeight = 141.9786F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 521;
            // 
            // LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 647);
            this.Controls.Add(this.btncolse);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "LapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapHoaDon";
            this.Load += new System.EventHandler(this.LapHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDansachthem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridView dvgDansachthem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn Button;
    }
}