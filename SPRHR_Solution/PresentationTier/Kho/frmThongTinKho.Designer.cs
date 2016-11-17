namespace PresentationTier.Kho
{
    partial class frmThongTinKho_dal
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
            this.tvDSkho = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdiachi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenkho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmakho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGVSP = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tvDSkho
            // 
            this.tvDSkho.Location = new System.Drawing.Point(6, 19);
            this.tvDSkho.Name = "tvDSkho";
            this.tvDSkho.Size = new System.Drawing.Size(146, 146);
            this.tvDSkho.TabIndex = 0;
            this.tvDSkho.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDSkho_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tvDSkho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtsdt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txttenkho);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtmakho);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(176, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin kho";
            // 
            // txtdiachi
            // 
            this.txtdiachi.AutoSize = true;
            this.txtdiachi.Location = new System.Drawing.Point(59, 90);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(35, 13);
            this.txtdiachi.TabIndex = 7;
            this.txtdiachi.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txtsdt
            // 
            this.txtsdt.AutoSize = true;
            this.txtsdt.Location = new System.Drawing.Point(85, 59);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(35, 13);
            this.txtsdt.TabIndex = 5;
            this.txtsdt.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại:";
            // 
            // txttenkho
            // 
            this.txttenkho.AutoSize = true;
            this.txttenkho.Location = new System.Drawing.Point(215, 28);
            this.txttenkho.Name = "txttenkho";
            this.txttenkho.Size = new System.Drawing.Size(35, 13);
            this.txttenkho.TabIndex = 3;
            this.txttenkho.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Kho:";
            // 
            // txtmakho
            // 
            this.txtmakho.AutoSize = true;
            this.txtmakho.Location = new System.Drawing.Point(59, 28);
            this.txtmakho.Name = "txtmakho";
            this.txtmakho.Size = new System.Drawing.Size(35, 13);
            this.txtmakho.TabIndex = 1;
            this.txtmakho.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Kho:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGVSP);
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 247);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm tồn kho";
            // 
            // dGVSP
            // 
            this.dGVSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGVSP.Location = new System.Drawing.Point(6, 19);
            this.dGVSP.Name = "dGVSP";
            this.dGVSP.Size = new System.Drawing.Size(637, 222);
            this.dGVSP.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm:";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(238, 148);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(188, 20);
            this.txttensp.TabIndex = 5;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(447, 146);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(89, 27);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // frmThongTinKho_dal
            // 
            this.AcceptButton = this.btntimkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 448);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongTinKho_dal";
            this.Text = "frmQuanLyKho";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDSkho;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtdiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtsdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txttenkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtmakho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGVSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Button btntimkiem;
    }
}