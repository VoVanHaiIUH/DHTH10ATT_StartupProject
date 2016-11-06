using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.TichHop;

namespace DataAccessLayer.TichHop
{
    public class DAL_User
    {
        private static SPRHR_UserDataContext data = new SPRHR_UserDataContext();


        public static String getPassword(String userName)
        {
            try
            {
                return data.Users.Where(x => x.UserName.Trim() == userName.Trim()).SingleOrDefault().Password.Trim();
            }
            catch (Exception)
            {
            }
            return "";
        }

        public static List<eUser> getUsers()
        {
            List<eUser> ls = new List<eUser>();
            foreach (var tmp in data.Users.ToList())
            {
                ls.Add(customUser(tmp));
            }
            return ls;
        }

        public static eUser customUser(User u)
        {
            return new eUser(u.UserName, u.Password, u.Role, u.Status);
        }

        public static String getRole(String userName)
        {
            return data.Users.Where(x => x.UserName.Trim() == userName).SingleOrDefault().Role;
        }

        public static void editRole(String userName, String Role)
        {
            var user = data.Users.Where(x => x.UserName.Trim() == userName).SingleOrDefault();
            data.Users.DeleteOnSubmit(user);
            user.Role = Role.Trim();
            data.Users.InsertOnSubmit(user);
            data.SubmitChanges();
        }

        public static void addUser(eUser e)
        {
            User u = new User();
            u.UserName = e.UserName;
            u.Password = e.Password;
            u.Role = e.Role1;
            u.Status = e.Status;
            data.Users.InsertOnSubmit(u);
            data.SubmitChanges();
        }
    }
}
