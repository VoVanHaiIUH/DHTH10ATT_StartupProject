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
    public partial class frmDinhGia : Form
    {
        BusinessLogicTier.BanHang.DinhGia.DinhGia_BUS db;

        public frmDinhGia()
        {
            InitializeComponent();
            db = new BusinessLogicTier.BanHang.DinhGia.DinhGia_BUS();
        }

        private void frmDinhGia_Load(object sender, EventArgs e)
        {
            List<string> select = new List<string>();
            select.Add("Sản phẩm chưa được định giá");
            select.Add("Sản phẩm đã được định giá");
            cboSelect.DataSource = select;
        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelect.Text == "Sản phẩm đã được định giá")
            {
               dgvSanPham.DataSource = db.LoadGiaBan();
            }
        }
    }
}
