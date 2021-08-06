
namespace BTL
{
    partial class SuaHoaDon
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
            this.btnSua = new System.Windows.Forms.Button();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSodienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.dtNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.dvgDachsachsua = new System.Windows.Forms.DataGridView();
            this.Tensach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXoaAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDachsachsua)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(136, 412);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(549, 12);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(125, 27);
            this.txtNguoiLap.TabIndex = 25;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(157, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(125, 27);
            this.txtDiaChi.TabIndex = 24;
            // 
            // txtSodienThoai
            // 
            this.txtSodienThoai.Location = new System.Drawing.Point(157, 76);
            this.txtSodienThoai.Name = "txtSodienThoai";
            this.txtSodienThoai.Size = new System.Drawing.Size(125, 27);
            this.txtSodienThoai.TabIndex = 23;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(157, 43);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(125, 27);
            this.txtTenKhachHang.TabIndex = 22;
            // 
            // dtNgayLapHoaDon
            // 
            this.dtNgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLapHoaDon.Location = new System.Drawing.Point(157, 10);
            this.dtNgayLapHoaDon.Name = "dtNgayLapHoaDon";
            this.dtNgayLapHoaDon.Size = new System.Drawing.Size(125, 27);
            this.dtNgayLapHoaDon.TabIndex = 21;
            // 
            // dvgDachsachsua
            // 
            this.dvgDachsachsua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDachsachsua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tensach,
            this.Gia,
            this.Soluong});
            this.dvgDachsachsua.Location = new System.Drawing.Point(15, 179);
            this.dvgDachsachsua.Name = "dvgDachsachsua";
            this.dvgDachsachsua.RowHeadersWidth = 51;
            this.dvgDachsachsua.RowTemplate.Height = 29;
            this.dvgDachsachsua.Size = new System.Drawing.Size(790, 191);
            this.dvgDachsachsua.TabIndex = 20;
            this.dvgDachsachsua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDachsachsua_CellClick);
            // 
            // Tensach
            // 
            this.Tensach.HeaderText = "Tên Sách";
            this.Tensach.MinimumWidth = 6;
            this.Tensach.Name = "Tensach";
            this.Tensach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tensach.Width = 125;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Người Lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-5, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-5, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày lập";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(291, 416);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Location = new System.Drawing.Point(422, 416);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(94, 29);
            this.btnXoaAll.TabIndex = 28;
            this.btnXoaAll.Text = "XóaALL";
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // SuaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 468);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtNguoiLap);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSodienThoai);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.dtNgayLapHoaDon);
            this.Controls.Add(this.dvgDachsachsua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuaHoaDon";
            this.Text = "SuaHoaDon";
            this.Load += new System.EventHandler(this.SuaHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDachsachsua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSodienThoai;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.DateTimePicker dtNgayLapHoaDon;
        private System.Windows.Forms.DataGridView dvgDachsachsua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXoaAll;
    }
}