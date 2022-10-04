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
using MySql.Data.MySqlClient;

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
            String loginUser = textBoxLogin.Text;
            String passwordUser = textBoxPassword.Text;


            Database database = new Database();
            DataTable datatable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM accounts WHERE login = loginUser AND password = passwordUser", database.getConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(datatable);

            if (datatable.Rows.Count > 0)
                MessageBox.Show("+"); 
            MessageBox.Show("-");
        }

        private void panelAccount_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
