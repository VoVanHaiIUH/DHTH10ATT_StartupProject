using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.Kho;
using BusinessLogicTier.Kho;

namespace PresentationTier.Kho
{
    public partial class frmPhieuNhapKho : Form
    {
        List<ePhieuNhapKho> ePN;
        PhieuNhapKho_BUS pnkBUS;
        public frmPhieuNhapKho()
        {
            InitializeComponent();
            ePN = new List<ePhieuNhapKho>();
            pnkBUS = new PhieuNhapKho_BUS();
        }

        private void frmPhieuNhapKho_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTreeView(); 
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void LoadTreeView()
        {
            try
            {
                tvDSPDN.Nodes.Clear();
                foreach (BusinessEntities.PhongKeHoach.ePhieuDeNghiNhapKho epdn in pnkBUS.GetPDNNK())
                {
                    TreeNode tn = new TreeNode();
                    tn.Tag = epdn.SoPhieuDeNghiNhapKho;
                    tn.Text = "Số phiếu: " + epdn.SoPhieuDeNghiNhapKho;

                    TreeNode tnNgay = new TreeNode();
                    tnNgay.Text = "Ngày: " + epdn.NgayLap.ToShortDateString();
                    TreeNode tnKho = new TreeNode();
                    tnKho.Tag = epdn.MaKho;
                    tnKho.Text = "Mã kho: " + epdn.MaKho;

                    tn.Nodes.Add(tnNgay);
                    tn.Nodes.Add(tnKho);
                    tvDSPDN.Nodes.Add(tn);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm Phiếu Nhập Kho")
            {
                TreeNode tn = tvDSPDN.SelectedNode;
                if(tn==null)
                {
                    MessageBox.Show("Chưa chọn phiếu đề nghị nhập");
                    return;
                }
                btnThem.Text = "Hủy";
                txtManv.Enabled = true;
                btnLuu.Enabled = true;
                txtghichu.Enabled = true;
            }
            else
            {
                btnThem.Text = "Thêm Phiếu Nhập Kho";
                btnLuu.Enabled = false;
                txtManv.Enabled = false;
                txtghichu.Enabled = false;
            }
        }

        private void tvDSPDN_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            string maphieu = e.Node.Tag.ToString();
            LoadDgv(maphieu);
            //txtMaPhieu.Text = maphieu;
            lbsoPhieunk.Text = maphieu;
            //txtMaKho.Text = e.Node.Nodes[1].Tag.ToString();
            lbMakho.Text = e.Node.Nodes[1].Tag.ToString();
        }

        private void LoadDgv(string ma)
        {
            dGVCT.DataSource = pnkBUS.GetTTPhieuNhapKho(ma);
        }

        private bool KtraTextbox()
        {
            if(txtManv.Text =="")
            {
                MessageBox.Show("Mã nhân viên không thể để trống");
                return false;
            }
            else if(pnkBUS.ktranv(txtManv.Text))
            {
                MessageBox.Show("Bạn không phải là nhân viên kho");
                return false;
            }
            return true;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if(KtraTextbox())
            {
                try
                {
                    ePhieuNhapKho ePNK = new ePhieuNhapKho();
                    ePNK.SoPDNN = lbsoPhieunk.Text;
                    ePNK.MaNV = txtManv.Text;
                    ePNK.NgayLap = DateTime.Now;
                    ePNK.MaKho = lbMakho.Text;
                    ePNK.GhiChu = txtghichu.Text;
                    //KtraTextbox();
                    pnkBUS.taophieunhapkho(ePNK);
                    MessageBox.Show("Đã chuyển thành phiếu Nhập Kho");
                    LoadTreeView();
                    dGVCT.DataSource = null;
                    btnThem_Click(btnThem, new EventArgs());
                }
                catch
                {
                    MessageBox.Show("Không thể lưu");
                }
            }
        }
    }
}
