using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMS.Admin.User
{
    class User
    {
        private string Username = "";
        private string Firstname = "";
        private string Lastname = "";
        private string email = "";
        private int permission = 0;

        public string UserName
        {
            get { return Username; }
            set { Username = value; }
        }

        public string FirstName
        {
            get { return Firstname; }
            set { Firstname = value; }
        }

        public string LastName
        {
            get { return Lastname; }
            set { Lastname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Permission
        {
            get { return permission; }
            set { permission = value; }
        }


    }
}
