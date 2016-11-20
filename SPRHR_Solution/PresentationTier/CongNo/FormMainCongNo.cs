using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.NhanSu;

namespace PresentationTier.CongNo
{
    public partial class FormMainCongNo : Form
    {
        private eNhanVien NV = new eNhanVien();
        public FormMainCongNo()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            frmXemThongTin f = new frmXemThongTin();
            f.ShowDialog();

        }

        private void btnTraNoNCC_Click(object sender, EventArgs e)
        {
            frmTraNoNCC f = new frmTraNoNCC(NV);
            f.ShowDialog();
        }

        private void btnThuNoKH_Click(object sender, EventArgs e)
        {
            frmTraNoKH f = new frmTraNoKH(NV);
            f.ShowDialog();
        }
    }
}
