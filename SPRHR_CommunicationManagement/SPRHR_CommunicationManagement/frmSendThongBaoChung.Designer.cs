namespace SPRHR_CommunicationManagement
{
    partial class frmSendThongBaoChung
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
            this.txtGuiThongDiep = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGuiThongDiep);
            this.groupBox1.Controls.Add(this.txtSend);
            this.groupBox1.Location = new System.Drawing.Point(13, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông điệp ";
            // 
            // txtGuiThongDiep
            // 
            this.txtGuiThongDiep.Location = new System.Drawing.Point(18, 19);
            this.txtGuiThongDiep.Multiline = true;
            this.txtGuiThongDiep.Name = "txtGuiThongDiep";
            this.txtGuiThongDiep.Size = new System.Drawing.Size(290, 44);
            this.txtGuiThongDiep.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(314, 19);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(75, 44);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "Gửi";
            this.txtSend.UseVisualStyleBackColor = true;
            this.txtSend.Click += new System.EventHandler(this.txtSend_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 11);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(391, 197);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // frmSendThongBaoChung
            // 
            this.AcceptButton = this.txtSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmSendThongBaoChung";
            this.Text = "Khung gửi tin nhắn của Kế Hoạch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSendThongBaoChung_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtSend;
        private System.Windows.Forms.TextBox txtGuiThongDiep;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}