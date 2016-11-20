using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier.BanHang
{
    public partial class FormMainBanHang : Form
    {
        public FormMainBanHang()
        {
            InitializeComponent();

        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            frmLapPhieu _frmLapPhieu = new frmLapPhieu();
            Hide();
            _frmLapPhieu.Show();
        }

        private void btnDinhGia_Click(object sender, EventArgs e)
        {
            frmDinhGia _frmDinhGia = new frmDinhGia();
            _frmDinhGia.ShowDialog();
        }
    }
}
