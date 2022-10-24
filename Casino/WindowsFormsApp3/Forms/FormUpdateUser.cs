using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormUpdateUser : Form
    {
        public FormUpdateUser()
        {
            InitializeComponent();




        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "" || textBoxBalance.Text == "" || textBoxAccess.Text == "")
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
                        cmd.Parameters.AddWithValue("@balance", Int64.Parse(textBoxBalance.Text));
                        cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
                        cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                        cmd.Parameters.AddWithValue("@role", Int64.Parse(textBoxAccess.Text));
                        var result = cmd.ExecuteNonQuery();
                        databaseObject.CloseConnection();
                        MessageBox.Show("Your account has been successfully created");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Incorrect data type");
                    }
                }
            }
        }
    }
}
