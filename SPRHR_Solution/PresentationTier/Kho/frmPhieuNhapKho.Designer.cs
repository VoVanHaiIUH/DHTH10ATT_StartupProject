namespace PresentationTier.Kho
{
    partial class frmPhieuNhapKho
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVCT = new System.Windows.Forms.DataGridView();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvDSPDN = new System.Windows.Forms.TreeView();
            this.lbsoPhieunk = new System.Windows.Forms.Label();
            this.lbMakho = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGVCT);
            this.groupBox2.Location = new System.Drawing.Point(226, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 176);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu đề nghị nhập kho";
            // 
            // dGVCT
            // 
            this.dGVCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCT.Location = new System.Drawing.Point(6, 19);
            this.dGVCT.Name = "dGVCT";
            this.dGVCT.Size = new System.Drawing.Size(438, 146);
            this.dGVCT.TabIndex = 1;
            // 
            // txtManv
            // 
            this.txtManv.Enabled = false;
            this.txtManv.Location = new System.Drawing.Point(306, 64);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(116, 20);
            this.txtManv.TabIndex = 25;
            this.txtManv.Text = "NV0012";
            this.txtManv.Leave += new System.EventHandler(this.txtManv_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã Kho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Số Phiếu:";
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(515, 348);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(155, 23);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(226, 348);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(196, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm Phiếu Nhập Kho";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvDSPDN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 330);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu đề nghị nhập kho";
            // 
            // tvDSPDN
            // 
            this.tvDSPDN.Location = new System.Drawing.Point(6, 19);
            this.tvDSPDN.Name = "tvDSPDN";
            this.tvDSPDN.Size = new System.Drawing.Size(190, 300);
            this.tvDSPDN.TabIndex = 0;
            this.tvDSPDN.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDSPDN_AfterSelect_1);
            // 
            // lbsoPhieunk
            // 
            this.lbsoPhieunk.AutoSize = true;
            this.lbsoPhieunk.Location = new System.Drawing.Point(303, 31);
            this.lbsoPhieunk.Name = "lbsoPhieunk";
            this.lbsoPhieunk.Size = new System.Drawing.Size(0, 13);
            this.lbsoPhieunk.TabIndex = 28;
            // 
            // lbMakho
            // 
            this.lbMakho.AutoSize = true;
            this.lbMakho.Location = new System.Drawing.Point(491, 31);
            this.lbMakho.Name = "lbMakho";
            this.lbMakho.Size = new System.Drawing.Size(0, 13);
            this.lbMakho.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ghi Chú:";
            // 
            // txtghichu
            // 
            this.txtghichu.Enabled = false;
            this.txtghichu.Location = new System.Drawing.Point(306, 103);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(343, 57);
            this.txtghichu.TabIndex = 31;
            this.txtghichu.Text = "TEST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tên nhân viên:";
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Location = new System.Drawing.Point(533, 71);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(0, 13);
            this.lbtennv.TabIndex = 33;
            this.lbtennv.Text = "Đào Bình Minh";
            // 
            // frmPhieuNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 383);
            this.Controls.Add(this.lbtennv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMakho);
            this.Controls.Add(this.lbsoPhieunk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhieuNhapKho";
            this.Text = "PhieuNhapKho";
            this.Load += new System.EventHandler(this.frmPhieuNhapKho_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVCT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGVCT;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvDSPDN;
        private System.Windows.Forms.Label lbsoPhieunk;
        private System.Windows.Forms.Label lbMakho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtghichu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbtennv;
    }
}