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
    public partial class frmXemPhieuXuat : Form
    {
        List<ePhieuXuatKho> epx;
        PhieuXuatKho_BUS pxBUS;
        public frmXemPhieuXuat()
        {
            InitializeComponent();
            epx = new List<ePhieuXuatKho>();
            pxBUS = new PhieuXuatKho_BUS();
        }

        

        private void frmXemPhieuXuat_Load(object sender, EventArgs e)
        {
            LoadTree();
        }

        private void LoadTree()
        {
            tvPhieuNhap.Nodes.Clear();
            foreach(ePhieuXuatKho e in pxBUS.GetPXK())
            {
                TreeNode tn = new TreeNode();
                tn.Text = e.SoPXK;
                tvPhieuNhap.Nodes.Add(tn);
            }
        }

        private void tvPhieuNhap_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string ma = e.Node.Text;
            string makho = "";
            foreach(ePhieuXuatKho px in pxBUS.GetPXKbyMa(ma))
            {
                txtsophieu.Text = px.SoPXK;
                txtngay.Text = px.NgayLap.ToShortDateString();
                txtmanv.Text = px.MaNV;
                txtmakho.Text = px.MaKho;
                txtghichu.Text = px.GhiChu;
                makho = px.MaKho;
            }
            LoadDGV(ma,makho);
        }
        private void LoadDGV(string maphieu, string makho)
        {
            pxBUS.LoadChiTiet(maphieu, makho, dGVsp);
        }
    }
}
