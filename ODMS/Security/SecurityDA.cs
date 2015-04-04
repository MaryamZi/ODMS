using MySql.Data.MySqlClient;
using ODMS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMS.Security
{
    class SecurityDA:DBCom<Security,string>
    {
        private static SecurityDA instance = null;

        public static SecurityDA getInstance()
        {
            if (instance == null)
            {
                instance = new SecurityDA();
            }

            return instance;
        }

        public bool addToDB(Security login)
        {
            string querry = "INSERT INTO `ODMS`.`login` (`user_id`, `username`, `email`, `password`) VALUES ('" + login.Userid + "', '" + login.Username+ "', '" + login.Email + "', '" + login.Password + "');";
            
            DBConnection.openConnection();
            bool result = DBConnection.writeQuerry(querry);
            DBConnection.closeConnection();

            return result;


        }

        public bool updateDB(Security login)
        {
            string querry = "UPDATE `ODMS`.`login` SET `password` = '" + login.Password + "', `email` = '" + login.Email + "'  WHERE `secure`.`UserName` = '" + login.Userid + "';";

            DBConnection.openConnection();
            bool result = DBConnection.writeQuerry(querry);
            DBConnection.closeConnection();

            return result;
        }

        public Security readFromDB(string userid)
        {
            string querry = "SELECT * FROM `login` WHERE `user_id`='" + userid + "';";

            DBConnection.openConnection();

            MySqlDataReader securityReader = DBConnection.readQuerry(querry);

            if (securityReader.Read())
            {
                Security newlogin = new Security();

                newlogin.Userid = securityReader.GetString(0);
                newlogin.Username = securityReader.GetString(1);
                newlogin.Email = securityReader.GetString(2);
                newlogin.Password = securityReader.GetString(3);
                return newlogin;
            }

            return null;

        }
    }
}
