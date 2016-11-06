namespace PresentationTier.PhongKeHoach
{
    partial class LapKeHoach
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
            this.DrvKH = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.moc2 = new System.Windows.Forms.DateTimePicker();
            this.moc1 = new System.Windows.Forms.DateTimePicker();
            this.view = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eKeHoachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePhieuDeNghiNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eCuaHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePhieuDeNghiXuatKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLHangMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLHangBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DrvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eKeHoachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePhieuDeNghiNhapKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCuaHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePhieuDeNghiXuatKhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DrvKH
            // 
            this.DrvKH.AutoGenerateColumns = false;
            this.DrvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.SLHangMua,
            this.SLHangBan,
            this.KeHoach});
            this.DrvKH.DataSource = this.eKeHoachBindingSource;
            this.DrvKH.Location = new System.Drawing.Point(12, 76);
            this.DrvKH.Name = "DrvKH";
            this.DrvKH.Size = new System.Drawing.Size(423, 109);
            this.DrvKH.TabIndex = 0;
            this.DrvKH.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(203, 462);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // moc2
            // 
            this.moc2.Location = new System.Drawing.Point(304, 29);
            this.moc2.Name = "moc2";
            this.moc2.Size = new System.Drawing.Size(133, 20);
            this.moc2.TabIndex = 2;
            // 
            // moc1
            // 
            this.moc1.Location = new System.Drawing.Point(304, 3);
            this.moc1.Name = "moc1";
            this.moc1.Size = new System.Drawing.Size(133, 20);
            this.moc1.TabIndex = 3;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(362, 191);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 5;
            this.view.Text = "Hiện Thị";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(330, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn Mốc Thời Gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mốc 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mốc 2";
            // 
            // eKeHoachBindingSource
            // 
            this.eKeHoachBindingSource.DataSource = typeof(BusinessEntities.PhongKeHoach.eKeHoach);
            // 
            // ePhieuDeNghiNhapKhoBindingSource
            // 
            this.ePhieuDeNghiNhapKhoBindingSource.DataSource = typeof(BusinessEntities.PhongKeHoach.ePhieuDeNghiNhapKho);
            // 
            // eCuaHangBindingSource
            // 
            this.eCuaHangBindingSource.DataSource = typeof(BusinessEntities.PhongKeHoach.eCuaHang);
            // 
            // ePhieuDeNghiXuatKhoBindingSource
            // 
            this.ePhieuDeNghiXuatKhoBindingSource.DataSource = typeof(BusinessEntities.PhongKeHoach.ePhieuDeNghiXuatKho);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // SLHangMua
            // 
            this.SLHangMua.DataPropertyName = "SLHangMua";
            this.SLHangMua.HeaderText = "SLHangMua";
            this.SLHangMua.Name = "SLHangMua";
            // 
            // SLHangBan
            // 
            this.SLHangBan.DataPropertyName = "SLHangBan";
            this.SLHangBan.HeaderText = "SLHangBan";
            this.SLHangBan.Name = "SLHangBan";
            // 
            // KeHoach
            // 
            this.KeHoach.DataPropertyName = "KeHoach";
            this.KeHoach.HeaderText = "KeHoach";
            this.KeHoach.Name = "KeHoach";
            // 
            // LapKeHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.moc1);
            this.Controls.Add(this.moc2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DrvKH);
            this.Name = "LapKeHoach";
            this.Text = "Lập Kế Hoạch";
            this.Load += new System.EventHandler(this.LapKeHoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eKeHoachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePhieuDeNghiNhapKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eCuaHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePhieuDeNghiXuatKhoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DrvKH;
        private System.Windows.Forms.BindingSource eKeHoachBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker moc2;
        private System.Windows.Forms.DateTimePicker moc1;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ePhieuDeNghiNhapKhoBindingSource;
        private System.Windows.Forms.BindingSource eCuaHangBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLHangMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLHangBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeHoach;
        private System.Windows.Forms.BindingSource ePhieuDeNghiXuatKhoBindingSource;
    }
}