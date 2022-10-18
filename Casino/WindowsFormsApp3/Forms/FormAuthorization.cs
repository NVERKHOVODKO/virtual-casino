using MySql.Data.MySqlClient;
using System;
using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApp3.Forms;
using System.Threading;

namespace WindowsFormsApp3
{
	public partial class FormAuthorization : Form
	{
		private Random random;
		private int tempIndex;
		private Form activeForm;
        private static int balance;


        private static User user;



        public FormAuthorization()
		{
			InitializeComponent();
			random = new Random();
            panelCreateAccount.Visible = false;


        }

        private System.Drawing.Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}

        



		

		private void btnSignIn_Click(object sender, EventArgs e)
		{
            


            SQLiteDataAdapter adapter = new SQLiteDataAdapter();


            Database databaseObject = new Database();
            DataTable datatable = new DataTable();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users WHERE login = @usrLogin AND password = @usrPassword", databaseObject.myConnection);
            databaseObject.OpenConnection();
            cmd.Parameters.AddWithValue("@usrLogin","n");
            cmd.Parameters.AddWithValue("@usrPassword", "n");

            adapter.SelectCommand = cmd;
            adapter.Fill(datatable);
            if (datatable.Rows.Count > 0)
            {
                SQLiteCommand getBalance = new SQLiteCommand("SELECT balance FROM users WHERE login = @usrLogin AND password = @usrPassword", databaseObject.myConnection);
                cmd.Parameters.AddWithValue("@usrLogin", "n");
                cmd.Parameters.AddWithValue("@usrPassword", "n");
                adapter.SelectCommand = cmd;
                OpenChildForm(new FormUser());

				user = new User(Convert.ToInt32(datatable.Rows[0][0].ToString()), datatable.Rows[0][1].ToString(), datatable.Rows[0][2].ToString(), Convert.ToInt32(datatable.Rows[0][3]), Convert.ToInt32(datatable.Rows[0][4]));
                MessageBox.Show(user.Balance.ToString());
                balance = Convert.ToInt32(datatable.Rows[0][0]);
            }
            else
                MessageBox.Show("-");
        }

		public static User GetUser()
		{
			return user;
		}

        public static int GetBalance()
        {
            return balance;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();            
			activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnCreateAccount_Click(object sender, EventArgs e)
		{
            panelCreateAccount.Visible = true;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void labelLogo_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonGames_Click(object sender, EventArgs e)
        {
        }

        private void buttonLiders_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCreateAccount.Visible = false;
            textBoxLoginCreate.Text = "";
            textBoxPasswordCreate.Text = "";
            textBoxPasswordConfirmCreate.Text = "";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string password, login;
            if(textBoxPasswordCreate.Text == textBoxPasswordConfirmCreate.Text)
            {
                if(textBoxPasswordCreate.Text.Length > 4)
                {
                    password = textBoxPasswordCreate.Text;
                    if (textBoxLoginCreate.Text.Length > 4)
                    {
                        login = textBoxLoginCreate.Text;
                        Database databaseObject = new Database();
                        SQLiteCommand cmd = new SQLiteCommand("INSERT INTO users ('balance', 'login', 'password', 'role') VALUES (@balance, @login, @password, @role)", databaseObject.myConnection);
                        databaseObject.OpenConnection();
                        cmd.Parameters.AddWithValue("@balance", 0);
                        cmd.Parameters.AddWithValue("@login", login);
        
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", 1);

                        var result = cmd.ExecuteNonQuery();

                        databaseObject.CloseConnection();

                        MessageBox.Show("Your account has been successfully created");
                        Thread.Sleep(100);
                        panelCreateAccount.Visible = false;
                        textBoxLoginCreate.Text = "";
                        textBoxPasswordCreate.Text = "";
                        textBoxPasswordConfirmCreate.Text = "";
                    }
                    else
                        MessageBox.Show("Login must be more than 4 characters");
                }
                else
                {
                    MessageBox.Show("Password must be more than 4 characters");

                }

                

            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }


        }
    }
}
