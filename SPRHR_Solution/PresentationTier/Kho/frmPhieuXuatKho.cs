using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier.Kho;
using BusinessEntities.Kho;
using BusinessEntities.NhanSu;

namespace PresentationTier.Kho
{
    public partial class frmPhieuXuatKho : Form
    {
        List<ePhieuXuatKho> eXK;
        PhieuXuatKho_BUS pxBUS;
        QuanLyKho_BUS qlkBUS;
        public frmPhieuXuatKho()
        {
            InitializeComponent();
            eXK = new List<ePhieuXuatKho>();
            pxBUS = new PhieuXuatKho_BUS();
            qlkBUS = new QuanLyKho_BUS();
        }

        private void frmPhieuXuatKho_Load(object sender, EventArgs e)
        {
            LoadTv();
        }

        private void tvPhieudn_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string maphieu = e.Node.Tag.ToString();
            txtsophieu.Text = maphieu;
            //LoadDgv(maphieu);
            //lbsoPhieunk.Text = maphieu;
            txtmakho.Text = e.Node.Nodes[0].Tag.ToString();

            LoadDatagrid(txtsophieu.Text, txtmakho.Text, dGVchitiet);
        }

        private void LoadTv()
        {
            tvPhieudn.Nodes.Clear();
            foreach (BusinessEntities.PhongKeHoach.ePhieuDeNghiXuatKho ednx in pxBUS.GetPDNXK())
            {
                TreeNode tn = new TreeNode();
                tn.Tag = ednx.SoPhieuDeNghiXuatKho;
                tn.Text = "Số phiếu: " + ednx.SoPhieuDeNghiXuatKho;

                TreeNode tnKho = new TreeNode();
                tnKho.Tag = ednx.MaKho;
                tnKho.Text = "Mã kho: " + ednx.MaKho;
                tn.Nodes.Add(tnKho);
                tvPhieudn.Nodes.Add(tn);
            }
        }
        private void LoadDatagrid(string ma, string makho, DataGridView dgv)
        {
            pxBUS.LoadChiTiet(ma, makho, dgv);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(btnthem.Text == "Thêm")
            {
                txtManv.Enabled = txtghichu.Enabled = true;
                btnthem.Text = "Hủy";
                btnluu.Enabled = true;
            }
            else
            {
                txtManv.Enabled = txtghichu.Enabled = false;
                btnthem.Text = "Thêm";
                btnluu.Enabled = false;
            }
        }

        private bool KtraTextbox()
        {
            if (txtManv.Text == "")
            {
                MessageBox.Show("Mã nhân viên không thể để trống");
                return false;
            }
            return true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (KtraTextbox())
            {
                try
                {
                    ePhieuXuatKho ePXK = new ePhieuXuatKho();
                    ePXK.SoPXK = txtsophieu.Text;
                    ePXK.MaNV = txtManv.Text;
                    ePXK.NgayLap = DateTime.Now;
                    ePXK.MaKho = txtmakho.Text;
                    ePXK.GhiChu = txtghichu.Text;

                    pxBUS.taophieuxuatkho(ePXK);
                    MessageBox.Show("Đã chuyển thành phiếu xuất Kho");
                    btnthem_Click(btnthem, new EventArgs());
                    LoadTv();
                    dGVchitiet.DataSource = null;
                    btnthem_Click(btnthem, new EventArgs());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtManv_Leave(object sender, EventArgs e)
        {
            foreach (eNhanVien nv in qlkBUS.GetTTNhanVien(txtManv.Text))
            {
                txttennv.Text = nv.HoTenNhanVien;
            }
        }
    }
}
