using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier.PhongKeHoach
{
    public partial class FormQuanLyKhieuDeNghiNhapKho : Form
    {
        public FormQuanLyKhieuDeNghiNhapKho()
        {
            InitializeComponent();
        }

        private void FormQuanLyKhieuDeNghiNhapKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sPRHR_SolutionDataSet2.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.sPRHR_SolutionDataSet2.SanPham);
            // TODO: This line of code loads data into the 'sPRHR_SolutionDataSet1.ChiTietPhieuDNNK' table. You can move, or remove it, as needed.
            this.chiTietPhieuDNNKTableAdapter.Fill(this.sPRHR_SolutionDataSet1.ChiTietPhieuDNNK);

        }
    }
}
