namespace SPRHR_CommunicationManagement
{
    partial class FormMain_Communication
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
            this.btnSendPhieuDNXK = new System.Windows.Forms.Button();
            this.btnSendPhieuDNNK = new System.Windows.Forms.Button();
            this.btnThongBaoChung = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phòng Kế Hoạch";
            // 
            // btnSendPhieuDNXK
            // 
            this.btnSendPhieuDNXK.Location = new System.Drawing.Point(33, 98);
            this.btnSendPhieuDNXK.Name = "btnSendPhieuDNXK";
            this.btnSendPhieuDNXK.Size = new System.Drawing.Size(139, 35);
            this.btnSendPhieuDNXK.TabIndex = 7;
            this.btnSendPhieuDNXK.Text = "Gửi phiếu đề nghị xuất kho";
            this.btnSendPhieuDNXK.UseVisualStyleBackColor = true;
            this.btnSendPhieuDNXK.Click += new System.EventHandler(this.btnSendPhieuDNXK_Click);
            // 
            // btnSendPhieuDNNK
            // 
            this.btnSendPhieuDNNK.Location = new System.Drawing.Point(33, 39);
            this.btnSendPhieuDNNK.Name = "btnSendPhieuDNNK";
            this.btnSendPhieuDNNK.Size = new System.Drawing.Size(139, 35);
            this.btnSendPhieuDNNK.TabIndex = 6;
            this.btnSendPhieuDNNK.Text = "Gửi phiếu đề nghị nhập kho";
            this.btnSendPhieuDNNK.UseVisualStyleBackColor = true;
            this.btnSendPhieuDNNK.Click += new System.EventHandler(this.btnSendPhieuDNNK_Click);
            // 
            // btnThongBaoChung
            // 
            this.btnThongBaoChung.Location = new System.Drawing.Point(36, 39);
            this.btnThongBaoChung.Name = "btnThongBaoChung";
            this.btnThongBaoChung.Size = new System.Drawing.Size(139, 35);
            this.btnThongBaoChung.TabIndex = 9;
            this.btnThongBaoChung.Text = "Gửi thông báo chung đến các phòng";
            this.btnThongBaoChung.UseVisualStyleBackColor = true;
            this.btnThongBaoChung.Click += new System.EventHandler(this.btnThongBaoChung_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendPhieuDNNK);
            this.groupBox1.Controls.Add(this.btnSendPhieuDNXK);
            this.groupBox1.Location = new System.Drawing.Point(98, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 218);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gửi phiếu đề nghị xuống kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThongBaoChung);
            this.groupBox2.Location = new System.Drawing.Point(356, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 218);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giao tiếp với các phòng khác";
            // 
            // FormMain_Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormMain_Communication";
            this.Text = "Khung quản lý chính của phòng kế hoạch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Communication_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendPhieuDNXK;
        private System.Windows.Forms.Button btnSendPhieuDNNK;
        private System.Windows.Forms.Button btnThongBaoChung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

