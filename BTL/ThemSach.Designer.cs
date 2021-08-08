﻿
namespace BTL
{
    partial class ThemSach
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTacGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNXB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(374, 342);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(143, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên sách";
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(278, 43);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.Size = new System.Drawing.Size(215, 27);
            this.txbTenSach.TabIndex = 29;
            this.txbTenSach.TextChanged += new System.EventHandler(this.txbTenSach_TextChanged);
            this.txbTenSach.Validated += new System.EventHandler(this.tenSach);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên loại sách";
            // 
            // cbbTenLoai
            // 
            this.cbbTenLoai.FormattingEnabled = true;
            this.cbbTenLoai.Location = new System.Drawing.Point(278, 90);
            this.cbbTenLoai.Name = "cbbTenLoai";
            this.cbbTenLoai.Size = new System.Drawing.Size(215, 28);
            this.cbbTenLoai.TabIndex = 33;
            this.cbbTenLoai.SelectedIndexChanged += new System.EventHandler(this.cbbTenLoai_SelectedIndexChanged);
            this.cbbTenLoai.Validated += new System.EventHandler(this.tenLoai);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giá sách";
            // 
            // txbGia
            // 
            this.txbGia.Location = new System.Drawing.Point(278, 143);
            this.txbGia.Name = "txbGia";
            this.txbGia.Size = new System.Drawing.Size(215, 27);
            this.txbGia.TabIndex = 35;
            this.txbGia.TextChanged += new System.EventHandler(this.txbGia_TextChanged);
            this.txbGia.Validated += new System.EventHandler(this.giaSach);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tác giả";
            // 
            // txbTacGia
            // 
            this.txbTacGia.Location = new System.Drawing.Point(278, 196);
            this.txbTacGia.Name = "txbTacGia";
            this.txbTacGia.Size = new System.Drawing.Size(215, 27);
            this.txbTacGia.TabIndex = 37;
            this.txbTacGia.TextChanged += new System.EventHandler(this.txbTacGia_TextChanged);
            this.txbTacGia.Validated += new System.EventHandler(this.giaTacGia);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Nhà xuất bản";
            // 
            // txbNXB
            // 
            this.txbNXB.Location = new System.Drawing.Point(278, 243);
            this.txbNXB.Name = "txbNXB";
            this.txbNXB.Size = new System.Drawing.Size(215, 27);
            this.txbNXB.TabIndex = 39;
            this.txbNXB.Validated += new System.EventHandler(this.nxb);
            // 
            // ThemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.txbNXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbTacGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbTenLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenSach);
            this.Name = "ThemSach";
            this.Text = "ThemSach";
            this.Load += new System.EventHandler(this.ThemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbbTenLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTacGia;
        private System.Windows.Forms.Label label4;
    }
}