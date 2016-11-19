namespace PresentationTier.Kho
{
    partial class frmXemPhieuNhap
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
            this.tvPhieuNhap = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVsp = new System.Windows.Forms.DataGridView();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmakho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtngay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.RichTextBox();
            this.txtsophieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVsp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvPhieuNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập Kho";
            // 
            // tvPhieuNhap
            // 
            this.tvPhieuNhap.Location = new System.Drawing.Point(6, 19);
            this.tvPhieuNhap.Name = "tvPhieuNhap";
            this.tvPhieuNhap.Size = new System.Drawing.Size(178, 361);
            this.tvPhieuNhap.TabIndex = 0;
            this.tvPhieuNhap.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPhieuNhap_AfterSelect);
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
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dGVsp
            // 
            this.dGVsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVsp.Location = new System.Drawing.Point(219, 222);
            this.dGVsp.Name = "dGVsp";
            this.dGVsp.Size = new System.Drawing.Size(470, 176);
            this.dGVsp.TabIndex = 2;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(322, 23);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(134, 20);
            this.txtmanv.TabIndex = 0;
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
            // txtmakho
            // 
            this.txtmakho.Location = new System.Drawing.Point(89, 69);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.ReadOnly = true;
            this.txtmakho.Size = new System.Drawing.Size(134, 20);
            this.txtmakho.TabIndex = 0;
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
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(89, 118);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.ReadOnly = true;
            this.txtghichu.Size = new System.Drawing.Size(363, 80);
            this.txtghichu.TabIndex = 2;
            this.txtghichu.Text = "";
            // 
            // txtsophieu
            // 
            this.txtsophieu.Location = new System.Drawing.Point(87, 23);
            this.txtsophieu.Name = "txtsophieu";
            this.txtsophieu.ReadOnly = true;
            this.txtsophieu.Size = new System.Drawing.Size(134, 20);
            this.txtsophieu.TabIndex = 0;
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
            // frmXemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 410);
            this.Controls.Add(this.dGVsp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXemPhieuNhap";
            this.Text = "frmXemPhieuNhap";
            this.Load += new System.EventHandler(this.frmXemPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVsp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tvPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGVsp;
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
    }
}