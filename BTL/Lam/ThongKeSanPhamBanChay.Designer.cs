
namespace BTL.Lam
{
    partial class ThongKeSanPhamBanChay
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeBD = new System.Windows.Forms.DateTimePicker();
            this.dateTimeKT = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dsThongKe = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsThongKe)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(302, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 41);
            this.label7.TabIndex = 48;
            this.label7.Text = "Thống kê hàng bán chạy ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimeBD);
            this.panel1.Controls.Add(this.dateTimeKT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(80, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 103);
            this.panel1.TabIndex = 46;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoc.Location = new System.Drawing.Point(613, 30);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(128, 50);
            this.btnLoc.TabIndex = 29;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ ngày";
            // 
            // dateTimeBD
            // 
            this.dateTimeBD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBD.Location = new System.Drawing.Point(120, 35);
            this.dateTimeBD.Name = "dateTimeBD";
            this.dateTimeBD.Size = new System.Drawing.Size(184, 34);
            this.dateTimeBD.TabIndex = 34;
            // 
            // dateTimeKT
            // 
            this.dateTimeKT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimeKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeKT.Location = new System.Drawing.Point(410, 36);
            this.dateTimeKT.Name = "dateTimeKT";
            this.dateTimeKT.Size = new System.Drawing.Size(181, 34);
            this.dateTimeKT.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(309, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "đến ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dsThongKe);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(79, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 307);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn ";
            // 
            // dsThongKe
            // 
            this.dsThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.ngaylap,
            this.tenkhachhang,
            this.tongtien,
            this.dataGridViewTextBoxColumn1});
            this.dsThongKe.Location = new System.Drawing.Point(16, 41);
            this.dsThongKe.Name = "dsThongKe";
            this.dsThongKe.RowHeadersWidth = 51;
            this.dsThongKe.RowTemplate.Height = 29;
            this.dsThongKe.Size = new System.Drawing.Size(724, 191);
            this.dsThongKe.TabIndex = 30;
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIn.Location = new System.Drawing.Point(16, 7);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(144, 43);
            this.btnIn.TabIndex = 28;
            this.btnIn.Text = "Xuất báo cáo";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.Location = new System.Drawing.Point(16, 65);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(144, 48);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Location = new System.Drawing.Point(902, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 125);
            this.panel2.TabIndex = 47;
            // 
            // mahoadon
            // 
            this.mahoadon.HeaderText = "STT";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            // 
            // ngaylap
            // 
            this.ngaylap.HeaderText = "Mã sản phẩm";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.HeaderText = "Tên sản phẩm";
            this.tenkhachhang.MinimumWidth = 6;
            this.tenkhachhang.Name = "tenkhachhang";
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Số lượng bán";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tổng tiền ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ThongKeSanPhamBanChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 505);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "ThongKeSanPhamBanChay";
            this.Text = "ThongKeSanPhamBanChay";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsThongKe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeBD;
        private System.Windows.Forms.DateTimePicker dateTimeKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dsThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
    }
}