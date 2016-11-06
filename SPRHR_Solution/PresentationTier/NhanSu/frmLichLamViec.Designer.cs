namespace PresentationTier.NhanSu
{
    partial class frmLichLamViec
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
            this.listViewlichlamviec = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxcalam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxghichu = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntrove = new System.Windows.Forms.Button();
            this.btnsualich = new System.Windows.Forms.Button();
            this.btnluulich = new System.Windows.Forms.Button();
            this.btnthemlich = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewlichlamviec);
            this.groupBox1.Location = new System.Drawing.Point(1, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lịch làm việc";
            // 
            // listViewlichlamviec
            // 
            this.listViewlichlamviec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewlichlamviec.Location = new System.Drawing.Point(6, 19);
            this.listViewlichlamviec.Name = "listViewlichlamviec";
            this.listViewlichlamviec.Size = new System.Drawing.Size(125, 160);
            this.listViewlichlamviec.TabIndex = 0;
            this.listViewlichlamviec.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "DANH SÁCH LỊCH LÀM VIỆC";
            // 
            // comboBoxcalam
            // 
            this.comboBoxcalam.FormattingEnabled = true;
            this.comboBoxcalam.Location = new System.Drawing.Point(82, 19);
            this.comboBoxcalam.Name = "comboBoxcalam";
            this.comboBoxcalam.Size = new System.Drawing.Size(200, 21);
            this.comboBoxcalam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ca làm việc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giờ bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giờ kết thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ghi chú:";
            // 
            // dateTimePickerngayketthuc
            // 
            this.dateTimePickerngayketthuc.Location = new System.Drawing.Point(82, 71);
            this.dateTimePickerngayketthuc.Name = "dateTimePickerngayketthuc";
            this.dateTimePickerngayketthuc.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerngayketthuc.TabIndex = 2;
            // 
            // richTextBoxghichu
            // 
            this.richTextBoxghichu.Location = new System.Drawing.Point(82, 95);
            this.richTextBoxghichu.Name = "richTextBoxghichu";
            this.richTextBoxghichu.Size = new System.Drawing.Size(200, 40);
            this.richTextBoxghichu.TabIndex = 3;
            this.richTextBoxghichu.Text = "";
            // 
            // dateTimePickerngaybatdau
            // 
            this.dateTimePickerngaybatdau.Location = new System.Drawing.Point(82, 45);
            this.dateTimePickerngaybatdau.Name = "dateTimePickerngaybatdau";
            this.dateTimePickerngaybatdau.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerngaybatdau.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxcalam);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePickerngayketthuc);
            this.groupBox2.Controls.Add(this.richTextBoxghichu);
            this.groupBox2.Controls.Add(this.dateTimePickerngaybatdau);
            this.groupBox2.Location = new System.Drawing.Point(144, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 148);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(384, 207);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 23);
            this.btntrove.TabIndex = 3;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            // 
            // btnsualich
            // 
            this.btnsualich.Location = new System.Drawing.Point(303, 207);
            this.btnsualich.Name = "btnsualich";
            this.btnsualich.Size = new System.Drawing.Size(75, 23);
            this.btnsualich.TabIndex = 2;
            this.btnsualich.Text = "Sửa lịch";
            this.btnsualich.UseVisualStyleBackColor = true;
            // 
            // btnluulich
            // 
            this.btnluulich.Location = new System.Drawing.Point(226, 207);
            this.btnluulich.Name = "btnluulich";
            this.btnluulich.Size = new System.Drawing.Size(75, 23);
            this.btnluulich.TabIndex = 1;
            this.btnluulich.Text = "Lưu lịch";
            this.btnluulich.UseVisualStyleBackColor = true;
            // 
            // btnthemlich
            // 
            this.btnthemlich.Location = new System.Drawing.Point(145, 207);
            this.btnthemlich.Name = "btnthemlich";
            this.btnthemlich.Size = new System.Drawing.Size(75, 23);
            this.btnthemlich.TabIndex = 0;
            this.btnthemlich.Text = "Thêm lịch";
            this.btnthemlich.UseVisualStyleBackColor = true;
            // 
            // frmLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(463, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnsualich);
            this.Controls.Add(this.btnluulich);
            this.Controls.Add(this.btnthemlich);
            this.Name = "frmLichLamViec";
            this.Text = "frmLichLamViec";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewlichlamviec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxcalam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerngayketthuc;
        private System.Windows.Forms.RichTextBox richTextBoxghichu;
        private System.Windows.Forms.DateTimePicker dateTimePickerngaybatdau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.Button btnsualich;
        private System.Windows.Forms.Button btnluulich;
        private System.Windows.Forms.Button btnthemlich;
    }
}