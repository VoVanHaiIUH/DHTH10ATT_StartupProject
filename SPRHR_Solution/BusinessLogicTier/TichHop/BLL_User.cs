using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.TichHop;
using BusinessEntities.TichHop;

namespace BusinessLogicTier.TichHop
{
    public class BLL_User
    {
        public static Boolean testLogin(String userName, String password)
        {
            try
            {
                if (DAL_User.getPassword(userName).Trim() == password.Trim())
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Không Có UserName");
            }
            return false;
        }

        public static Boolean login(TextBox tb_userName, TextBox tb_password)
        {
            if (testLogin(tb_userName.Text, tb_password.Text))
            {
                return true;
            }
            return false;
        }

        public static String getRole(String userName)
        {
            try
            {
                return DAL_User.getRole(userName.Trim());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void showFormRole(String role, Form main, Form bh, Form cn, Form kho, Form ns, Form pkh, Form admin)
        {
            if (role == "BanHang")
            {
                showForm(main, bh);
            }
            else if (role == "NhanSu")
            {
                showForm(main, ns);
            }
            else if (role == "Kho")
            {
                showForm(main, kho);
            }
            else if (role == "PKH")
            {
                showForm(main, pkh);
            }
            else if (role == "CongNo")
            {
                showForm(main, cn);
            }
            else if (role == "admin")
            {
                showForm(main, admin);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Có Quyền Gì Cả!");
            }
        }

        public static void showForm(Form main, Form show)
        {
            main.Hide();
            show.ShowDialog();
            main.Show();
        }

        public static void editRole(String userName, String Role)
        {
            try
            {
                DAL_User.editRole(userName.Trim().ToLower(), Role.Trim());
                MessageBox.Show("Thây Đổi Role " + userName + " Thành Công");
            }
            catch (Exception)
            {
                MessageBox.Show("Thất Bại");
            }
        }

        public static void addUser(TextBox tb_userName, TextBox tb_pass, TextBox configPass, ComboBox cbb)
        {
            try
            {
                String pass = DAL_User.getPassword(tb_userName.Text);
                if (pass == null | pass == "")
                {
                    try
                    {
                        int tmp = tb_userName.TextLength * tb_pass.TextLength * configPass.TextLength;
                        if (tmp > 0 & tb_userName.TextLength * tb_pass.TextLength > 36 & tb_pass.Text == configPass.Text)
                        {
                            DAL_User.addUser(new eUser(tb_userName.Text.Trim().ToLower(), tb_pass.Text.Trim().ToLower(), getValuesCbb(cbb.Text), true));
                            MessageBox.Show("Thành Công");
                        }
                        else
                        {
                            MessageBox.Show("Sai Định Dạng");
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thất Bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã Trùng UserName");
                }
            }
            catch (Exception)
            {
            }
        }

        public static void LoadUser(TreeView tw)
        {
            tw.Nodes.Clear();
            foreach (eUser tmp in DAL_User.getUsers())
            {
                tw.Nodes.Add(new TreeNode(tmp.UserName));
            }
        }

        public static String BLL_getRole(String userName)
        {
            try
            {
                return BLL_User.getRole(userName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void LoadRole(String role, RadioButton no, RadioButton bh, RadioButton cn, RadioButton kho, RadioButton ns, RadioButton pkh, RadioButton admin)
        {
            if (role == "BanHang")
            {
                bh.Checked = true;
            }
            else if (role == "NhanSu")
            {
                ns.Checked = true;
            }
            else if (role == "Kho")
            {
                kho.Checked = true;
            }
            else if (role == "PKH")
            {
                pkh.Checked = true;
            }
            else if (role == "CongNo")
            {
                cn.Checked = true;
            }
            else if (role == "admin")
            {
                admin.Checked = true;
            }
            else
            {
                no.Checked = true;
            }
        }

        public static String getValuesCbb(String name)
        {
            if (name == "Bán Hàng")
            {
                return "BanHang";
            }
            else if (name == "Nhân Sự")
            {
                return "NhanSu";
            }
            else if (name == "Kho")
            {
                return "Kho";
            }
            else if (name == "Phòng Kế Hoạch")
            {
                return "PKH";
            }
            else if (name == "Công Nợ")
            {
                return "CongNo";
            }
            else if (name == "Admin")
            {
                return "admin";
            }
            else
            {
                return ".";
            }
        }
    }
}
