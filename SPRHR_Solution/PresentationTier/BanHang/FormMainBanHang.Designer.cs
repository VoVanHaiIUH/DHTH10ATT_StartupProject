namespace PresentationTier.BanHang
{
    partial class FormMainBanHang
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
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.btnNhanHang = new System.Windows.Forms.Button();
            this.btnDinhGia = new System.Windows.Forms.Button();
            this.btnInBarcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(12, 12);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(206, 23);
            this.btnLapPhieu.TabIndex = 0;
            this.btnLapPhieu.Text = "Lập Phiếu Bán Hàng";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // btnNhanHang
            // 
            this.btnNhanHang.Location = new System.Drawing.Point(12, 41);
            this.btnNhanHang.Name = "btnNhanHang";
            this.btnNhanHang.Size = new System.Drawing.Size(206, 23);
            this.btnNhanHang.TabIndex = 0;
            this.btnNhanHang.Text = "Nhận Hàng Từ Kho";
            this.btnNhanHang.UseVisualStyleBackColor = true;
            // 
            // btnDinhGia
            // 
            this.btnDinhGia.Location = new System.Drawing.Point(12, 70);
            this.btnDinhGia.Name = "btnDinhGia";
            this.btnDinhGia.Size = new System.Drawing.Size(206, 23);
            this.btnDinhGia.TabIndex = 0;
            this.btnDinhGia.Text = "Định Giá Sản Phẩm";
            this.btnDinhGia.UseVisualStyleBackColor = true;
            // 
            // btnInBarcode
            // 
            this.btnInBarcode.Location = new System.Drawing.Point(12, 99);
            this.btnInBarcode.Name = "btnInBarcode";
            this.btnInBarcode.Size = new System.Drawing.Size(206, 23);
            this.btnInBarcode.TabIndex = 0;
            this.btnInBarcode.Text = "In Và Dán Barcode";
            this.btnInBarcode.UseVisualStyleBackColor = true;
            // 
            // FormMainBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 136);
            this.Controls.Add(this.btnInBarcode);
            this.Controls.Add(this.btnDinhGia);
            this.Controls.Add(this.btnNhanHang);
            this.Controls.Add(this.btnLapPhieu);
            this.Name = "FormMainBanHang";
            this.Text = "BanHang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Button btnNhanHang;
        private System.Windows.Forms.Button btnDinhGia;
        private System.Windows.Forms.Button btnInBarcode;
    }
}