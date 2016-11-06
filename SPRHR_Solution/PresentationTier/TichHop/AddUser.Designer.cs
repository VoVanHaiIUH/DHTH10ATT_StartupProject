namespace PresentationTier.TichHop
{
    partial class AddUser
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbb_role = new System.Windows.Forms.ComboBox();
            this.tb_config = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(223, 181);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(167, 23);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(37, 181);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(167, 23);
            this.btn_save.TabIndex = 15;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbb_role
            // 
            this.cbb_role.FormattingEnabled = true;
            this.cbb_role.Items.AddRange(new object[] {
            "Bán Hàng",
            "Nhân Sự",
            "Kho",
            "Phòng Kế Hoạch",
            "Công Nợ",
            "Admin",
            "Không Có Quyền"});
            this.cbb_role.Location = new System.Drawing.Point(146, 132);
            this.cbb_role.Name = "cbb_role";
            this.cbb_role.Size = new System.Drawing.Size(241, 23);
            this.cbb_role.TabIndex = 14;
            // 
            // tb_config
            // 
            this.tb_config.Location = new System.Drawing.Point(146, 92);
            this.tb_config.Name = "tb_config";
            this.tb_config.Size = new System.Drawing.Size(241, 21);
            this.tb_config.TabIndex = 13;
            this.tb_config.UseSystemPasswordChar = true;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(146, 59);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(241, 21);
            this.tb_pass.TabIndex = 12;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(58, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(146, 23);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(241, 21);
            this.tb_userName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Config Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(58, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "UserName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(434, 227);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbb_role);
            this.Controls.Add(this.tb_config);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUser";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.TextBox tb_config;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}