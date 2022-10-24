using MySqlX.XDevAPI;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=casino.db");
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
            Console.Read();
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        public void UpdateUser(User user, string id, string login, string password, int access, int balance)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            DataTable datatable = new DataTable();
            string sql = "UPDATE users SET login = @userLogin, password = @userPassword, role = @userRole, balance = @userBalance WHERE id = @userId";
            databaseObject.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand(sql, databaseObject.myConnection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userLogin", login);
            cmd.Parameters.AddWithValue("@userPassword", password);
            cmd.Parameters.AddWithValue("@userRole", access);
            cmd.Parameters.AddWithValue("@userBalance", balance);
            cmd.Parameters.AddWithValue("@userId", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edited succesfully");
            }
            catch
            {
                MessageBox.Show("Error. Can't update user");
            }
            databaseObject.CloseConnection();
        }

        public void UpdateTable(DataGridView dataGridView1)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            DataTable datatable = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users", databaseObject.myConnection);
            databaseObject.OpenConnection();
            adapter.SelectCommand = cmd;
            adapter.Fill(datatable);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns["Id"].ReadOnly = true;
            databaseObject.CloseConnection();
        }

        public void DeleteUser(string id)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM users WHERE id = @usrId", databaseObject.myConnection);
            databaseObject.OpenConnection();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@usrId", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfuly");
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show("Can't delete " + ex.Message);
            }
            databaseObject.CloseConnection();
        }

        public void sendQueryToDatabase(string query, DataGridView dgv)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            SQLiteCommand cmd = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.OpenConnection();
            adapter.SelectCommand = cmd;
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            dgv.DataSource = datatable;
            databaseObject.CloseConnection();
        }
    }
}
