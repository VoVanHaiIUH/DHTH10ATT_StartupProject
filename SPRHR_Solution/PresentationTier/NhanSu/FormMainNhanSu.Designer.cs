namespace PresentationTier.NhanSu
{
    partial class FormMainNhanSu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLich = new System.Windows.Forms.Button();
            this.btnphongban = new System.Windows.Forms.Button();
            this.btnkyluat = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btndaotao = new System.Windows.Forms.Button();
            this.btnchucvu = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxemlichnhanvien = new System.Windows.Forms.Button();
            this.btnxemttnv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(101, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 271);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(461, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(167, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 202);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông báo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLich);
            this.groupBox3.Controls.Add(this.btnphongban);
            this.groupBox3.Controls.Add(this.btnkyluat);
            this.groupBox3.Controls.Add(this.btnnhanvien);
            this.groupBox3.Controls.Add(this.btndaotao);
            this.groupBox3.Controls.Add(this.btnchucvu);
            this.groupBox3.Location = new System.Drawing.Point(3, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 200);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnLich
            // 
            this.btnLich.Location = new System.Drawing.Point(16, 164);
            this.btnLich.Name = "btnLich";
            this.btnLich.Size = new System.Drawing.Size(113, 21);
            this.btnLich.TabIndex = 0;
            this.btnLich.Text = "Lịch làm việc";
            this.btnLich.UseVisualStyleBackColor = true;
            this.btnLich.Click += new System.EventHandler(this.btnLich_Click);
            // 
            // btnphongban
            // 
            this.btnphongban.Location = new System.Drawing.Point(16, 77);
            this.btnphongban.Name = "btnphongban";
            this.btnphongban.Size = new System.Drawing.Size(113, 21);
            this.btnphongban.TabIndex = 0;
            this.btnphongban.Text = "Phòng ban";
            this.btnphongban.UseVisualStyleBackColor = true;
            this.btnphongban.Click += new System.EventHandler(this.btnphongban_Click);
            // 
            // btnkyluat
            // 
            this.btnkyluat.Location = new System.Drawing.Point(16, 135);
            this.btnkyluat.Name = "btnkyluat";
            this.btnkyluat.Size = new System.Drawing.Size(113, 21);
            this.btnkyluat.TabIndex = 0;
            this.btnkyluat.Text = "Kỷ luật";
            this.btnkyluat.UseVisualStyleBackColor = true;
            this.btnkyluat.Click += new System.EventHandler(this.btnkyluat_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Location = new System.Drawing.Point(16, 19);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(113, 21);
            this.btnnhanvien.TabIndex = 0;
            this.btnnhanvien.Text = "Nhân Viên";
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btndaotao
            // 
            this.btndaotao.Location = new System.Drawing.Point(16, 106);
            this.btndaotao.Name = "btndaotao";
            this.btndaotao.Size = new System.Drawing.Size(113, 21);
            this.btndaotao.TabIndex = 0;
            this.btndaotao.Text = "Đào tạo";
            this.btndaotao.UseVisualStyleBackColor = true;
            this.btndaotao.Click += new System.EventHandler(this.btndaotao_Click);
            // 
            // btnchucvu
            // 
            this.btnchucvu.Location = new System.Drawing.Point(16, 48);
            this.btnchucvu.Name = "btnchucvu";
            this.btnchucvu.Size = new System.Drawing.Size(113, 21);
            this.btnchucvu.TabIndex = 0;
            this.btnchucvu.Text = "Chức vụ";
            this.btnchucvu.UseVisualStyleBackColor = true;
            this.btnchucvu.Click += new System.EventHandler(this.btnchucvu_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(461, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(165, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông báo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxemlichnhanvien);
            this.groupBox1.Controls.Add(this.btnxemttnv);
            this.groupBox1.Location = new System.Drawing.Point(8, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnxemlichnhanvien
            // 
            this.btnxemlichnhanvien.Location = new System.Drawing.Point(18, 73);
            this.btnxemlichnhanvien.Name = "btnxemlichnhanvien";
            this.btnxemlichnhanvien.Size = new System.Drawing.Size(118, 23);
            this.btnxemlichnhanvien.TabIndex = 0;
            this.btnxemlichnhanvien.Text = "Xem lịch";
            this.btnxemlichnhanvien.UseVisualStyleBackColor = true;
            this.btnxemlichnhanvien.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnxemttnv
            // 
            this.btnxemttnv.Location = new System.Drawing.Point(18, 31);
            this.btnxemttnv.Name = "btnxemttnv";
            this.btnxemttnv.Size = new System.Drawing.Size(118, 23);
            this.btnxemttnv.TabIndex = 0;
            this.btnxemttnv.Text = "Xem thông tin nhân viên";
            this.btnxemttnv.UseVisualStyleBackColor = true;
            this.btnxemttnv.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(132, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "NHÂN VIÊN";
            // 
            // FormMainNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(469, 281);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMainNhanSu";
            this.Text = "frmMainNhanSu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxemlichnhanvien;
        private System.Windows.Forms.Button btnxemttnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLich;
        private System.Windows.Forms.Button btnphongban;
        private System.Windows.Forms.Button btnkyluat;
        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Button btndaotao;
        private System.Windows.Forms.Button btnchucvu;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}