namespace PresentationTier.CongNo
{
    partial class frmTraNoKH
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
            this.gbxThongTinKH = new System.Windows.Forms.GroupBox();
            this.trvThongTinKH = new System.Windows.Forms.TreeView();
            this.gbxNoKH = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxMaHoaDon = new System.Windows.Forms.TextBox();
            this.tbxSoTien = new System.Windows.Forms.TextBox();
            this.ricGhiChu = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.btnTraNo = new System.Windows.Forms.Button();
            this.dgvPhieuNo = new System.Windows.Forms.DataGridView();
            this.gbxThongTinKH.SuspendLayout();
            this.gbxNoKH.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxThongTinKH
            // 
            this.gbxThongTinKH.Controls.Add(this.trvThongTinKH);
            this.gbxThongTinKH.Location = new System.Drawing.Point(16, 13);
            this.gbxThongTinKH.Name = "gbxThongTinKH";
            this.gbxThongTinKH.Size = new System.Drawing.Size(411, 362);
            this.gbxThongTinKH.TabIndex = 2;
            this.gbxThongTinKH.TabStop = false;
            this.gbxThongTinKH.Text = "Khách hàng";
            // 
            // trvThongTinKH
            // 
            this.trvThongTinKH.Location = new System.Drawing.Point(15, 21);
            this.trvThongTinKH.Name = "trvThongTinKH";
            this.trvThongTinKH.Size = new System.Drawing.Size(380, 323);
            this.trvThongTinKH.TabIndex = 0;
            this.trvThongTinKH.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvThongTinKH_AfterExpand);
            this.trvThongTinKH.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvThongTinKH_AfterSelect);
            // 
            // gbxNoKH
            // 
            this.gbxNoKH.Controls.Add(this.btnOK);
            this.gbxNoKH.Controls.Add(this.panel1);
            this.gbxNoKH.Controls.Add(this.btnTraNo);
            this.gbxNoKH.Controls.Add(this.dgvPhieuNo);
            this.gbxNoKH.Location = new System.Drawing.Point(433, 15);
            this.gbxNoKH.Name = "gbxNoKH";
            this.gbxNoKH.Size = new System.Drawing.Size(532, 360);
            this.gbxNoKH.TabIndex = 3;
            this.gbxNoKH.TabStop = false;
            this.gbxNoKH.Text = "Công nợ";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(18, 258);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Đồng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxMaHoaDon);
            this.panel1.Controls.Add(this.tbxSoTien);
            this.panel1.Controls.Add(this.ricGhiChu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSoTien);
            this.panel1.Controls.Add(this.lblMaHoaDon);
            this.panel1.Location = new System.Drawing.Point(99, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 135);
            this.panel1.TabIndex = 2;
            // 
            // tbxMaHoaDon
            // 
            this.tbxMaHoaDon.Location = new System.Drawing.Point(92, 7);
            this.tbxMaHoaDon.Name = "tbxMaHoaDon";
            this.tbxMaHoaDon.ReadOnly = true;
            this.tbxMaHoaDon.Size = new System.Drawing.Size(291, 20);
            this.tbxMaHoaDon.TabIndex = 4;
            // 
            // tbxSoTien
            // 
            this.tbxSoTien.Location = new System.Drawing.Point(92, 41);
            this.tbxSoTien.MaxLength = 50;
            this.tbxSoTien.Name = "tbxSoTien";
            this.tbxSoTien.ReadOnly = true;
            this.tbxSoTien.Size = new System.Drawing.Size(291, 20);
            this.tbxSoTien.TabIndex = 4;
            // 
            // ricGhiChu
            // 
            this.ricGhiChu.Location = new System.Drawing.Point(92, 76);
            this.ricGhiChu.MaxLength = 5000;
            this.ricGhiChu.Name = "ricGhiChu";
            this.ricGhiChu.ReadOnly = true;
            this.ricGhiChu.Size = new System.Drawing.Size(291, 47);
            this.ricGhiChu.TabIndex = 2;
            this.ricGhiChu.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ghi chú";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(21, 44);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(40, 13);
            this.lblSoTien.TabIndex = 1;
            this.lblSoTien.Text = "Số tiền";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Location = new System.Drawing.Point(21, 10);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(65, 13);
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // btnTraNo
            // 
            this.btnTraNo.Location = new System.Drawing.Point(18, 219);
            this.btnTraNo.Name = "btnTraNo";
            this.btnTraNo.Size = new System.Drawing.Size(75, 23);
            this.btnTraNo.TabIndex = 1;
            this.btnTraNo.Tag = "0";
            this.btnTraNo.Text = "Thu nợ";
            this.btnTraNo.UseVisualStyleBackColor = true;
            this.btnTraNo.Click += new System.EventHandler(this.btnTraNo_Click);
            // 
            // dgvPhieuNo
            // 
            this.dgvPhieuNo.AllowUserToAddRows = false;
            this.dgvPhieuNo.AllowUserToDeleteRows = false;
            this.dgvPhieuNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNo.Location = new System.Drawing.Point(18, 19);
            this.dgvPhieuNo.Name = "dgvPhieuNo";
            this.dgvPhieuNo.ReadOnly = true;
            this.dgvPhieuNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNo.Size = new System.Drawing.Size(508, 194);
            this.dgvPhieuNo.TabIndex = 0;
            // 
            // frmTraNoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 388);
            this.Controls.Add(this.gbxThongTinKH);
            this.Controls.Add(this.gbxNoKH);
            this.MinimizeBox = false;
            this.Name = "frmTraNoKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu nợ khách hàng";
            this.Load += new System.EventHandler(this.frmTraNoKH_Load);
            this.gbxThongTinKH.ResumeLayout(false);
            this.gbxNoKH.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxThongTinKH;
        private System.Windows.Forms.TreeView trvThongTinKH;
        private System.Windows.Forms.GroupBox gbxNoKH;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxMaHoaDon;
        private System.Windows.Forms.TextBox tbxSoTien;
        private System.Windows.Forms.RichTextBox ricGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Button btnTraNo;
        private System.Windows.Forms.DataGridView dgvPhieuNo;
    }
}