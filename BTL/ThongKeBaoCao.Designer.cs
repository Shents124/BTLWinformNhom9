
namespace BTL
{
    partial class ThongKeBaoCao
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
            this.dsThongKe = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBD = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsThongKe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsThongKe
            // 
            this.dsThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.ngaylap,
            this.tenkhachhang,
            this.tongtien});
            this.dsThongKe.Location = new System.Drawing.Point(133, 29);
            this.dsThongKe.Name = "dsThongKe";
            this.dsThongKe.RowHeadersWidth = 51;
            this.dsThongKe.RowTemplate.Height = 29;
            this.dsThongKe.Size = new System.Drawing.Size(724, 191);
            this.dsThongKe.TabIndex = 30;
            // 
            // mahoadon
            // 
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.MinimumWidth = 6;
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.Width = 125;
            // 
            // ngaylap
            // 
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Width = 180;
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.MinimumWidth = 6;
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.Width = 200;
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Từ ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimeKT);
            this.groupBox2.Controls.Add(this.dateTimeBD);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(105, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 177);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "đến ngày";
            // 
            // dateTimeKT
            // 
            this.dateTimeKT.Location = new System.Drawing.Point(438, 42);
            this.dateTimeKT.Name = "dateTimeKT";
            this.dateTimeKT.Size = new System.Drawing.Size(250, 27);
            this.dateTimeKT.TabIndex = 35;
            // 
            // dateTimeBD
            // 
            this.dateTimeBD.Location = new System.Drawing.Point(106, 40);
            this.dateTimeBD.Name = "dateTimeBD";
            this.dateTimeBD.Size = new System.Drawing.Size(250, 27);
            this.dateTimeBD.TabIndex = 34;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(475, 110);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(704, 43);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(94, 29);
            this.btnLoc.TabIndex = 29;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(188, 110);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(94, 29);
            this.btnIn.TabIndex = 28;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // ThongKeBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 521);
            this.Controls.Add(this.dsThongKe);
            this.Controls.Add(this.groupBox2);
            this.Name = "ThongKeBaoCao";
            this.Text = "ThongKeBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.dsThongKe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dsThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeKT;
        private System.Windows.Forms.DateTimePicker dateTimeBD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnIn;
    }
}