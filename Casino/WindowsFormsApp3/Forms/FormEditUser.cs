using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormEditUser : Form
    {
        FormAdmin fa;

        int id;

        public FormEditUser(User user)
        {
            fa = new FormAdmin();
            id = user.GetId();

            InitializeComponent();
            
            textBoxAccess.Text = user.GetAccess().ToString();
            textBoxBalance.Text = user.GetBalance().ToString();
            textBoxLogin.Text = user.GetLogin();
            textBoxPassword.Text = user.GetPassword();
        }

        


        public void UpdateUser(string id, string login, string password, string access, string balance)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            DataTable datatable = new DataTable();
            string sql = "UPDATE users SET login = @userLogin, password = @userPassword, role = @userRole, balance = @userBalance WHERE id = @userId";
            databaseObject.OpenConnection();
            SQLiteCommand cmd = new SQLiteCommand(sql, databaseObject.myConnection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userLogin", textBoxLogin.Text);
            cmd.Parameters.AddWithValue("@userPassword", textBoxPassword.Text);
            cmd.Parameters.AddWithValue("@userRole", textBoxAccess.Text);
            cmd.Parameters.AddWithValue("@userBalance", textBoxBalance.Text);
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
            this.Close();
        }

        private void textBoxBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
