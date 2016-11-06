using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.TichHop
{
    public class eUser
    {
        private String userName;
        private String password;
        private String Role;
        private System.Nullable<bool> status;

        public eUser(String userName, String password, String Role, System.Nullable<bool> status)
        {
            this.UserName = userName;
            this.Password = password;
            this.Role1 = Role;
            this.Status = status;
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Role1
        {
            get
            {
                return Role;
            }

            set
            {
                Role = value;
            }
        }

        public bool? Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }


        // override object.Equals
        public override bool Equals(object obj)
        {
            return this.userName.Trim().Equals(((eUser)obj).userName.Trim());
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}
