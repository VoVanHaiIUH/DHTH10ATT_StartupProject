using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.CongNo;
using BusinessEntities.NhanSu;
using BusinessLogicTier.CongNo;

namespace PresentationTier.CongNo
{
    public partial class frmTraNoKH : Form
    {
        private eNhanVien NhanVien;
        private CongNo_ALL_BUS CN;
        public frmTraNoKH()
        {
            InitializeComponent();
            CN = new CongNo_ALL_BUS();
        }
        public frmTraNoKH( eNhanVien pNhanVien)
        {
            InitializeComponent();
            CN = new CongNo_ALL_BUS();
            NhanVien = pNhanVien;
        }
        private void LoadTrv()
        {
            trvThongTinKH.Nodes.Clear();
            foreach (var ncc in CN.GetListKhachHangNo())
            {
                // gốc tên nhà cung cấp
                TreeNode tn = new TreeNode();
                tn.Text = ncc.TenKH;
                tn.Tag = ncc.MaKH;

                TreeNode tn1 = new TreeNode();
                tn.Nodes.Add(tn1);


                trvThongTinKH.Nodes.Add(tn);
            }
            // trvThongTinNCC.Nodes.Add(root);
        }
        private void LoadNodeNCCExpand(TreeNode pRoot, string pMaKH)
        {
            List<eCongNoKhachHang> l = CN.GetListNoCuaNoKhachHang(pMaKH);
            pRoot.Nodes.Clear();
            // tổng sô nợ
            TreeNode tnTongSoNo = new TreeNode("Tổng số nợ: " + l.Count.ToString());
            tnTongSoNo.Tag = "TSNNCC" + pMaKH;
            decimal tongSoTienDaNo = 0;

            gbxNoKH.Text = "Thông tin công nợ của khách hàng: " + pRoot.Text;
            dgvPhieuNo.DataSource = l;
            foreach (var cn in l)
            {
                TreeNode tnMaHDNo = new TreeNode("Hóa đơn nợ: " + cn.MaHoaDonBanSi);
                tnMaHDNo.Tag = "MHDN" + cn.MaHoaDonBanSi;
                TreeNode tnSoTienNoSub = new TreeNode("Số tiền nợ: " + cn.SoTienNo.ToString());
                tnSoTienNoSub.Tag = "SMHDN" + cn.MaHoaDonBanSi;

                TreeNode tnNgayHetHan = new TreeNode("Ngày đáo hạn: " + cn.NgayDaoHan.ToString());
                tnNgayHetHan.Tag = "NDH" + cn.MaHoaDonBanSi;

                tnMaHDNo.Nodes.Add(tnSoTienNoSub);
                tnMaHDNo.Nodes.Add(tnNgayHetHan);
                tnTongSoNo.Nodes.Add(tnMaHDNo);


                tongSoTienDaNo += cn.SoTienNo;
            }
            pRoot.Nodes.Add(tnTongSoNo);


            TreeNode tnTongSoTienNo = new TreeNode("Tổng số tiền đã nợ: " + tongSoTienDaNo.ToString());
            tnTongSoTienNo.Tag = "STNNCC" + pMaKH;
            pRoot.Nodes.Add(tnTongSoTienNo);
        }
        private void LoadTinhTrangCongNo(TreeNode pRoot, string pTag)
        {
            string maHoaDon = pTag.Substring(4);
            decimal soTienNo = decimal.Parse(pRoot.Nodes[0].Text.Substring(12));

            decimal soTienDaTra = 0;
            List<eChiTietPhieuTraNoNCC> l = CN.GetChiTietTraNoNCC(maHoaDon);
            dgvPhieuNo.DataSource = l;
            gbxNoKH.Text = "Chi tiết thu nợ cho hóa đơn: " + maHoaDon;
            tbxMaHoaDon.Text = maHoaDon;
            if (pRoot.Nodes.Count > 4)
            {
                pRoot.Nodes.RemoveAt(4);
                pRoot.Nodes.RemoveAt(3);
                pRoot.Nodes.RemoveAt(2);
            }
            foreach (var ct in l)
            {
                soTienDaTra += ct.SoTien;
            }
            if (soTienDaTra < soTienNo)
            {
                pRoot.Nodes.Add(new TreeNode("Chưa trả xong"));
                pRoot.Nodes.Add(new TreeNode("Đã trả: " + soTienDaTra.ToString()));
                pRoot.Nodes.Add(new TreeNode("Còn lại: " + (soTienNo - soTienDaTra).ToString()));
            }

        }
        private void trvThongTinKH_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null && e.Node.Tag.ToString().Trim() != "")
            {
                if (e.Node.Tag.ToString().StartsWith("KH"))
                {
                    LoadNodeNCCExpand(e.Node, e.Node.Tag.ToString());
                }
                else if (e.Node.Tag.ToString().StartsWith("MHDN"))
                {
                    LoadTinhTrangCongNo(e.Node, e.Node.Tag.ToString());
                }
            }
        }

        private void trvThongTinKH_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null && e.Node.Tag.ToString().Trim() != "")
            {
                if (e.Node.Tag.ToString().StartsWith("KH"))
                {
                    LoadNodeNCCExpand(e.Node, e.Node.Tag.ToString());
                }
                else if (e.Node.Tag.ToString().StartsWith("MHDN"))
                {
                    LoadTinhTrangCongNo(e.Node, e.Node.Tag.ToString());
                }
            }
        }

        private void frmTraNoKH_Load(object sender, EventArgs e)
        {
            LoadTrv();
        }

        private void btnTraNo_Click(object sender, EventArgs e)
        {
            string strTag = btnTraNo.Tag.ToString();
            if (strTag == "0")
            {
                tbxSoTien.ReadOnly = false;
                ricGhiChu.ReadOnly = false;
                btnTraNo.Tag = 1;
                btnTraNo.Text = "Hủy";
                btnOK.Enabled = true;
            }
            else
            {
                tbxSoTien.ReadOnly = true;
                ricGhiChu.ReadOnly = true;
                btnTraNo.Tag = 0;
                btnTraNo.Text = "Thu nợ";
                tbxSoTien.Clear();
                ricGhiChu.Clear();
                btnOK.Enabled = false;

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                CN.ThuNoKH(tbxMaHoaDon.Text, NhanVien.MaNhanVien, decimal.Parse(tbxSoTien.Text), ricGhiChu.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền nhập không đúng định dạng");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
