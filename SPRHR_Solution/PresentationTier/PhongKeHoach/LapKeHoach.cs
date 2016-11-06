using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier.PhongKeHoach.KeHoach;
using BusinessEntities.PhongKeHoach;

namespace PresentationTier.PhongKeHoach
{
    public partial class LapKeHoach : Form
    {
        LapKeHoach_BUL Kh = new LapKeHoach_BUL();
        List<eKeHoach> Ls = new List<eKeHoach>();
        private BindingSource Sr;
        public LapKeHoach()
        {
            InitializeComponent();
        }

        private void LapKeHoach_Load(object sender, EventArgs e)
        {
            
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(moc1.Text) >= Convert.ToDateTime(moc2.Text))
            {
                MessageBox.Show("!Moc 2 > Moc1","Failed");
            }
            else
            {
                try
                {
                    DrvKH.Visible = true;
                    Ls = Kh.LapDanhSachKehoachChoSanPham(Convert.ToDateTime(moc1.Text), Convert.ToDateTime(moc2.Text));
                    Sr = new BindingSource();
                    Sr.DataSource = Ls;
                    DrvKH.DataSource = Sr;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + " " + ex.Message.ToString());
                }
            }
        }
    }
}
