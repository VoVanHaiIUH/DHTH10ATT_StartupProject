namespace PresentationTier.NhanSu
{
    partial class frmKyLuat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewchucvu = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxmota = new System.Windows.Forms.RichTextBox();
            this.txttenchucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntrove = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "DANH SÁCH KỶ LUẬT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewchucvu);
            this.groupBox2.Location = new System.Drawing.Point(1, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 206);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức vụ";
            // 
            // listViewchucvu
            // 
            this.listViewchucvu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewchucvu.Location = new System.Drawing.Point(0, 19);
            this.listViewchucvu.Name = "listViewchucvu";
            this.listViewchucvu.Size = new System.Drawing.Size(121, 181);
            this.listViewchucvu.TabIndex = 0;
            this.listViewchucvu.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxmota);
            this.groupBox1.Controls.Add(this.txttenchucvu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(136, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 107);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // richTextBoxmota
            // 
            this.richTextBoxmota.Location = new System.Drawing.Point(99, 46);
            this.richTextBoxmota.Name = "richTextBoxmota";
            this.richTextBoxmota.Size = new System.Drawing.Size(206, 45);
            this.richTextBoxmota.TabIndex = 1;
            this.richTextBoxmota.Text = "";
            // 
            // txttenchucvu
            // 
            this.txttenchucvu.Location = new System.Drawing.Point(99, 20);
            this.txttenchucvu.Name = "txttenchucvu";
            this.txttenchucvu.Size = new System.Drawing.Size(206, 20);
            this.txttenchucvu.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hình thức kỷ luật:";
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(373, 186);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 23);
            this.btntrove.TabIndex = 3;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(292, 186);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(215, 186);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 1;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(134, 186);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // frmKyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(453, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Name = "frmKyLuat";
            this.Text = "frmKyLuat";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewchucvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxmota;
        private System.Windows.Forms.TextBox txttenchucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
    }
}