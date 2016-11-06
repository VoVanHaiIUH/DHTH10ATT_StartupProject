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
    public partial class PhieuNhapKho : Form
    {
        List<ePhieuNhapKho> ePN;
        PhieuNhapKho_BUS pnkBUS;
        public PhieuNhapKho()
        {
            InitializeComponent();
            ePN = new List<ePhieuNhapKho>();
            pnkBUS = new PhieuNhapKho_BUS();
        }

        private void PhieuNhapKho_Load(object sender, EventArgs e)
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ePhieuNhapKho ePNK = new ePhieuNhapKho();
                ePNK.SoPDNN = txtMaPhieu.Text;
                ePNK.MaNV = txtManv.Text;
                ePNK.NgayLap = DateTime.Now;
                ePNK.MaKho = txtMaKho.Text;

                pnkBUS.taophieunhapkho(ePNK);
            }
            catch
            {
                MessageBox.Show("Không thể lưu");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                btnThem.Text = "Hủy";
                txtManv.Enabled = true;
            }
            else
            {
                btnThem.Text = "Thêm";
                txtManv.Enabled = false;
            }
        }

        private void LoadDGV(DataGridView drv, IEnumerable<object> ls)
        {
            dGVCT.DataSource = ls;
        }

        private void tvDSPDN_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
