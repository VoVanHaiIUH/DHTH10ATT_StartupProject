namespace PresentationTier.PhongKeHoach
{
    partial class FormQuanLyKhieuDeNghiNhapKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.trvpdnnk = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbhoadonncc = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtthongbaopdnnk = new System.Windows.Forms.TextBox();
            this.thempdnnk = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbkho = new System.Windows.Forms.ComboBox();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.mota = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtthongbaoctpdnnk = new System.Windows.Forms.TextBox();
            this.themctpdnnk = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbsp2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.slsp = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.xoa = new System.Windows.Forms.Button();
            this.drvchitiet = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietPhieuDNNKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPRHR_SolutionDataSet1 = new PresentationTier.SPRHR_SolutionDataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labeltenkho = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbsp1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.slspdn = new System.Windows.Forms.TextBox();
            this.slspcn = new System.Windows.Forms.TextBox();
            this.slspdv = new System.Windows.Forms.TextBox();
            this.slpdnnk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chiTietPhieuDNNKTableAdapter = new PresentationTier.SPRHR_SolutionDataSet1TableAdapters.ChiTietPhieuDNNKTableAdapter();
            this.sPRHR_SolutionDataSet2 = new PresentationTier.SPRHR_SolutionDataSet2();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamTableAdapter = new PresentationTier.SPRHR_SolutionDataSet2TableAdapters.SanPhamTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvchitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuDNNKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHR_SolutionDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHR_SolutionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trvpdnnk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbhoadonncc);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 498);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DS Phiếu DNNK";
            // 
            // trvpdnnk
            // 
            this.trvpdnnk.Location = new System.Drawing.Point(0, 58);
            this.trvpdnnk.Name = "trvpdnnk";
            this.trvpdnnk.Size = new System.Drawing.Size(151, 425);
            this.trvpdnnk.TabIndex = 1;
            this.trvpdnnk.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvpdnnk_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DS Hóa Đơn NCC";
            // 
            // cbhoadonncc
            // 
            this.cbhoadonncc.FormattingEnabled = true;
            this.cbhoadonncc.Location = new System.Drawing.Point(0, 16);
            this.cbhoadonncc.Name = "cbhoadonncc";
            this.cbhoadonncc.Size = new System.Drawing.Size(151, 21);
            this.cbhoadonncc.TabIndex = 1;
            this.cbhoadonncc.Text = "Chọn Hóa Đơn...";
            this.cbhoadonncc.SelectedIndexChanged += new System.EventHandler(this.cbhoadonncc_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.xoa);
            this.panel2.Controls.Add(this.drvchitiet);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(169, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 482);
            this.panel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Chi Tiết Phiếu DNNK";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtthongbaopdnnk);
            this.panel6.Controls.Add(this.thempdnnk);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.cbkho);
            this.panel6.Controls.Add(this.cbnhanvien);
            this.panel6.Controls.Add(this.mota);
            this.panel6.Location = new System.Drawing.Point(194, 171);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 311);
            this.panel6.TabIndex = 6;
            // 
            // txtthongbaopdnnk
            // 
            this.txtthongbaopdnnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthongbaopdnnk.ForeColor = System.Drawing.Color.Red;
            this.txtthongbaopdnnk.Location = new System.Drawing.Point(0, 203);
            this.txtthongbaopdnnk.Multiline = true;
            this.txtthongbaopdnnk.Name = "txtthongbaopdnnk";
            this.txtthongbaopdnnk.Size = new System.Drawing.Size(327, 99);
            this.txtthongbaopdnnk.TabIndex = 6;
            // 
            // thempdnnk
            // 
            this.thempdnnk.Location = new System.Drawing.Point(0, 164);
            this.thempdnnk.Name = "thempdnnk";
            this.thempdnnk.Size = new System.Drawing.Size(330, 33);
            this.thempdnnk.TabIndex = 5;
            this.thempdnnk.Text = "Thêm Phiếu DNNK";
            this.thempdnnk.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Mô Tả";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Mã Kho";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Mã Nhân Viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlText;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Thêm Phiếu DNNK";
            // 
            // cbkho
            // 
            this.cbkho.FormattingEnabled = true;
            this.cbkho.Location = new System.Drawing.Point(117, 78);
            this.cbkho.Name = "cbkho";
            this.cbkho.Size = new System.Drawing.Size(121, 21);
            this.cbkho.TabIndex = 3;
            this.cbkho.Text = "Chọn Kho...";
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(117, 47);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(121, 21);
            this.cbnhanvien.TabIndex = 3;
            this.cbnhanvien.Text = "Chọn Nhân Viên...";
            // 
            // mota
            // 
            this.mota.Location = new System.Drawing.Point(117, 109);
            this.mota.Multiline = true;
            this.mota.Name = "mota";
            this.mota.Size = new System.Drawing.Size(182, 35);
            this.mota.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtthongbaoctpdnnk);
            this.panel5.Controls.Add(this.themctpdnnk);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.cbsp2);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.slsp);
            this.panel5.Controls.Add(this.txtghichu);
            this.panel5.Location = new System.Drawing.Point(523, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(347, 311);
            this.panel5.TabIndex = 6;
            // 
            // txtthongbaoctpdnnk
            // 
            this.txtthongbaoctpdnnk.BackColor = System.Drawing.Color.White;
            this.txtthongbaoctpdnnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtthongbaoctpdnnk.ForeColor = System.Drawing.Color.Red;
            this.txtthongbaoctpdnnk.Location = new System.Drawing.Point(3, 203);
            this.txtthongbaoctpdnnk.Multiline = true;
            this.txtthongbaoctpdnnk.Name = "txtthongbaoctpdnnk";
            this.txtthongbaoctpdnnk.Size = new System.Drawing.Size(341, 99);
            this.txtthongbaoctpdnnk.TabIndex = 6;
            // 
            // themctpdnnk
            // 
            this.themctpdnnk.Location = new System.Drawing.Point(0, 164);
            this.themctpdnnk.Name = "themctpdnnk";
            this.themctpdnnk.Size = new System.Drawing.Size(347, 33);
            this.themctpdnnk.TabIndex = 5;
            this.themctpdnnk.Text = "Thêm Chi Tiết Phiếu DNNK";
            this.themctpdnnk.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Desktop;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Thêm Chi Tiết Phiếu DNNK";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(52, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Ghi Chú";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(52, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Số Lượng";
            // 
            // cbsp2
            // 
            this.cbsp2.FormattingEnabled = true;
            this.cbsp2.Location = new System.Drawing.Point(132, 47);
            this.cbsp2.Name = "cbsp2";
            this.cbsp2.Size = new System.Drawing.Size(121, 21);
            this.cbsp2.TabIndex = 3;
            this.cbsp2.Text = "Chọn Sản Phẩm...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Mã Sản Phẩm";
            // 
            // slsp
            // 
            this.slsp.Location = new System.Drawing.Point(131, 74);
            this.slsp.Name = "slsp";
            this.slsp.Size = new System.Drawing.Size(122, 20);
            this.slsp.TabIndex = 1;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(131, 102);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(171, 44);
            this.txtghichu.TabIndex = 1;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(765, 136);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(105, 29);
            this.xoa.TabIndex = 5;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            // 
            // drvchitiet
            // 
            this.drvchitiet.AutoGenerateColumns = false;
            this.drvchitiet.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.drvchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvchitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.TenSp,
            this.SoLuong,
            this.GhiChu});
            this.drvchitiet.DataSource = this.chiTietPhieuDNNKBindingSource;
            this.drvchitiet.Location = new System.Drawing.Point(194, 26);
            this.drvchitiet.Name = "drvchitiet";
            this.drvchitiet.Size = new System.Drawing.Size(679, 107);
            this.drvchitiet.TabIndex = 4;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // TenSp
            // 
            this.TenSp.DataPropertyName = "TenSp";
            this.TenSp.HeaderText = "Tên Sản Phẩm";
            this.TenSp.Name = "TenSp";
            this.TenSp.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 300;
            // 
            // chiTietPhieuDNNKBindingSource
            // 
            this.chiTietPhieuDNNKBindingSource.DataMember = "ChiTietPhieuDNNK";
            this.chiTietPhieuDNNKBindingSource.DataSource = this.sPRHR_SolutionDataSet1;
            // 
            // sPRHR_SolutionDataSet1
            // 
            this.sPRHR_SolutionDataSet1.DataSetName = "SPRHR_SolutionDataSet1";
            this.sPRHR_SolutionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cbsp1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.slspdn);
            this.panel3.Controls.Add(this.slspcn);
            this.panel3.Controls.Add(this.slspdv);
            this.panel3.Controls.Add(this.slpdnnk);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 479);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labeltenkho);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(3, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 183);
            this.panel4.TabIndex = 5;
            // 
            // labeltenkho
            // 
            this.labeltenkho.BackColor = System.Drawing.SystemColors.Info;
            this.labeltenkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltenkho.ForeColor = System.Drawing.Color.Red;
            this.labeltenkho.Location = new System.Drawing.Point(0, 65);
            this.labeltenkho.Name = "labeltenkho";
            this.labeltenkho.Size = new System.Drawing.Size(179, 103);
            this.labeltenkho.TabIndex = 4;
            this.labeltenkho.Text = "                TenKho";
            this.labeltenkho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Thuộc Kho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số lượng sản phẩm đã nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số lượng sản phẩm chưa nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượng sản phẩm đưa về";
            // 
            // cbsp1
            // 
            this.cbsp1.FormattingEnabled = true;
            this.cbsp1.Location = new System.Drawing.Point(7, 74);
            this.cbsp1.Name = "cbsp1";
            this.cbsp1.Size = new System.Drawing.Size(121, 21);
            this.cbsp1.TabIndex = 3;
            this.cbsp1.Text = "Chọn Sản Phẩm...";
            this.cbsp1.SelectedIndexChanged += new System.EventHandler(this.cbsp1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng phiếu DNNK cho hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chọn Sản Phẩm";
            // 
            // slspdn
            // 
            this.slspdn.Location = new System.Drawing.Point(6, 270);
            this.slspdn.Name = "slspdn";
            this.slspdn.Size = new System.Drawing.Size(122, 20);
            this.slspdn.TabIndex = 1;
            // 
            // slspcn
            // 
            this.slspcn.Location = new System.Drawing.Point(7, 202);
            this.slspcn.Name = "slspcn";
            this.slspcn.Size = new System.Drawing.Size(122, 20);
            this.slspcn.TabIndex = 1;
            // 
            // slspdv
            // 
            this.slspdv.Location = new System.Drawing.Point(6, 133);
            this.slspdv.Name = "slspdv";
            this.slspdv.Size = new System.Drawing.Size(122, 20);
            this.slspdv.TabIndex = 1;
            // 
            // slpdnnk
            // 
            this.slpdnnk.Location = new System.Drawing.Point(6, 23);
            this.slpdnnk.Name = "slpdnnk";
            this.slpdnnk.Size = new System.Drawing.Size(173, 20);
            this.slpdnnk.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quản Lý Phiếu DNNK Cho Hóa Đơn";
            // 
            // chiTietPhieuDNNKTableAdapter
            // 
            this.chiTietPhieuDNNKTableAdapter.ClearBeforeFill = true;
            // 
            // sPRHR_SolutionDataSet2
            // 
            this.sPRHR_SolutionDataSet2.DataSetName = "SPRHR_SolutionDataSet2";
            this.sPRHR_SolutionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.sPRHR_SolutionDataSet2;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // FormQuanLyKhieuDeNghiNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormQuanLyKhieuDeNghiNhapKho";
            this.Text = "QuanLyKhieuDeNghiNhapKho";
            this.Load += new System.EventHandler(this.FormQuanLyKhieuDeNghiNhapKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvchitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietPhieuDNNKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHR_SolutionDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPRHR_SolutionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbhoadonncc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView trvpdnnk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.DataGridView drvchitiet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labeltenkho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbsp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox slspdn;
        private System.Windows.Forms.TextBox slspcn;
        private System.Windows.Forms.TextBox slspdv;
        private System.Windows.Forms.TextBox slpdnnk;
        private System.Windows.Forms.Label label3;
        private SPRHR_SolutionDataSet1 sPRHR_SolutionDataSet1;
        private System.Windows.Forms.BindingSource chiTietPhieuDNNKBindingSource;
        private SPRHR_SolutionDataSet1TableAdapters.ChiTietPhieuDNNKTableAdapter chiTietPhieuDNNKTableAdapter;
        private SPRHR_SolutionDataSet2 sPRHR_SolutionDataSet2;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private SPRHR_SolutionDataSet2TableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txtthongbaopdnnk;
        private System.Windows.Forms.Button thempdnnk;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbkho;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.TextBox mota;
        private System.Windows.Forms.TextBox txtthongbaoctpdnnk;
        private System.Windows.Forms.Button themctpdnnk;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbsp2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox slsp;
        private System.Windows.Forms.TextBox txtghichu;
    }
}