using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier.CongNo;
using BusinessEntities.PhongKeHoach;
using BusinessEntities.CongNo;
using BusinessEntities.NhanSu;

namespace PresentationTier.CongNo
{
    public partial class frmTraNoNCC : Form
    {
        private CongNo_ALL_BUS CN;
        private eNhanVien NhanVien;
        public frmTraNoNCC()
        {
            InitializeComponent();
            CN = new CongNo_ALL_BUS();
        }
        public frmTraNoNCC(eNhanVien pNhanVien)
        {
            InitializeComponent();
            CN = new CongNo_ALL_BUS();
            NhanVien = pNhanVien;
        }
        private void LoadTrv()
        {
            trvThongTinNCC.Nodes.Clear();
            //TreeNode root = new TreeNode("Nhà Cung Cấp");
            foreach (var ncc in CN.GetListNhaCungCapNo())
            {
                // gốc tên nhà cung cấp
                TreeNode tn = new TreeNode();
                tn.Text = ncc.TenNCC;
                tn.Tag = ncc.MaNCC;

                TreeNode tn1 = new TreeNode();
                tn.Nodes.Add(tn1);


                trvThongTinNCC.Nodes.Add(tn);
            }
            // trvThongTinNCC.Nodes.Add(root);
        }
        private void frmTraNoNCC_Load(object sender, EventArgs e)
        {
            LoadTrv();
        }
        private void LoadNodeNCCExpand(TreeNode pRoot, string pMaNCC)
        {
            List<eCongNoNCC> l = CN.GetListNoCuaNoCungCap(pMaNCC);
            pRoot.Nodes.Clear();
            // tổng sô nợ
            TreeNode tnTongSoNo = new TreeNode("Tổng số nợ: " + l.Count.ToString());
            tnTongSoNo.Tag = "TSNNCC" + pMaNCC;
            decimal tongSoTienDaNo = 0;

            gbxNoNCC.Text = "Thông tin công nợ của nhà cung cấp: "+pRoot.Text;
            dgvPhieuNo.DataSource = l;
            foreach (var cn in l)
            {
                TreeNode tnMaHDNo = new TreeNode("Hóa đơn nợ: " + cn.MaHoaDonNCC);
                tnMaHDNo.Tag = "MHDN" + cn.MaHoaDonNCC;
                TreeNode tnSoTienNoSub = new TreeNode("Số tiền nợ: " + cn.SoTienNo.ToString());
                tnSoTienNoSub.Tag = "SMHDN" + cn.MaHoaDonNCC;

                TreeNode tnNgayHetHan = new TreeNode("Ngày đáo hạn: " + cn.NgayDaoHan.ToString());
                tnNgayHetHan.Tag = "NDH" + cn.MaHoaDonNCC;

                tnMaHDNo.Nodes.Add(tnSoTienNoSub);
                tnMaHDNo.Nodes.Add(tnNgayHetHan);
                tnTongSoNo.Nodes.Add(tnMaHDNo);


                tongSoTienDaNo += cn.SoTienNo;
            }
            pRoot.Nodes.Add(tnTongSoNo);


            TreeNode tnTongSoTienNo = new TreeNode("Tổng số tiền đã nợ: " + tongSoTienDaNo.ToString());
            tnTongSoTienNo.Tag = "STNNCC" + pMaNCC;
            pRoot.Nodes.Add(tnTongSoTienNo);
        }
        private void LoadTinhTrangCongNo(TreeNode pRoot, string pTag)
        {
            string maHoaDon = pTag.Substring(4);
            decimal soTienNo = decimal.Parse(pRoot.Nodes[0].Text.Substring(12));
           
            decimal soTienDaTra = 0;
            List<eChiTietPhieuTraNoNCC> l = CN.GetChiTietTraNoNCC(maHoaDon);
            dgvPhieuNo.DataSource = l;
            gbxNoNCC.Text = "Chi tiết trả nợ cho hóa đơn: "+maHoaDon;
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
                pRoot.Nodes.Add(new TreeNode("Đã trả: "+soTienDaTra.ToString()));
                pRoot.Nodes.Add(new TreeNode("Còn lại: "+(soTienNo-soTienDaTra).ToString()));
            }
            
        }
        private void trvThongTinNCC_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null && e.Node.Tag.ToString().Trim() != "")
            {
                if (e.Node.Tag.ToString().StartsWith("NCC"))
                {
                    LoadNodeNCCExpand(e.Node, e.Node.Tag.ToString());
                }
                else if (e.Node.Tag.ToString().StartsWith("MHDN"))
                {
                    LoadTinhTrangCongNo(e.Node, e.Node.Tag.ToString());
                }
            }
        }
        private void trvThongTinNCC_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null && e.Node.Tag.ToString().Trim() != "")
            {
                if (e.Node.Tag.ToString().StartsWith("NCC"))
                {
                    LoadNodeNCCExpand(e.Node, e.Node.Tag.ToString());
                }
                else if (e.Node.Tag.ToString().StartsWith("MHDN"))
                {
                    LoadTinhTrangCongNo(e.Node, e.Node.Tag.ToString());
                }
            }
        }
        private void btnTraNo_Click(object sender, EventArgs e)
        {
            string strTag = btnTraNo.Tag.ToString();
            if(strTag=="0")
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
                btnTraNo.Text = "Trả nợ";
                tbxSoTien.Clear();
                ricGhiChu.Clear();
                btnOK.Enabled = false;

            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                CN.TraNoNCC(tbxMaHoaDon.Text, NhanVien.MaNhanVien, decimal.Parse(tbxSoTien.Text), ricGhiChu.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Số tiền nhập không đúng định dạng");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
