using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Forms
{
    internal class Database
    {
        MySqlConnection connection = new MySqlConnection("server=casino;port=3306;username=root;password=root;database=casino");


        public void openConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
