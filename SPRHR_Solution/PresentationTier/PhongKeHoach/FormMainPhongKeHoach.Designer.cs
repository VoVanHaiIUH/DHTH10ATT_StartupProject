namespace PresentationTier.PhongKeHoach
{
    partial class FormMainPhongKeHoach
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
            this.CbQl = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CbQl
            // 
            this.CbQl.FormattingEnabled = true;
            this.CbQl.Items.AddRange(new object[] {
            "Quản Lý Hóa Đơn Nhà Cung Cấp",
            "Quản Lý Sản Phẩm",
            "Quản Lý Khiếu Đề Nghị Nhập Kho",
            "Quản Lý Hóa Đơn Bán Sĩ",
            "Quản Lý Khiếu Đề Nghị Xuất Kho",
            "Quản Lý Thẻ Thành Viên"});
            this.CbQl.Location = new System.Drawing.Point(4, 43);
            this.CbQl.Name = "CbQl";
            this.CbQl.Size = new System.Drawing.Size(376, 21);
            this.CbQl.TabIndex = 0;
            this.CbQl.Text = "Quản Lý PDNNK";
            this.CbQl.SelectedIndexChanged += new System.EventHandler(this.CbQl_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationTier.Properties.Resources.ght;
            this.pictureBox1.Location = new System.Drawing.Point(157, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainPhongKeHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 114);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CbQl);
            this.Name = "FormMainPhongKeHoach";
            this.Text = "Phòng Kế Hoạch";
            this.Load += new System.EventHandler(this.FormMainPhongKeHoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbQl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}