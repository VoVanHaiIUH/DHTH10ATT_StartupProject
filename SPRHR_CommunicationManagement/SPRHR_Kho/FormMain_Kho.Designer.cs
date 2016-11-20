namespace SPRHR_Kho
{
    partial class FormMain_Kho
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceivePhieuDNXK = new System.Windows.Forms.Button();
            this.btnReceivePhieuDNNK = new System.Windows.Forms.Button();
            this.PushNotification = new System.Windows.Forms.NotifyIcon(this.components);
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
            this.label1.Location = new System.Drawing.Point(206, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quản Lý Kho";
            // 
            // btnReceivePhieuDNXK
            // 
            this.btnReceivePhieuDNXK.Location = new System.Drawing.Point(27, 105);
            this.btnReceivePhieuDNXK.Name = "btnReceivePhieuDNXK";
            this.btnReceivePhieuDNXK.Size = new System.Drawing.Size(139, 35);
            this.btnReceivePhieuDNXK.TabIndex = 16;
            this.btnReceivePhieuDNXK.Text = "Nhận phiếu đề nghị xuất kho";
            this.btnReceivePhieuDNXK.UseVisualStyleBackColor = true;
            this.btnReceivePhieuDNXK.Click += new System.EventHandler(this.btnReceivePhieuDNXK_Click);
            // 
            // btnReceivePhieuDNNK
            // 
            this.btnReceivePhieuDNNK.Location = new System.Drawing.Point(27, 35);
            this.btnReceivePhieuDNNK.Name = "btnReceivePhieuDNNK";
            this.btnReceivePhieuDNNK.Size = new System.Drawing.Size(139, 35);
            this.btnReceivePhieuDNNK.TabIndex = 15;
            this.btnReceivePhieuDNNK.Text = "Nhận phiếu đề nghị nhập kho";
            this.btnReceivePhieuDNNK.UseVisualStyleBackColor = true;
            this.btnReceivePhieuDNNK.Click += new System.EventHandler(this.btnReceivePhieuDNNK_Click);
            // 
            // PushNotification
            // 
            this.PushNotification.Visible = true;
            // 
            // btnThongBaoChung
            // 
            this.btnThongBaoChung.Location = new System.Drawing.Point(21, 26);
            this.btnThongBaoChung.Name = "btnThongBaoChung";
            this.btnThongBaoChung.Size = new System.Drawing.Size(139, 35);
            this.btnThongBaoChung.TabIndex = 18;
            this.btnThongBaoChung.Text = "Nhận thông báo từ các phòng";
            this.btnThongBaoChung.UseVisualStyleBackColor = true;
            this.btnThongBaoChung.Click += new System.EventHandler(this.btnThongBaoChung_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReceivePhieuDNNK);
            this.groupBox1.Controls.Add(this.btnReceivePhieuDNXK);
            this.groupBox1.Location = new System.Drawing.Point(62, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 207);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhận phiếu từ phòng kế hoạch";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThongBaoChung);
            this.groupBox2.Location = new System.Drawing.Point(322, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 198);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giao tiếp với các phòng khác";
            // 
            // FormMain_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormMain_Kho";
            this.Text = "Màn Hình Chính Kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_Kho_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceivePhieuDNXK;
        private System.Windows.Forms.Button btnReceivePhieuDNNK;
        private System.Windows.Forms.NotifyIcon PushNotification;
        private System.Windows.Forms.Button btnThongBaoChung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

