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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp3.Forms
{
    public partial class FormEditUser : Form
    {
        FormAdmin fa;
        Database db = new Database();
        string id;

        public FormEditUser(User user)
        {
            fa = new FormAdmin(user);
            id = user.GetId().ToString();

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
            if (textBoxLogin.Text.Length < 3)
            {
                MessageBox.Show("Login must be 3 characters minimum");
                return;
            }
            if (textBoxPassword.Text.Length < 4)
            {
                MessageBox.Show("Password must be 4 characters minimum");
                return;
            }
            if (textBoxAccess.Text == string.Empty)
            {
                MessageBox.Show("Enter access");
                return;
            }
            db.EditUser(textBoxLogin.Text, textBoxPassword.Text, id, textBoxBalance.Text, textBoxAccess.Text);
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
