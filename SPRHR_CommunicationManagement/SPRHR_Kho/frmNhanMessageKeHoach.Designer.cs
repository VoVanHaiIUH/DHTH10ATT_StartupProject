﻿namespace SPRHR_Kho
{
    partial class frmNhanMessageKeHoach
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
            this.rtxtMessage = new System.Windows.Forms.RichTextBox();
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
            this.groupBox1.TabIndex = 7;
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
            this.txtSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.txtSend.Location = new System.Drawing.Point(314, 19);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(75, 44);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "Gửi";
            this.txtSend.UseVisualStyleBackColor = true;
            this.txtSend.Click += new System.EventHandler(this.txtSend_Click);
            // 
            // rtxtMessage
            // 
            this.rtxtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtMessage.Location = new System.Drawing.Point(13, 11);
            this.rtxtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtMessage.Name = "rtxtMessage";
            this.rtxtMessage.ReadOnly = true;
            this.rtxtMessage.Size = new System.Drawing.Size(397, 197);
            this.rtxtMessage.TabIndex = 8;
            this.rtxtMessage.Text = "";
            // 
            // frmNhanMessageKeHoach
            // 
            this.AcceptButton = this.txtSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 321);
            this.Controls.Add(this.rtxtMessage);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhanMessageKeHoach";
            this.Text = "Khung nhận tin nhắn của Kho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanMessageKeHoach_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGuiThongDiep;
        private System.Windows.Forms.Button txtSend;
        private System.Windows.Forms.RichTextBox rtxtMessage;
    }
}