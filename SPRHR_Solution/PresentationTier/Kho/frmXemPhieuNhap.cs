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
    public partial class frmXemPhieuNhap : Form
    {
        List<ePhieuNhapKho> epn;
        PhieuNhapKho_BUS pnBUS;
        public frmXemPhieuNhap()
        {
            InitializeComponent();
            epn = new List<ePhieuNhapKho>();
            pnBUS = new PhieuNhapKho_BUS();
        }

        private void frmXemPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadTree();
        }

        private void LoadTree()
        {
            tvPhieuNhap.Nodes.Clear();
            foreach(ePhieuNhapKho t in pnBUS.getpnk())
            {
                TreeNode tn = new TreeNode();
                tn.Text = t.SoPDNN;
                tn.Tag = t.SoPDNN;
                tvPhieuNhap.Nodes.Add(tn);
            }
        }
        private void LoadDGv(string ma)
        {
            dGVsp.DataSource = pnBUS.GetTTPhieuNhapKho(ma);
        }

        private void tvPhieuNhap_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string ma = e.Node.Tag.ToString();
            LoadDGv(ma);
            foreach (ePhieuNhapKho p in pnBUS.getpnktheoma(ma))
            {
                txtghichu.Text = p.GhiChu;
                txtmakho.Text = p.MaKho;
                txtmanv.Text = p.MaNV;
                txtngay.Text = p.NgayLap.ToShortDateString();
                txtsophieu.Text = p.SoPDNN;
            }
        }
    }
}
