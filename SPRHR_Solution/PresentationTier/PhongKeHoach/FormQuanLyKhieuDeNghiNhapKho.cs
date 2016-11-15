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
        private void updatecbsp2()
        {
            cbsp2.Items.Clear();
            lssp = sp.GetALLSpTrongHD(cbhoadonncc.SelectedValue.ToString());
            foreach (eSanPham e in lssp)
            {
                cbsp2.Items.Add(e);
                cbsp2.DisplayMember = e.TenSP;
                cbsp2.ValueMember = e.MaSP;
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
            slspcn.Text = sp.GetSoLuong1SpDaNhap(cbhoadonncc.SelectedValue.ToString(), cbsp1.SelectedValue.ToString()).ToString();
        }
        private void FormQuanLyKhieuDeNghiNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPRHR_SolutionDataSet2.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sPRHR_SolutionDataSet2.SanPham);
            // TODO: This line of code loads data into the 'sPRHR_SolutionDataSet1.ChiTietPhieuDNNK' table. You can move, or remove it, as needed.
            this.chiTietPhieuDNNKTableAdapter.Fill(this.sPRHR_SolutionDataSet1.ChiTietPhieuDNNK);
        }

        private void trvpdnnk_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbhoadonncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtreeview();
            updatetextboxSlPhieu();
            updatecbsp1();
            updatecbsp2();
        }

        private void cbsp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatetextsoluongspdanhap();
            updatesoluongsanphamcannhap();
        }
    }
}
