using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMS.Admin.User
{
    class UserDA:Util.DBCom<User,string>
    {
        private static UserDA instance = null;
        private User existing = null;

        public static UserDA getInstance()
        {
            if (instance == null)
            {
                instance = new UserDA();
            }

            return instance;
        }

        public bool addToDB(User newuser)
        {
            return true;
        }

        public bool updateDB(User existingUser)
        {
            return true;
        }

        public User readFromDB(string username)
        {
            return existing;
        }
    }
}
