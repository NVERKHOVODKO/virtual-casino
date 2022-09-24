using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAccount : Form
    {
        private Form activeForm;
        public FormAccount()
        {
            InitializeComponent();
        }

        private void Form__Account_Load(object sender, EventArgs e)
        {

        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelAccount.Controls.Add(childForm);
            this.panelAccount.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                Balance = 0,
                Access = 1
            };
            /*var setter = account.Set("AccountList/", account);
            MessageBox.Show("Success");*/

        }

        private void panelAccount_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
