using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier.Kho
{
    public partial class FormMainKho : Form
    {
        public FormMainKho()
        {
            InitializeComponent();
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyKho ql = new frmQuanLyKho();
            ql.ShowDialog();
        }

        private void mnSanPham_Click(object sender, EventArgs e)
        {
            frmThongTinKho_dal sp = new frmThongTinKho_dal();
            sp.ShowDialog();
        }

        private void mnNhapKho_Click(object sender, EventArgs e)
        {
            frmPhieuNhapKho nk = new frmPhieuNhapKho();
            nk.ShowDialog();
        }

        private void FormMainKho_Load(object sender, EventArgs e)
        {

        }

        private void mnXuatKho_Click(object sender, EventArgs e)
        {
            frmPhieuXuatKho xk = new frmPhieuXuatKho();
            xk.ShowDialog();
        }

        private void xemPhiếuNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemPhieuNhap xn = new frmXemPhieuNhap();
            xn.ShowDialog();
        }

        private void xemPhiếuXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemPhieuXuat xx = new frmXemPhieuXuat();
            xx.ShowDialog();
        }
    }
}
