using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODMS.Admin.User;

namespace ODMS.Security
{
    class LoginValidate
    {
        Security securityInfo = null;
        private string userid = null;
        private string password = null;

        public LoginValidate(string userid, string password)
        {
            this.userid = userid;
            this.password = password;
        }

        public bool validateLogin()
        {
            if (CheckUser())
            {
                if (CheckPassword())
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
            
        }

        private bool CheckUser()
        {
            securityInfo = SecurityDA.getInstance().readFromDB(this.userid);

            if (!(securityInfo == null))
            {
                return true;
            }

            return false;
        }

        private bool CheckPassword()
        {
            if (String.Compare(securityInfo.Password,this.password) == 0)
                return true;

            return false;
        }
    }
}
