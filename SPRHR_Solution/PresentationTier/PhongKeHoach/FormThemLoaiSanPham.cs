using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.PhongKeHoach;
using BusinessLogicTier.PhongKeHoach.SanPham;

namespace PresentationTier.PhongKeHoach
{
    public partial class FormThemLoaiSanPham : Form
    {
        SanPham_BUL sp = new SanPham_BUL();
        public FormThemLoaiSanPham()
        {
            InitializeComponent();
        }

        private void them_Click(object sender, EventArgs e)
        {
            if(txtmaloai == null || txttenloai == null)
            {
                MessageBox.Show("Tên hoặc Mã Loại không được để trống");
            }
            else
            {
                try
                {
                    eLoaiSanPham newl = new eLoaiSanPham();
                    newl.MaLoaiSP = txtmaloai.Text;
                    newl.TenLoaiSP = txttenloai.Text;
                    newl.Style = txtstyle.Text;
                    newl.MoTa = txtmota.Text;
                    if(sp.ThemLoaiSpMoi(newl))
                    {
                        MessageBox.Show("Insert Succcesfully");
                        this.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
            }
        }
    }
}
