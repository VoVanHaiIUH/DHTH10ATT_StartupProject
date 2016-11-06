namespace PresentationTier.NhanSu
{
    partial class frmThuyenChuyen
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
            this.comboBoxtenphong = new System.Windows.Forms.ComboBox();
            this.bntxacnhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng ban:";
            // 
            // comboBoxtenphong
            // 
            this.comboBoxtenphong.FormattingEnabled = true;
            this.comboBoxtenphong.Location = new System.Drawing.Point(95, 12);
            this.comboBoxtenphong.Name = "comboBoxtenphong";
            this.comboBoxtenphong.Size = new System.Drawing.Size(169, 21);
            this.comboBoxtenphong.TabIndex = 1;
            // 
            // bntxacnhan
            // 
            this.bntxacnhan.Location = new System.Drawing.Point(270, 10);
            this.bntxacnhan.Name = "bntxacnhan";
            this.bntxacnhan.Size = new System.Drawing.Size(75, 23);
            this.bntxacnhan.TabIndex = 5;
            this.bntxacnhan.Text = "Xác nhận";
            this.bntxacnhan.UseVisualStyleBackColor = true;
            // 
            // frmThuyenChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 55);
            this.Controls.Add(this.bntxacnhan);
            this.Controls.Add(this.comboBoxtenphong);
            this.Controls.Add(this.label1);
            this.Name = "frmThuyenChuyen";
            this.Text = "frmThuyenChuyen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxtenphong;
        private System.Windows.Forms.Button bntxacnhan;
    }
}