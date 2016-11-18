using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.PhongKeHoach;
using BusinessEntities.NhanSu;
using BusinessEntities.Kho;
using BusinessLogicTier.PhongKeHoach.SanPham;
using BusinessLogicTier.PhongKeHoach.PhieuDeNghiNhapKho;
using BusinessLogicTier.PhongKeHoach.HoaDonPhiaNhaCungCap;
using System.Text.RegularExpressions;

namespace PresentationTier.PhongKeHoach
{
    public partial class FormQuanLyKhieuDeNghiNhapKho : Form
    {
        SanPham_BUL sp = new SanPham_BUL();
        LapPhieuDNNK_BUL dnnk = new LapPhieuDNNK_BUL();
        LapHoaDonNhaCC_BUL hd = new LapHoaDonNhaCC_BUL();
        List<eNhanVien> lsnv = new List<eNhanVien>();
        List<eThongTinKho> lsttk = new List<eThongTinKho>();
        List<eHoaDonNhaCungCap> lshdncc = new List<eHoaDonNhaCungCap>();
        List<ePhieuDeNghiNhapKho> lsdnnk = new List<ePhieuDeNghiNhapKho>();
        List<eChiTietPhieuDeNghiNhapKho> lsctnk = new List<eChiTietPhieuDeNghiNhapKho>();
        List<eSanPham> lssp = new List<eSanPham>();
        private BindingSource Sr;
        public FormQuanLyKhieuDeNghiNhapKho()
        {
            InitializeComponent();
            loadcbMahoadon();
        }
        private void loadcbMahoadon()
        {
            lshdncc = hd.GetAllHoaDonNCC();
            cbhoadonncc.DataSource = lshdncc;
            cbhoadonncc.DisplayMember = "MaHoaDonNCC";
            cbhoadonncc.ValueMember = "MaHoaDonNCC";
        }
        private void loadtreeview()
        {
            trvpdnnk.Nodes.Clear();
            lsdnnk = dnnk.LayHetThongTinPDNNKTheoMaHDNhaCC(cbhoadonncc.SelectedValue.ToString());
            foreach (ePhieuDeNghiNhapKho e in lsdnnk)
            {
                TreeNode tn = new TreeNode(e.SoPhieuDeNghiNhapKho);
                trvpdnnk.Nodes.Add(tn);
            }

        }
        private void updatetextboxSlPhieu()
        {
            slpdnnk.Clear();
            lsdnnk = dnnk.LayHetThongTinPDNNKTheoMaHDNhaCC(cbhoadonncc.SelectedValue.ToString());
            if (lsdnnk.Count() == 0)
            {
                MessageBox.Show("Hóa Đơn chưa Có PDNNK");
            }
            else
            {
                slpdnnk.Text = lsdnnk.Count().ToString();
            }
        }
        private void updatecbsp1()
        {
            cbsp1.Items.Clear();
            lssp = sp.GetALLSpTrongHD(cbhoadonncc.SelectedValue.ToString());
            foreach (eSanPham e in lssp)
            {
                cbsp1.Items.Add(e);
                cbsp1.DisplayMember = e.TenSP;
                cbsp1.ValueMember = e.MaSP;
            }
        }
       
