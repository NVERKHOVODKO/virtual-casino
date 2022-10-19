using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApp3.Forms;

namespace WindowsFormsApp3
{
    public partial class FormUser : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private User user;
        private int balance;

        public FormUser()
        {
            InitializeComponent();
            random = new Random(); 
            buttonBack.Visible = false;
            FormAuthorization fa = new FormAuthorization();

            user = fa.GetUser();
            lblLogin.Text = user.GetLogin();
            lblBalanceValue.Text = user.GetBalance().ToString();
            balance = user.GetBalance();
        }
        
        private void OpenForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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

        private void ActivateButton(object btnSender)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri(@"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\button_gta.mp3"));
            mediaPlayer.Play();
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    System.Drawing.Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = System.Drawing.Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    buttonBack.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender, string titleText)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelMain.Text = titleText;

        }

        private void Reset()
        {
            DisableButton();
            panelTitle.Text = "HOME";
            panelTitle.BackColor = System.Drawing.Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = System.Drawing.Color.FromArgb(39, 39, 58);
            currentButton = null;
            buttonBack.Visible = false;
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender, "Home");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGames(), sender, "GAMES");
        }

        private void buttonLiders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);

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
            MediaPlayer mediaPlayer = new MediaPlayer();

            mediaPlayer.Stop();
            if (activeForm != null)
                activeForm.Close();
            Reset();
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

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAccount(), sender, "ACCOUNT");
        }

        private void labelMain_Click(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("text");
        }*/

        private void lblBalence_Click(object sender, EventArgs e)
        {

        }

        private void lblBalanceValue_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://1xbet.by/");
            MessageBox.Show("Link copied");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.instagram.com/1xbet.official/?hl=en");
            MessageBox.Show("Link copied");
        }

        private void btnTelegram_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://telegram.me/xBetChannel");
            MessageBox.Show("Link copied");
        }
    }
}
