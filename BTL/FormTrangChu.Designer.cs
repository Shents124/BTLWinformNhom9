
namespace BTL
{
    partial class FormTrangChu
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
            this.txtHello = new System.Windows.Forms.Label();
            this.txtNgay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHello
            // 
            this.txtHello.AutoSize = true;
            this.txtHello.BackColor = System.Drawing.Color.Transparent;
            this.txtHello.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHello.Location = new System.Drawing.Point(12, 185);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(274, 61);
            this.txtHello.TabIndex = 0;
            this.txtHello.Text = "Xin chào, ";
            // 
            // txtNgay
            // 
            this.txtNgay.AutoSize = true;
            this.txtNgay.BackColor = System.Drawing.Color.Transparent;
            this.txtNgay.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNgay.Location = new System.Drawing.Point(12, 9);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(93, 34);
            this.txtNgay.TabIndex = 1;
            this.txtNgay.Text = "label1";
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources.HomePage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 681);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.txtHello);
            this.DoubleBuffered = true;
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHello;
        private System.Windows.Forms.Label txtNgay;
    }
}