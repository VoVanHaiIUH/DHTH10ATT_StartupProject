namespace PresentationTier.NhanSu
{
    partial class frmPhongBan
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
            this.texttenphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkhuvuc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewphongban = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntrove = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.btnmophong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "DANH SÁCH PHÒNG BAN";
            // 
            // texttenphong
            // 
            this.texttenphong.Location = new System.Drawing.Point(98, 30);
            this.texttenphong.Name = "texttenphong";
            this.texttenphong.Size = new System.Drawing.Size(158, 20);
            this.texttenphong.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng ban:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khu vực:";
            // 
            // txtkhuvuc
            // 
            this.txtkhuvuc.Location = new System.Drawing.Point(98, 72);
            this.txtkhuvuc.Name = "txtkhuvuc";
            this.txtkhuvuc.Size = new System.Drawing.Size(158, 20);
            this.txtkhuvuc.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewphongban);
            this.groupBox1.Location = new System.Drawing.Point(4, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng ban";
            // 
            // listViewphongban
            // 
            this.listViewphongban.Location = new System.Drawing.Point(6, 19);
            this.listViewphongban.Name = "listViewphongban";
            this.listViewphongban.Size = new System.Drawing.Size(121, 159);
            this.listViewphongban.TabIndex = 0;
            this.listViewphongban.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.texttenphong);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtkhuvuc);
            this.groupBox2.Location = new System.Drawing.Point(145, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 109);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(389, 174);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 23);
            this.btntrove.TabIndex = 3;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(308, 174);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(227, 174);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(75, 23);
            this.btnxacnhan.TabIndex = 1;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            // 
            // btnmophong
            // 
            this.btnmophong.Location = new System.Drawing.Point(146, 174);
            this.btnmophong.Name = "btnmophong";
            this.btnmophong.Size = new System.Drawing.Size(75, 23);
            this.btnmophong.TabIndex = 0;
            this.btnmophong.Text = "Mở phòng";
            this.btnmophong.UseVisualStyleBackColor = true;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(468, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.btnmophong);
            this.Name = "frmPhongBan";
            this.Text = "frmPhongBan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texttenphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkhuvuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewphongban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Button btnmophong;
    }
}