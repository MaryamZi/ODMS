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
                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed\n" + ex.ToString());
            }
            connection.Close();
        }

        public static MySqlDataReader readQuerry(string querry)
        {
            MySqlDataReader reader = null;

            openConnection();

            MySqlCommand command = new MySqlCommand(querry,connection);

            reader = command.ExecuteReader();

            return reader;

        }

        public static bool writeQuerry(string querry)
        {
            MySqlCommand command = new MySqlCommand(querry,connection);

            if (command.ExecuteNonQuery() > 0)
                return true;

            return false;
        }

        public static void openConnection()
        {
            try
            {
                connection.Close();
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
