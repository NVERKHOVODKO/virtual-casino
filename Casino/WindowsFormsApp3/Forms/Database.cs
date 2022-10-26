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

        public void DropDataBase()
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM users", databaseObject.myConnection);
            databaseObject.OpenConnection();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Can't drop database " + ex.Message);
            }
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
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show("Can't delete " + ex.Message);
            }
            databaseObject.CloseConnection();
        }

        public void Search(string query, DataGridView dgv)
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
