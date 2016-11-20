namespace PresentationTier.CongNo
{
    partial class FormMainCongNo
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
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnTraNoNCC = new System.Windows.Forms.Button();
            this.btnThuNoKH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Location = new System.Drawing.Point(59, 20);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(162, 66);
            this.btnXemThongTin.TabIndex = 0;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // btnTraNoNCC
            // 
            this.btnTraNoNCC.Location = new System.Drawing.Point(59, 86);
            this.btnTraNoNCC.Name = "btnTraNoNCC";
            this.btnTraNoNCC.Size = new System.Drawing.Size(162, 66);
            this.btnTraNoNCC.TabIndex = 0;
            this.btnTraNoNCC.Text = "Trả nợ NCC";
            this.btnTraNoNCC.UseVisualStyleBackColor = true;
            this.btnTraNoNCC.Click += new System.EventHandler(this.btnTraNoNCC_Click);
            // 
            // btnThuNoKH
            // 
            this.btnThuNoKH.Location = new System.Drawing.Point(59, 152);
            this.btnThuNoKH.Name = "btnThuNoKH";
            this.btnThuNoKH.Size = new System.Drawing.Size(162, 66);
            this.btnThuNoKH.TabIndex = 0;
            this.btnThuNoKH.Text = "Thu nợ khách hàng";
            this.btnThuNoKH.UseVisualStyleBackColor = true;
            this.btnThuNoKH.Click += new System.EventHandler(this.btnThuNoKH_Click);
            // 
            // FormMainCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.btnThuNoKH);
            this.Controls.Add(this.btnTraNoNCC);
            this.Controls.Add(this.btnXemThongTin);
            this.MinimizeBox = false;
            this.Name = "FormMainCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CongNo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnTraNoNCC;
        private System.Windows.Forms.Button btnThuNoKH;
    }
}