        private void updatesoluongsanphamcannhap()
        {
            slspdv.Clear();
            slspdv.Text = sp.GetSoLuongbyOneSanPham(cbhoadonncc.SelectedValue.ToString(), cbsp1.SelectedValue.ToString()).ToString();
        }
        private void updatetextsoluongspdanhap()
        {
            slspdn.Clear();
            slspdn.Text = sp.GetSoLuong1SpDaNhap(cbhoadonncc.SelectedValue.ToString(), cbsp1.SelectedValue.ToString()).ToString();
        }
        private void updatetextsoluongspchuanhap()
        {
            try
            {
                slspcn.Clear();
                if (slspdn.Text == null || slspdv == null)
                {
                    throw new Exception("Missing SomeThing  ???");
                }
                if (Convert.ToInt32(slspcn.Text) == 0)
                {
                    MessageBox.Show("Sản Phẩm Này Đã Nhập đủ Hàng");
                }
                else
                {
                    slspcn.Text = (Convert.ToInt32(slspdv.Text) - Convert.ToInt32(slspdn.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
        }
        private void LoaddatagridviewPDNNK()
        {
            Sr = new BindingSource();
            lsctnk = dnnk.LayHetThongTinChiTietPDNNKTheoMaPhieu(trvpdnnk.SelectedNode.Text);
            Sr.DataSource = lsctnk;
            drvchitiet.DataSource = Sr;
        }
        private void FormQuanLyKhieuDeNghiNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPRHR_SolutionDataSet2.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sPRHR_SolutionDataSet2.SanPham);
            // TODO: This line of code loads data into the 'sPRHR_SolutionDataSet1.ChiTietPhieuDNNK' table. You can move, or remove it, as needed.
            this.chiTietPhieuDNNKTableAdapter.Fill(this.sPRHR_SolutionDataSet1.ChiTietPhieuDNNK);
        }
        private void UpdateLabelKho()
        {
            labeltenkho.Text = "";
            lsdnnk = dnnk.LayThongTinPDNNKTheoMa(trvpdnnk.SelectedNode.Text);
            foreach(ePhieuDeNghiNhapKho e in lsdnnk)
            {
                labeltenkho.Text = e.MaKho;
            }
        }
        private void trvpdnnk_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoaddatagridviewPDNNK();
            UpdateLabelKho();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbhoadonncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtreeview();
            updatetextboxSlPhieu();
            updatecbsp1();
        }

        private void cbsp1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            updatetextsoluongspdanhap();
            updatesoluongsanphamcannhap();
            updatetextsoluongspchuanhap();
        }

        private void thempdnnk_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbhoadonncc.SelectedValue == null || cbnhanvien.SelectedValue == null || cbkho.SelectedValue == null)
                {
                    MessageBox.Show("Trừ Mô Tả Các Loại Chọn Không Được Để Null");
                }
                else
                {
                    ePhieuDeNghiNhapKho phieu = new ePhieuDeNghiNhapKho();
                    phieu.MaHoaDonNhaCungCap = cbhoadonncc.SelectedValue.ToString();
                    phieu.MaKho = cbkho.SelectedValue.ToString();
                    phieu.MaNhanVien = cbnhanvien.SelectedValue.ToString();
                    phieu.MoTa = mota.Text;
                    dnnk.ThemPDNNK(phieu);
                    MessageBox.Show("Inserted");
                    loadtreeview();
                    updatetextboxSlPhieu();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
            
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                dnnk.XoaCTPDNNK(trvpdnnk.SelectedNode.Text, drvchitiet.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Deleted");
                LoaddatagridviewPDNNK();
                // lấy lại thông tin số lượng sản phẩm
                updatetextsoluongspdanhap();
                updatesoluongsanphamcannhap();
                updatetextsoluongspchuanhap();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
            
        }

        private void themctpdnnk_Click(object sender, EventArgs e)
        {
            string s = @"^\d+$";
            bool c = Regex.Match(slsp.Text, s).Success;
            try
            {
                if(cbsp1.SelectedValue == null || slsp.Text == null || trvpdnnk.SelectedNode.Tag.ToString() == null)
                {
                    MessageBox.Show("Trừ Ghi Chú Ra Các Thông Tin Cần Nhập Cần Phải nhập");
                }
                else if(!c)
                {
                    MessageBox.Show("Sai định dạng số lượng");
                    slsp.Clear();
                }
                else if(Convert.ToInt32(slsp.Text) <= 0 || Convert.ToInt32(slsp.Text) > Convert.ToInt32(slspdv.Text))
                {
                    MessageBox.Show("Error: Không Xác Định");
                    slsp.Clear();
                }
                else
                {
                    eChiTietPhieuDeNghiNhapKho ct = new eChiTietPhieuDeNghiNhapKho();
                    ct.MaSP = cbsp1.SelectedValue.ToString();
                    ct.SoPDNNK = trvpdnnk.SelectedNode.Text;
                    ct.SoLuong = Convert.ToInt32(slsp.Text);
                    ct.GhiChu = txtghichu.Text;
                    dnnk.ThemCTPDNNK(ct);
                    LoaddatagridviewPDNNK();
                    updatetextsoluongspdanhap();
                    updatesoluongsanphamcannhap();
                    updatetextsoluongspchuanhap();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString());
            }
        }
    }
}
