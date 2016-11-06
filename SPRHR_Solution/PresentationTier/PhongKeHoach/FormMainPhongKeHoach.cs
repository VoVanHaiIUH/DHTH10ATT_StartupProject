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
    public partial class FormMainPhongKeHoach : Form
    {
        public FormMainPhongKeHoach()
        {
            InitializeComponent();
        }
        private void LoadLapKeHoachForm()
        {
            if (CBKH.SelectedItem.ToString() == "Lập Kế Hoạch Sản Phẩm")
            {
                this.Hide();
                LapKeHoach F = new LapKeHoach();
                F.ShowDialog();
                this.Show();
            }
            else
            {
                this.Show();
            }
        }
        private void LoadHienThiPDNNK()
        {
            if(CBHT.SelectedItem.ToString() == "Hiển Thị PDNNK")
            {
                this.Hide();
                ViewPDNNKPrint f = new ViewPDNNKPrint();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                this.Show();
            }
        }
        private void FormMainPhongKeHoach_Load(object sender, EventArgs e)
        {
            LoadLapKeHoachForm();
            LoadHienThiPDNNK();
        }
    }
}
