using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODMS.Util
{
    class DBConnection
    {
        private static MySqlConnection connection = null;

        public static void init()
        {
            string connectionString = "server=localhost;user=root;database=ODMS;port=3306;password=";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Connection Successful");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed\n" + ex.ToString());
            }
            connection.Close();
        }
    }
}
