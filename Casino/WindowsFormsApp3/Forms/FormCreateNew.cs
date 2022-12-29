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
    public partial class FormCreateNew : Form
    {
        public FormCreateNew()
        {
            InitializeComponent();
        }

        private bool getAccess(String access)
        {
            if (access == "0")
                return false;
            else
            {
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "" || textBoxAccess.Text == "")
            {
                MessageBox.Show("Fill in the fields");
            }
            else
            {
                if (textBoxLogin.Text.Length < 4 || textBoxPassword.Text.Length < 4)
                {
                    MessageBox.Show("Login and Password must be more than 4 characters");
                }
                else
                {
                    try
                    {
                        Database databaseObject = new Database();
                        SQLiteCommand cmd = new SQLiteCommand("INSERT INTO users ('balance', 'login', 'password', 'role') VALUES (@balance, @login, @password, @role)", databaseObject.myConnection);
                        databaseObject.OpenConnection();
                        try
                        {
                            cmd.Parameters.AddWithValue("@balance", Int64.Parse(textBoxBalance.Text));
                        }
                        catch
                        {
                            cmd.Parameters.AddWithValue("@balance", Int64.Parse("0"));
                        }
                        cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                        cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                        cmd.Parameters.AddWithValue("@role", Int64.Parse(textBoxAccess.Text));
                        var result = cmd.ExecuteNonQuery();
                        databaseObject.CloseConnection();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Can't create new account");
                    }
                }
            }
        }

        private void panelCreateAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {

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
