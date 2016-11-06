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
            this.CBHT = new System.Windows.Forms.ComboBox();
            this.CBKH = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CbQl
            // 
            this.CbQl.FormattingEnabled = true;
            this.CbQl.Items.AddRange(new object[] {
            "Quản Lý PDNNK",
            "Quản Lý PDNXK",
            "Quản Lý HDBS",
            "Quản Lý HDNCC",
            "Quản Lý Cửa Hàng",
            "Quản Lý Sản Phẩm",
            "Quản Lý Thành Viên",
            "Quản Lý Khách Hàng",
            "Exit"});
            this.CbQl.Location = new System.Drawing.Point(2, 43);
            this.CbQl.Name = "CbQl";
            this.CbQl.Size = new System.Drawing.Size(121, 21);
            this.CbQl.TabIndex = 0;
            this.CbQl.Text = "Quản Lý";
            // 
            // CBHT
            // 
            this.CBHT.FormattingEnabled = true;
            this.CBHT.Items.AddRange(new object[] {
            "Hiển Thị PDNNK",
            "Hiển Thị PDNXK",
            "Hiển Thị HDBS",
            "Hiển Thị HDNCC",
            "Hiển Thị Sản Phẩm",
            "Hiển Thị Thành Viên"});
            this.CBHT.Location = new System.Drawing.Point(129, 43);
            this.CBHT.Name = "CBHT";
            this.CBHT.Size = new System.Drawing.Size(121, 21);
            this.CBHT.TabIndex = 1;
            this.CBHT.Text = "Hiển Thị";
            // 
            // CBKH
            // 
            this.CBKH.FormattingEnabled = true;
            this.CBKH.Items.AddRange(new object[] {
            "Lập Kế Hoạch Sản Phẩm"});
            this.CBKH.Location = new System.Drawing.Point(256, 43);
            this.CBKH.Name = "CBKH";
            this.CBKH.Size = new System.Drawing.Size(121, 21);
            this.CBKH.TabIndex = 2;
            this.CBKH.Text = "Kế Hoạch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationTier.Properties.Resources.ght;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
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
            this.ClientSize = new System.Drawing.Size(381, 141);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CBKH);
            this.Controls.Add(this.CBHT);
            this.Controls.Add(this.CbQl);
            this.Name = "FormMainPhongKeHoach";
            this.Text = "Phòng Kế Hoạch";
            this.Load += new System.EventHandler(this.FormMainPhongKeHoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbQl;
        private System.Windows.Forms.ComboBox CBHT;
        private System.Windows.Forms.ComboBox CBKH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}