using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier.PhongKeHoach.SanPham;
using BusinessEntities.PhongKeHoach;

namespace PresentationTier.PhongKeHoach
{
    public partial class FormQuanLySanPham : Form
    {
        List<eLoaiSanPham> llsp = new List<eLoaiSanPham>();
        List<eSanPham> lsp = new List<eSanPham>();
        SanPham_BUL sp = new SanPham_BUL();
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lsp = sp.LaySanPhamTheoMa(tvsp.SelectedNode.Tag.ToString());
            foreach(eSanPham sap in lsp)
            {
                txtSp.Text = sap.TenSP;
                txtmota.Text = sap.MoTa;
                txtms.Text = sap.MauSac;
                txtkd.Text = sap.KieuDang;
                txttl.Text = sap.Trongluong.ToString();
                nsx.Text = sap.NgaySX.ToString();
                nhh.Text = sap.NgayHetHan.ToString();
                cbdvt.Text = sap.DonViTinh;
                txtgia.Text = (sp.RefeshGiaBanSi(tvsp.SelectedNode.Tag.ToString())).ToString();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThemLoaiSanPham f = new FormThemLoaiSanPham();
            tvlsp.Nodes.Clear();
            LoadLsp();
            f.ShowDialog();
            this.Show();
        }
        private void LoadLsp()
        {
            llsp = sp.GetallLsp();
            foreach(eLoaiSanPham l in llsp)
            {
                TreeNode tn = new TreeNode();
                tn.Text = l.TenLoaiSP;
                tn.Tag = l.MaLoaiSP;
                tvlsp.Nodes.Add(tn);
            }
        }
        private void LoadDsSpcanUpdate()
        {
            lsp = sp.LayDanhSachCanUpdate();
            foreach (eSanPham sp1 in lsp)
            {
                TreeNode tn = new TreeNode();
                tn.Text = sp1.TenSP;
                tn.Tag = sp1.MaSP;
                tvsp.Nodes.Add(tn);
            }
        }
        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadLsp();
            LoadDsSpcanUpdate();
        }

        private void choncn_Click(object sender, EventArgs e)
        {
            if (txtSp.Text != null)
            {
                CapNhatBanSi.Enabled = true;
                cpsp.Enabled = true;
                huybothongtin.Enabled = true;
                txtkd.ReadOnly = false;
                txtmota.ReadOnly = false;
                txtms.ReadOnly = false;
                txtSp.ReadOnly = false;
                txttl.ReadOnly = false;
                nsx.Enabled = true;
                nhh.Enabled = true;
                cbdvt.Enabled = true;
                cblsp.Enabled = true;
            }
            else
            {
                MessageBox.Show("Hãy Chọn 1 Sản Phẩm Ở Trên Đã");
            }
        }

        private void huybothongtin_Click(object sender, EventArgs e)
        {
            txtkd.Clear();
            txtmota.Clear();
            txtms.Clear();
            txtSp.Clear();
            txttl.Clear();
            cbdvt.Text = "Chọn Loại Đơn Vị Tính";
            cblsp.Text = "Chọn Loại Sản Phẩm";
        }

        private void CapNhatBanSi_Click(object sender, EventArgs e)
        {
            txtgia.Clear();
            txtgia.Text = (sp.RefeshGiaBanSi(tvsp.SelectedNode.Tag.ToString())).ToString();
        }

        private void cpsp_Click(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(txttl.Text) <= 0 || Convert.ToDecimal(txttl.Text) > 1000000)
            {
                throw new Exception("Lỗi Trọng Lượng Quá lớn");
            }
            try
            {
                if (Convert.ToDateTime(nsx.Text) >= DateTime.Now || Convert.ToDateTime(nhh.Text) >= Convert.ToDateTime(nsx.Text))
                {
                    MessageBox.Show("Lỗi Nhập Ngày");
                    if(cblsp.SelectedValue == null)
                    {
                        MessageBox.Show("Loại Sản Phẩm Không Được Để Trống");
                    }
                    else
                    {
                          sp.CapNhatLaiThongTinSP(txtSp.Text, cblsp.SelectedItem.ToString(), txtkd.Text, cbdvt.SelectedItem.ToString(), txtms.Text, txtmota.Text, Convert.ToDateTime(nsx), Convert.ToDateTime(nhh), Convert.ToDecimal(txttl));
                          MessageBox.Show("Cập Nhật Thành Công");
                          CapNhatBanSi.Enabled = false;
                          cpsp.Enabled = false;
                          huybothongtin.Enabled = false;
                          txtkd.ReadOnly = true;
                          txtmota.ReadOnly = true;
                          txtms.ReadOnly = true;
                          txtSp.ReadOnly = true;
                          txttl.ReadOnly = false;
                          nhh.Enabled = false;
                          cbdvt.Enabled = false;
                          cblsp.Enabled = false;
                          tvsp.Nodes.Clear();
                          LoadDsSpcanUpdate();  
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }
    }
}
