using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMS.Security
{
    class Security
    {
        private string userid = "";
        private string username = "";
        private string password = "";
        private string email = "";

        public string Userid
        {
            get { return this.userid; }
            set { this.userid = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public bool createlogin()
        {
            return SecurityDA.getInstance().addToDB(this);
        }

        public bool updatelogin()
        {
            return SecurityDA.getInstance().updateDB(this);
        }
    }
}
