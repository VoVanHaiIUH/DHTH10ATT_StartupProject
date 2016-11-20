namespace SPRHR_Kho
{
    partial class frmReceivePhieuDNXK
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuDNXK = new System.Windows.Forms.TextBox();
            this.dgvPhieuDNXK = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.PushNotification1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDNXK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(179, 230);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(231, 31);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Xác nhận phiếu xuất kho";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mã kho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ngày lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mã Phiếu DNXK:";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(158, 182);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(289, 26);
            this.txtMaKho.TabIndex = 36;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(158, 76);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(289, 26);
            this.txtMaKH.TabIndex = 35;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(158, 113);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(289, 26);
            this.txtMaNhanVien.TabIndex = 34;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Location = new System.Drawing.Point(158, 145);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(289, 26);
            this.dtpNgayLap.TabIndex = 33;
            // 
            // txtMaPhieuDNXK
            // 
            this.txtMaPhieuDNXK.Enabled = false;
            this.txtMaPhieuDNXK.Location = new System.Drawing.Point(158, 39);
            this.txtMaPhieuDNXK.Name = "txtMaPhieuDNXK";
            this.txtMaPhieuDNXK.Size = new System.Drawing.Size(289, 26);
            this.txtMaPhieuDNXK.TabIndex = 31;
            // 
            // dgvPhieuDNXK
            // 
            this.dgvPhieuDNXK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDNXK.Location = new System.Drawing.Point(12, 47);
            this.dgvPhieuDNXK.Name = "dgvPhieuDNXK";
            this.dgvPhieuDNXK.Size = new System.Drawing.Size(281, 290);
            this.dgvPhieuDNXK.TabIndex = 30;
            this.dgvPhieuDNXK.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvPhieuDNXK_RowStateChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(755, 409);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(10, 10);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // PushNotification1
            // 
            this.PushNotification1.Visible = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPhieuDNXK);
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaKho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(316, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 297);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đề nghị xuất kho";
            // 
            // frmReceivePhieuDNXK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgvPhieuDNXK);
            this.Name = "frmReceivePhieuDNXK";
            this.Text = "Khung nhận phiếu Đề Nghị Xuất Kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReceivePhieuDNXK_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDNXK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMaPhieuDNXK;
        public System.Windows.Forms.TextBox txtMaNhanVien;
        public System.Windows.Forms.TextBox txtMaKH;
        public System.Windows.Forms.DateTimePicker dtpNgayLap;
        public System.Windows.Forms.TextBox txtMaKho;
        public System.Windows.Forms.DataGridView dgvPhieuDNXK;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NotifyIcon PushNotification1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}