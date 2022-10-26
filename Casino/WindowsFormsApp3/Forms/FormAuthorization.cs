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
        bool isPasswordVisible, isPasswordVisible1;
        private User user;

        public FormAuthorization()
		{
			InitializeComponent();
			random = new Random();
            panelCreateAccount.Visible = false;
            isPasswordVisible = true;
            isPasswordVisible1 = true;

            hidePassword();
        }

        private void hidePassword()
        {
            btnIsPasswordVisible.BackgroundImage = Properties.Resources.closed_eye;
            btnIsPasswordVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            isPasswordVisible = true;
            textBoxPassword.UseSystemPasswordChar = true;
            btnIsPasswordVisible1.BackgroundImage = Properties.Resources.closed_eye;
            btnIsPasswordVisible1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; 
            isPasswordVisible1 = true;
            textBoxPasswordCreate.UseSystemPasswordChar = true;
            textBoxPasswordConfirmCreate.UseSystemPasswordChar = true;
        }

        private void showPassword()
        {
            btnIsPasswordVisible.BackgroundImage = Properties.Resources.opened_eye;
            btnIsPasswordVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            textBoxPassword.UseSystemPasswordChar = false;
            isPasswordVisible = false;
            btnIsPasswordVisible1.BackgroundImage = Properties.Resources.opened_eye;
            btnIsPasswordVisible1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch; textBoxPasswordCreate.UseSystemPasswordChar = true;
            textBoxPasswordCreate.UseSystemPasswordChar = false;
            textBoxPasswordConfirmCreate.UseSystemPasswordChar = false;
            isPasswordVisible1 = false;
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
            if (textBoxLogin.Text.Length < 3 || textBoxPassword.Text.Length < 3)
            {
                MessageBox.Show("Fill in the fields");
                user = new User(1, "login", "password", 1, 10000000);
                OpenChildForm(new FormUser(user));
            }
            else
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                Database databaseObject = new Database();
                DataTable datatable = new DataTable();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users WHERE login = @usrLogin AND password = @usrPassword", databaseObject.myConnection);
                databaseObject.OpenConnection();
                cmd.Parameters.AddWithValue("@usrLogin", textBoxLogin.Text);
                cmd.Parameters.AddWithValue("@usrPassword", textBoxPassword.Text);
                adapter.SelectCommand = cmd;
                adapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {
                    user = new User(Convert.ToInt32(datatable.Rows[0][0].ToString()), datatable.Rows[0][1].ToString(), datatable.Rows[0][2].ToString(), Convert.ToInt32(datatable.Rows[0][3]), Convert.ToInt32(datatable.Rows[0][4]));
                    if(user.GetAccess() == 1)
                    {
                        OpenChildForm(new FormAdmin());
                    }
                    else
                    {
                        OpenChildForm(new FormUser(user));
                    }
                }
                else
                    MessageBox.Show("Incorrect login or password");
            }/*
            user = new User(13, "Login", "password", 1, 483953);
            OpenChildForm(new FormUser());*/
        }

        public User GetUser()
        {
            return user;
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
            btnIsPasswordVisible.Visible = false;
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
            btnIsPasswordVisible.Visible = true;
        }

        private bool isLoginUnic()
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            Database databaseObject = new Database();
            DataTable datatable = new DataTable();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM users WHERE login = @usrLogin", databaseObject.myConnection);
            databaseObject.OpenConnection();
            cmd.Parameters.AddWithValue("@usrLogin", textBoxLoginCreate.Text);
            adapter.SelectCommand = cmd;
            adapter.Fill(datatable);

            if (datatable.Rows.Count > 0)
            {
                return false;
            }
            else
                return true;

        }

        private void clearTextboxes(string message)
        {
            MessageBox.Show(message);
            textBoxPasswordConfirmCreate.Text = "";
            textBoxPasswordCreate.Text = "";
            textBoxLoginCreate.Text = "";
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            string password, login;
            if(textBoxLoginCreate.Text == "" && textBoxPasswordConfirmCreate.Text == "" && textBoxPasswordCreate.Text == "")
            {
                clearTextboxes("Fill in the fields");
                return;
            }
            if (!isLoginUnic())
            {
                clearTextboxes("This login is already taken");
                return;
            }
            if (textBoxPasswordCreate.Text != textBoxPasswordConfirmCreate.Text)
            {
                clearTextboxes("Passwords do not match");
                return;
            }
            if (textBoxPasswordCreate.Text.Length < 4)
            {
                clearTextboxes("Password must be more than 4 characters");
                return;
            }
            if (textBoxLoginCreate.Text.Length > 4)
            {
                clearTextboxes("Login must be more than 4 characters");
                return;
            }

            password = textBoxPasswordCreate.Text;
            login = textBoxLoginCreate.Text;
            Database databaseObject = new Database();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO users ('balance', 'login', 'password', 'role') VALUES (@balance, @login, @password, @role)", databaseObject.myConnection);
            databaseObject.OpenConnection();
            cmd.Parameters.AddWithValue("@balance", 100);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@role", 0);
            var result = cmd.ExecuteNonQuery();
            databaseObject.CloseConnection();
            panelCreateAccount.Visible = false;
            clearTextboxes("Your account has been successfully created");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(isPasswordVisible == true)
            {
                showPassword();
            }
            else
            {
                hidePassword();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (isPasswordVisible1 == true)
            {
                showPassword();
            }
            else
            {
                hidePassword();
            }
        }
    }
}
