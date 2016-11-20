namespace PresentationTier.CongNo
{
    partial class frmXemThongTin
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
            this.btnNoNCC = new System.Windows.Forms.Button();
            this.btnNoKH = new System.Windows.Forms.Button();
            this.btnNoQuaHan = new System.Windows.Forms.Button();
            this.btnNoDaTra = new System.Windows.Forms.Button();
            this.btnNoToiHan = new System.Windows.Forms.Button();
            this.gbxThongTin = new System.Windows.Forms.GroupBox();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.gbxThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNoNCC
            // 
            this.btnNoNCC.Location = new System.Drawing.Point(31, 39);
            this.btnNoNCC.Name = "btnNoNCC";
            this.btnNoNCC.Size = new System.Drawing.Size(95, 76);
            this.btnNoNCC.TabIndex = 0;
            this.btnNoNCC.Text = "Xem thông tin nợ nhà cung cấp";
            this.btnNoNCC.UseVisualStyleBackColor = true;
            this.btnNoNCC.Click += new System.EventHandler(this.btnNoNCC_Click);
            // 
            // btnNoKH
            // 
            this.btnNoKH.Location = new System.Drawing.Point(166, 39);
            this.btnNoKH.Name = "btnNoKH";
            this.btnNoKH.Size = new System.Drawing.Size(95, 76);
            this.btnNoKH.TabIndex = 0;
            this.btnNoKH.Text = "Xem thông tin nợ khách hàng";
            this.btnNoKH.UseVisualStyleBackColor = true;
            this.btnNoKH.Click += new System.EventHandler(this.btnNoKH_Click);
            // 
            // btnNoQuaHan
            // 
            this.btnNoQuaHan.Location = new System.Drawing.Point(301, 39);
            this.btnNoQuaHan.Name = "btnNoQuaHan";
            this.btnNoQuaHan.Size = new System.Drawing.Size(95, 76);
            this.btnNoQuaHan.TabIndex = 0;
            this.btnNoQuaHan.Text = "Xem thông tin nợ quá hạn";
            this.btnNoQuaHan.UseVisualStyleBackColor = true;
            this.btnNoQuaHan.Click += new System.EventHandler(this.btnNoQuaHan_Click);
            // 
            // btnNoDaTra
            // 
            this.btnNoDaTra.Location = new System.Drawing.Point(436, 39);
            this.btnNoDaTra.Name = "btnNoDaTra";
            this.btnNoDaTra.Size = new System.Drawing.Size(95, 76);
            this.btnNoDaTra.TabIndex = 0;
            this.btnNoDaTra.Text = "Xem thông tin nợ đã trả";
            this.btnNoDaTra.UseVisualStyleBackColor = true;
            this.btnNoDaTra.Click += new System.EventHandler(this.btnNoDaTra_Click);
            // 
            // btnNoToiHan
            // 
            this.btnNoToiHan.Location = new System.Drawing.Point(571, 39);
            this.btnNoToiHan.Name = "btnNoToiHan";
            this.btnNoToiHan.Size = new System.Drawing.Size(95, 76);
            this.btnNoToiHan.TabIndex = 0;
            this.btnNoToiHan.Text = "Xem thông tin nợ tới hạn";
            this.btnNoToiHan.UseVisualStyleBackColor = true;
            this.btnNoToiHan.Click += new System.EventHandler(this.btnNoToiHan_Click);
            // 
            // gbxThongTin
            // 
            this.gbxThongTin.Controls.Add(this.dgvAll);
            this.gbxThongTin.Location = new System.Drawing.Point(12, 143);
            this.gbxThongTin.Name = "gbxThongTin";
            this.gbxThongTin.Size = new System.Drawing.Size(654, 302);
            this.gbxThongTin.TabIndex = 1;
            this.gbxThongTin.TabStop = false;
            this.gbxThongTin.Text = "Thông Tin";
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Location = new System.Drawing.Point(6, 29);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.Size = new System.Drawing.Size(642, 267);
            this.dgvAll.TabIndex = 0;
            // 
            // frmXemThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 451);
            this.Controls.Add(this.gbxThongTin);
            this.Controls.Add(this.btnNoToiHan);
            this.Controls.Add(this.btnNoDaTra);
            this.Controls.Add(this.btnNoQuaHan);
            this.Controls.Add(this.btnNoKH);
            this.Controls.Add(this.btnNoNCC);
            this.MaximizeBox = false;
            this.Name = "frmXemThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem thông tin";
            this.gbxThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoNCC;
        private System.Windows.Forms.Button btnNoKH;
        private System.Windows.Forms.Button btnNoQuaHan;
        private System.Windows.Forms.Button btnNoDaTra;
        private System.Windows.Forms.Button btnNoToiHan;
        private System.Windows.Forms.GroupBox gbxThongTin;
        private System.Windows.Forms.DataGridView dgvAll;
    }
}