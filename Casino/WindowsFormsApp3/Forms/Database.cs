using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
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
            
            dataGridView1.Columns[2].ReadOnly = true;
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

        public void UpdateBalance(string id, int balance)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            DataTable datatable = new DataTable();
            string sql = "UPDATE users SET balance = @userBalance WHERE id = @userId";
            databaseObject.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand(sql, databaseObject.myConnection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userBalance", balance.ToString());
            cmd.Parameters.AddWithValue("@userId", id);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error. Can't update balance in data base");
            }
            databaseObject.CloseConnection();
        }

        public void SearchInDataBase(string query, DataGridView dgv)
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

        public void GetLidersFromDataBase(List<string> logins, List<string> balances)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            DataTable datatable = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users ORDER BY balance LIMIT 10", databaseObject.myConnection);
            databaseObject.OpenConnection();
            adapter.SelectCommand = cmd;
            adapter.Fill(datatable);

            for(int i = 0; i < 10; i++)
            {
                logins.Add((string)datatable.Rows[i][1]);
                balances.Add((string)datatable.Rows[i][4].ToString());
            }

            databaseObject.CloseConnection();
        }

        public void EditUser(string login, string password, string id, string balance, string access)
        {
            if (login.Length < 3)
            {
                MessageBox.Show("Login must be 3 characters minimum");
                return;
            }
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be 4 characters minimum");
                return;
            }
            if (balance == string.Empty)
            {
                balance = "0";
                return;
            }
            if (access == string.Empty)
            {
                access = "1";
                return;
            }
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
    }
}
