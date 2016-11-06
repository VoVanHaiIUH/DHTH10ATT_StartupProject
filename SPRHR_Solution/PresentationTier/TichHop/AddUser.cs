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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            BLL_User.addUser(tb_userName, tb_pass, tb_config, cbb_role);
        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            tb_config.Text = tb_pass.Text = tb_userName.Text = cbb_role.Text = "";
        }
    }
}
