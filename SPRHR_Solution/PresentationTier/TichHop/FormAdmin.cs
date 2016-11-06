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
    public partial class FormAdmin : Form
    {
        private List<RadioButton> rb;

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            rb = new List<RadioButton>();
            rb.Add(rb_admin);
            rb.Add(rb_banHang);
            rb.Add(rb_congNo);
            rb.Add(rb_kho);
            rb.Add(rb_nhanSu);
            rb.Add(rb_pkh);
            rb.Add(rb_no);
            BLL_User.LoadUser(tw_ds);
        }

        private void tw_ds_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lb_userName.Text = tw_ds.SelectedNode.Text;
            BLL_User.LoadRole(BLL_User.getRole(lb_userName.Text.Trim().ToLower()), rb_no, rb_banHang,
                rb_congNo, rb_kho, rb_nhanSu, rb_pkh, rb_admin);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_userName.Text != null | lb_userName.Text != "")
                {
                    foreach (RadioButton rb in rb)
                    {
                        if (rb.Checked == true)
                        {
                            BLL_User.editRole(lb_userName.Text, rb.Tag.ToString().Trim());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa Chọn User");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thất Bại");
                throw;
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            PresentationTier.TichHop.AddUser add = new AddUser();
            add.ShowDialog();
            this.Show();
        }

        private void FormAdmin_Activated(object sender, EventArgs e)
        {
            BLL_User.LoadUser(tw_ds);
        }
    }
}
