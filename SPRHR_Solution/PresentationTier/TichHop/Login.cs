using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier.TichHop;

namespace PresentationTier.TichHop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_password.TextLength * tb_password.TextLength >= 36)
            {
                if (BLL_User.login(tb_userName, tb_password))
                {
                    BLL_User.showFormRole(BLL_User.getRole(tb_userName.Text), this, new PresentationTier.BanHang.FormMainBanHang(),
                        new PresentationTier.CongNo.FormMainCongNo(), new PresentationTier.Kho.FormMainKho(),
                        new PresentationTier.NhanSu.frmMainNhanSu(), new PresentationTier.PhongKeHoach.FormMainPhongKeHoach(),
                        new PresentationTier.TichHop.FormAdmin());
                }
                else
                {
                    MessageBox.Show("Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Sai Định Dạng");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
