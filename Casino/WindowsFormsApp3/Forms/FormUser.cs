using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        static string SONG = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\phonk_house.mp3";
        private SongPlayer mediaPlayer = new SongPlayer();

        public FormUser(User user)
        {
            this.user = user;
            InitializeComponent();
            mediaPlayer.playSong(SONG);
            random = new Random(); 
            buttonBack.Visible = false;
            lblLogin.Text = user.GetLogin();
            lblBalanceValue.Text = user.GetBalance().ToString();
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
            if(!mediaPlayer.isSongMain())
            {
                mediaPlayer.playSong(SONG);
            }

            if (activeForm != null)
                activeForm.Dispose();
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
            OpenChildForm(new Forms.FormHome(), sender, "HOME");
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGames(this, user, mediaPlayer), sender, "GAMES");
        }

        private void buttonLiders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        

        private void buttonClose_Click(object sender, EventArgs e)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();

            mediaPlayer.Stop();
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }


        public void ChangeBalanceValue(string value)
        {
            lblBalanceValue.Text = value;
        }

        public void ChangeLoginText(string login)
        {
            lblLogin.Text = login;
        }

        private void btnAccount_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormAccount(mediaPlayer, this, user), sender, "ACCOUNT");
        }

        private void labelMain_Click(object sender, EventArgs e)
        {

        }

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender, "HOME");
        }

        private void btnLiders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLiders(), sender, "LIDERS");
        }
    }
}