﻿namespace PresentationTier.BanHang
{
    partial class frmLapPhieu
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
            this.grbHD = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radYVAT = new System.Windows.Forms.RadioButton();
            this.radNVAT = new System.Windows.Forms.RadioButton();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTIme = new System.Windows.Forms.Label();
            this.grbHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHD
            // 
            this.grbHD.Controls.Add(this.txtMaKH);
            this.grbHD.Controls.Add(this.label2);
            this.grbHD.Controls.Add(this.txtMaNV);
            this.grbHD.Controls.Add(this.label1);
            this.grbHD.Location = new System.Drawing.Point(90, 43);
            this.grbHD.Name = "grbHD";
            this.grbHD.Size = new System.Drawing.Size(279, 81);
            this.grbHD.TabIndex = 0;
            this.grbHD.TabStop = false;
            this.grbHD.Text = "Thông tin Hóa Đơn";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(98, 47);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(162, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(98, 21);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(162, 20);
            this.txtMaNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToResizeColumns = false;
            this.dgvChiTiet.AllowUserToResizeRows = false;
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(12, 130);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(437, 150);
            this.dgvChiTiet.TabIndex = 1;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            this.dgvChiTiet.SelectionChanged += new System.EventHandler(this.dgvChiTiet_SelectionChanged);
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.txtKM);
            this.grbChiTiet.Controls.Add(this.txtSoLuong);
            this.grbChiTiet.Controls.Add(this.label10);
            this.grbChiTiet.Controls.Add(this.txtDonGia);
            this.grbChiTiet.Controls.Add(this.label3);
            this.grbChiTiet.Controls.Add(this.label5);
            this.grbChiTiet.Controls.Add(this.label4);
            this.grbChiTiet.Controls.Add(this.txtMaSP);
            this.grbChiTiet.Location = new System.Drawing.Point(12, 286);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(437, 86);
            this.grbChiTiet.TabIndex = 2;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Thông tin chi tiết Hóa Đơn";
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(300, 50);
            this.txtKM.Name = "txtKM";
            this.txtKM.ReadOnly = true;
            this.txtKM.Size = new System.Drawing.Size(117, 20);
            this.txtKM.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(300, 24);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(77, 20);
            this.txtSoLuong.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(232, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Khuyến mãi";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(86, 49);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(144, 20);
            this.txtDonGia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đơn giá";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(86, 23);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(144, 20);
            this.txtMaSP.TabIndex = 0;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(99, 378);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(113, 23);
            this.btnThemSP.TabIndex = 3;
            this.btnThemSP.Tag = "0";
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(283, 378);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(113, 23);
            this.btnXoaSP.TabIndex = 3;
            this.btnXoaSP.Tag = "0";
            this.btnXoaSP.Text = "Xóa khỏi giỏ hàng";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thuế VAT";
            // 
            // radYVAT
            // 
            this.radYVAT.AutoSize = true;
            this.radYVAT.Location = new System.Drawing.Point(99, 412);
            this.radYVAT.Name = "radYVAT";
            this.radYVAT.Size = new System.Drawing.Size(38, 17);
            this.radYVAT.TabIndex = 5;
            this.radYVAT.TabStop = true;
            this.radYVAT.Text = "Có";
            this.radYVAT.UseVisualStyleBackColor = true;
            this.radYVAT.CheckedChanged += new System.EventHandler(this.radYVAT_CheckedChanged);
            // 
            // radNVAT
            // 
            this.radNVAT.AutoSize = true;
            this.radNVAT.Location = new System.Drawing.Point(151, 412);
            this.radNVAT.Name = "radNVAT";
            this.radNVAT.Size = new System.Drawing.Size(56, 17);
            this.radNVAT.TabIndex = 5;
            this.radNVAT.TabStop = true;
            this.radNVAT.Text = "Không";
            this.radNVAT.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(296, 411);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(153, 20);
            this.txtTongTien.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tổng tiền:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(334, 438);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(115, 23);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTIme
            // 
            this.lblTIme.AutoSize = true;
            this.lblTIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIme.Location = new System.Drawing.Point(53, 9);
            this.lblTIme.Name = "lblTIme";
            this.lblTIme.Size = new System.Drawing.Size(14, 20);
            this.lblTIme.TabIndex = 10;
            this.lblTIme.Text = " ";
            // 
            // frmLapPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 469);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.lblTIme);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radNVAT);
            this.Controls.Add(this.radYVAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.grbHD);
            this.MaximizeBox = false;
            this.Name = "frmLapPhieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Hóa Đơn Bán Hàng";
            this.Load += new System.EventHandler(this.frmLapPhieu_Load);
            this.grbHD.ResumeLayout(false);
            this.grbHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHD;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radYVAT;
        private System.Windows.Forms.RadioButton radNVAT;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTIme;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.Label label10;
    }
}