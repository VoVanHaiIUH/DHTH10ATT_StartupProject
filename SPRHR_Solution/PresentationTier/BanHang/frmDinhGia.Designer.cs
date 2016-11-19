namespace PresentationTier.BanHang
{
    partial class frmDinhGia
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
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.txtNgayHetHan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrongLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgaySX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDinhGia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.grbSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSelect
            // 
            this.cboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Location = new System.Drawing.Point(137, 12);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(277, 21);
            this.cboSelect.TabIndex = 0;
            this.cboSelect.SelectedIndexChanged += new System.EventHandler(this.cboSelect_SelectedIndexChanged);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToResizeColumns = false;
            this.dgvSanPham.AllowUserToResizeRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(12, 39);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(529, 216);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            // 
            // grbSanPham
            // 
            this.grbSanPham.Controls.Add(this.txtNgayHetHan);
            this.grbSanPham.Controls.Add(this.label10);
            this.grbSanPham.Controls.Add(this.txtLoaiSP);
            this.grbSanPham.Controls.Add(this.label8);
            this.grbSanPham.Controls.Add(this.txtMauSac);
            this.grbSanPham.Controls.Add(this.label7);
            this.grbSanPham.Controls.Add(this.txtTrongLuong);
            this.grbSanPham.Controls.Add(this.label5);
            this.grbSanPham.Controls.Add(this.txtDonViTinh);
            this.grbSanPham.Controls.Add(this.label4);
            this.grbSanPham.Controls.Add(this.txtNgaySX);
            this.grbSanPham.Controls.Add(this.label3);
            this.grbSanPham.Controls.Add(this.txtTenSP);
            this.grbSanPham.Controls.Add(this.label2);
            this.grbSanPham.Controls.Add(this.txtMaSP);
            this.grbSanPham.Controls.Add(this.label1);
            this.grbSanPham.Location = new System.Drawing.Point(12, 261);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Size = new System.Drawing.Size(529, 141);
            this.grbSanPham.TabIndex = 2;
            this.grbSanPham.TabStop = false;
            this.grbSanPham.Text = "Thông tin Sản Phẩm";
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.Location = new System.Drawing.Point(83, 78);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.ReadOnly = true;
            this.txtNgayHetHan.Size = new System.Drawing.Size(183, 20);
            this.txtNgayHetHan.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày hết hạn";
            // 
            // txtMauSac
            // 
            this.txtMauSac.Location = new System.Drawing.Point(83, 104);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.ReadOnly = true;
            this.txtMauSac.Size = new System.Drawing.Size(81, 20);
            this.txtMauSac.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Màu sắc";
            // 
            // txtTrongLuong
            // 
            this.txtTrongLuong.Location = new System.Drawing.Point(243, 104);
            this.txtTrongLuong.Name = "txtTrongLuong";
            this.txtTrongLuong.ReadOnly = true;
            this.txtTrongLuong.Size = new System.Drawing.Size(97, 20);
            this.txtTrongLuong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trọng lượng";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(412, 104);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(111, 20);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đơn vị tính";
            // 
            // txtNgaySX
            // 
            this.txtNgaySX.Location = new System.Drawing.Point(365, 78);
            this.txtNgaySX.Name = "txtNgaySX";
            this.txtNgaySX.ReadOnly = true;
            this.txtNgaySX.Size = new System.Drawing.Size(158, 20);
            this.txtNgaySX.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sản xuất";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(84, 49);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(439, 20);
            this.txtTenSP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(83, 23);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(183, 20);
            this.txtMaSP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(349, 23);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.ReadOnly = true;
            this.txtLoaiSP.Size = new System.Drawing.Size(174, 20);
            this.txtLoaiSP.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loại sản phẩm";
            // 
            // btnDinhGia
            // 
            this.btnDinhGia.Location = new System.Drawing.Point(403, 408);
            this.btnDinhGia.Name = "btnDinhGia";
            this.btnDinhGia.Size = new System.Drawing.Size(138, 23);
            this.btnDinhGia.TabIndex = 3;
            this.btnDinhGia.Text = "Định Giá";
            this.btnDinhGia.UseVisualStyleBackColor = true;
            // 
            // frmDinhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(553, 445);
            this.Controls.Add(this.btnDinhGia);
            this.Controls.Add(this.grbSanPham);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.cboSelect);
            this.MaximizeBox = false;
            this.Name = "frmDinhGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định Giá Sản Phẩm";
            this.Load += new System.EventHandler(this.frmDinhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.grbSanPham.ResumeLayout(false);
            this.grbSanPham.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelect;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.Button btnDinhGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrongLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgaySX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNgayHetHan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label label7;
    }
}