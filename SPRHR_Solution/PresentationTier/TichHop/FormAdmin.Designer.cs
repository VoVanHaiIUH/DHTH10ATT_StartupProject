namespace PresentationTier.TichHop
{
    partial class FormAdmin
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
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.rb_congNo = new System.Windows.Forms.RadioButton();
            this.rb_kho = new System.Windows.Forms.RadioButton();
            this.rb_pkh = new System.Windows.Forms.RadioButton();
            this.rb_banHang = new System.Windows.Forms.RadioButton();
            this.rb_nhanSu = new System.Windows.Forms.RadioButton();
            this.tw_ds = new System.Windows.Forms.TreeView();
            this.lb_userName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_no);
            this.groupBox1.Controls.Add(this.rb_admin);
            this.groupBox1.Controls.Add(this.rb_congNo);
            this.groupBox1.Controls.Add(this.rb_kho);
            this.groupBox1.Controls.Add(this.rb_pkh);
            this.groupBox1.Controls.Add(this.rb_banHang);
            this.groupBox1.Controls.Add(this.rb_nhanSu);
            this.groupBox1.Location = new System.Drawing.Point(343, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 356);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Role";
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(27, 320);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(118, 19);
            this.rb_no.TabIndex = 0;
            this.rb_no.TabStop = true;
            this.rb_no.Tag = ".";
            this.rb_no.Text = "Không Có Quyền";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Location = new System.Drawing.Point(27, 271);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(61, 19);
            this.rb_admin.TabIndex = 0;
            this.rb_admin.TabStop = true;
            this.rb_admin.Tag = "admin";
            this.rb_admin.Text = "Admin";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // rb_congNo
            // 
            this.rb_congNo.AutoSize = true;
            this.rb_congNo.Location = new System.Drawing.Point(27, 223);
            this.rb_congNo.Name = "rb_congNo";
            this.rb_congNo.Size = new System.Drawing.Size(74, 19);
            this.rb_congNo.TabIndex = 0;
            this.rb_congNo.TabStop = true;
            this.rb_congNo.Tag = "CongNo";
            this.rb_congNo.Text = "Công Nợ";
            this.rb_congNo.UseVisualStyleBackColor = true;
            // 
            // rb_kho
            // 
            this.rb_kho.AutoSize = true;
            this.rb_kho.Location = new System.Drawing.Point(27, 172);
            this.rb_kho.Name = "rb_kho";
            this.rb_kho.Size = new System.Drawing.Size(47, 19);
            this.rb_kho.TabIndex = 0;
            this.rb_kho.TabStop = true;
            this.rb_kho.Tag = "Kho";
            this.rb_kho.Text = "Kho";
            this.rb_kho.UseVisualStyleBackColor = true;
            // 
            // rb_pkh
            // 
            this.rb_pkh.AutoSize = true;
            this.rb_pkh.Location = new System.Drawing.Point(27, 123);
            this.rb_pkh.Name = "rb_pkh";
            this.rb_pkh.Size = new System.Drawing.Size(118, 19);
            this.rb_pkh.TabIndex = 0;
            this.rb_pkh.TabStop = true;
            this.rb_pkh.Tag = "PKH";
            this.rb_pkh.Text = "Phòng Kế Hoạch";
            this.rb_pkh.UseVisualStyleBackColor = true;
            // 
            // rb_banHang
            // 
            this.rb_banHang.AutoSize = true;
            this.rb_banHang.Location = new System.Drawing.Point(27, 76);
            this.rb_banHang.Name = "rb_banHang";
            this.rb_banHang.Size = new System.Drawing.Size(79, 19);
            this.rb_banHang.TabIndex = 0;
            this.rb_banHang.TabStop = true;
            this.rb_banHang.Tag = "BanHang";
            this.rb_banHang.Text = "Bán Hàng";
            this.rb_banHang.UseVisualStyleBackColor = true;
            // 
            // rb_nhanSu
            // 
            this.rb_nhanSu.AutoSize = true;
            this.rb_nhanSu.Location = new System.Drawing.Point(27, 32);
            this.rb_nhanSu.Name = "rb_nhanSu";
            this.rb_nhanSu.Size = new System.Drawing.Size(74, 19);
            this.rb_nhanSu.TabIndex = 0;
            this.rb_nhanSu.TabStop = true;
            this.rb_nhanSu.Tag = "NhanSu";
            this.rb_nhanSu.Text = "Nhân Sự";
            this.rb_nhanSu.UseVisualStyleBackColor = true;
            // 
            // tw_ds
            // 
            this.tw_ds.FullRowSelect = true;
            this.tw_ds.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.tw_ds.Location = new System.Drawing.Point(12, 12);
            this.tw_ds.Name = "tw_ds";
            this.tw_ds.Size = new System.Drawing.Size(227, 355);
            this.tw_ds.TabIndex = 6;
            this.tw_ds.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tw_ds_AfterSelect);
            // 
            // lb_userName
            // 
            this.lb_userName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_userName.Location = new System.Drawing.Point(246, 44);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(91, 28);
            this.lb_userName.TabIndex = 12;
            this.lb_userName.Text = "label3";
            this.lb_userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "UserName";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(343, 378);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(227, 25);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.Location = new System.Drawing.Point(12, 378);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(227, 24);
            this.btn_addUser.TabIndex = 9;
            this.btn_addUser.Text = "&Add User";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // FormAdmin
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(593, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tw_ds);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_addUser);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Activated += new System.EventHandler(this.FormAdmin_Activated);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.RadioButton rb_admin;
        private System.Windows.Forms.RadioButton rb_congNo;
        private System.Windows.Forms.RadioButton rb_kho;
        private System.Windows.Forms.RadioButton rb_pkh;
        private System.Windows.Forms.RadioButton rb_banHang;
        private System.Windows.Forms.RadioButton rb_nhanSu;
        private System.Windows.Forms.TreeView tw_ds;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_addUser;
    }
}