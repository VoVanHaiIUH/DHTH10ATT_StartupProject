namespace PresentationTier.Kho
{
    partial class frmXemPhieuXuat
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
            this.dGVsp = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtghichu = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.TextBox();
            this.txtsophieu = new System.Windows.Forms.TextBox();
            this.txtmakho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tvPhieuNhap = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVsp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVsp
            // 
            this.dGVsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVsp.Location = new System.Drawing.Point(175, 220);
            this.dGVsp.Name = "dGVsp";
            this.dGVsp.Size = new System.Drawing.Size(511, 176);
            this.dGVsp.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtghichu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtngay);
            this.groupBox2.Controls.Add(this.txtsophieu);
            this.groupBox2.Controls.Add(this.txtmakho);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmanv);
            this.groupBox2.Location = new System.Drawing.Point(175, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(89, 118);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.ReadOnly = true;
            this.txtghichu.Size = new System.Drawing.Size(363, 80);
            this.txtghichu.TabIndex = 2;
            this.txtghichu.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ghi Chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số Phiếu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Kho:";
            // 
            // txtngay
            // 
            this.txtngay.Location = new System.Drawing.Point(322, 69);
            this.txtngay.Name = "txtngay";
            this.txtngay.ReadOnly = true;
            this.txtngay.Size = new System.Drawing.Size(134, 20);
            this.txtngay.TabIndex = 0;
            // 
            // txtsophieu
            // 
            this.txtsophieu.Location = new System.Drawing.Point(87, 23);
            this.txtsophieu.Name = "txtsophieu";
            this.txtsophieu.ReadOnly = true;
            this.txtsophieu.Size = new System.Drawing.Size(134, 20);
            this.txtsophieu.TabIndex = 0;
            // 
            // txtmakho
            // 
            this.txtmakho.Location = new System.Drawing.Point(89, 69);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.ReadOnly = true;
            this.txtmakho.Size = new System.Drawing.Size(134, 20);
            this.txtmakho.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân viên:";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(322, 23);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(134, 20);
            this.txtmanv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvPhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 386);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Xuất Kho";
            // 
            // tvPhieuNhap
            // 
            this.tvPhieuNhap.Location = new System.Drawing.Point(6, 19);
            this.tvPhieuNhap.Name = "tvPhieuNhap";
            this.tvPhieuNhap.Size = new System.Drawing.Size(146, 361);
            this.tvPhieuNhap.TabIndex = 0;
            this.tvPhieuNhap.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPhieuNhap_AfterSelect);
            // 
            // frmXemPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 406);
            this.Controls.Add(this.dGVsp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXemPhieuXuat";
            this.Text = "frmXemPhieuXuat";
            this.Load += new System.EventHandler(this.frmXemPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVsp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVsp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtghichu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtngay;
        private System.Windows.Forms.TextBox txtsophieu;
        private System.Windows.Forms.TextBox txtmakho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvPhieuNhap;
    }
}