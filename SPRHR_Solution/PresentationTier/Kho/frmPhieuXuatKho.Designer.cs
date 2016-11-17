namespace PresentationTier.Kho
{
    partial class frmPhieuXuatKho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvPhieudn = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGVchitiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsophieu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmakho = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVchitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvPhieudn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đề nghị xuất kho";
            // 
            // tvPhieudn
            // 
            this.tvPhieudn.Location = new System.Drawing.Point(6, 19);
            this.tvPhieudn.Name = "tvPhieudn";
            this.tvPhieudn.Size = new System.Drawing.Size(152, 313);
            this.tvPhieudn.TabIndex = 0;
            this.tvPhieudn.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPhieudn_AfterSelect);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGVchitiet);
            this.groupBox3.Location = new System.Drawing.Point(194, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 166);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phiếu ";
            // 
            // dGVchitiet
            // 
            this.dGVchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVchitiet.Location = new System.Drawing.Point(6, 19);
            this.dGVchitiet.Name = "dGVchitiet";
            this.dGVchitiet.Size = new System.Drawing.Size(512, 141);
            this.dGVchitiet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Phiếu:";
            // 
            // txtsophieu
            // 
            this.txtsophieu.AutoSize = true;
            this.txtsophieu.Location = new System.Drawing.Point(267, 23);
            this.txtsophieu.Name = "txtsophieu";
            this.txtsophieu.Size = new System.Drawing.Size(0, 13);
            this.txtsophieu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Kho:";
            // 
            // txtmakho
            // 
            this.txtmakho.AutoSize = true;
            this.txtmakho.Location = new System.Drawing.Point(497, 23);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.Size = new System.Drawing.Size(0, 13);
            this.txtmakho.TabIndex = 4;
            // 
            // txttennv
            // 
            this.txttennv.AutoSize = true;
            this.txttennv.Location = new System.Drawing.Point(497, 60);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(77, 13);
            this.txttennv.TabIndex = 39;
            this.txttennv.Text = "Đào Bình Minh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tên nhân viên:";
            // 
            // txtghichu
            // 
            this.txtghichu.Enabled = false;
            this.txtghichu.Location = new System.Drawing.Point(270, 92);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(343, 57);
            this.txtghichu.TabIndex = 37;
            this.txtghichu.Text = "TEST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ghi Chú:";
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(275, 53);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(116, 20);
            this.txtManv.TabIndex = 35;
            this.txtManv.Text = "NV0012";
            this.txtManv.Leave += new System.EventHandler(this.txtManv_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(200, 327);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(114, 23);
            this.btnthem.TabIndex = 40;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(363, 327);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(114, 23);
            this.btnluu.TabIndex = 40;
            this.btnluu.Text = "lưu phiếu xuất kho";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // frmPhieuXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 366);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmakho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsophieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuXuatKho";
            this.Text = "frmPhieuXuatKho";
            this.Load += new System.EventHandler(this.frmPhieuXuatKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVchitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtsophieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtmakho;
        private System.Windows.Forms.TreeView tvPhieudn;
        private System.Windows.Forms.DataGridView dGVchitiet;
        private System.Windows.Forms.Label txttennv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtghichu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
    }
}