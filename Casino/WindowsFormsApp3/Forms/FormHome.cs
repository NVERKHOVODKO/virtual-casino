using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp3.Forms
{
    public partial class FormHome : Form
    {
        private Form activeForm;
        private FormUser FormUser;
        private User user;
        int numOfSeconds = 0;
        double volume;
        bool isMusicPlayed = false;
        private SongPlayer mediaPlayer;
        private static string SONG_WILD_WEST = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\wild_west_3.mp3";
        private static string NEW_YEAR_SONG = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\perezvon_kolokolov.mp3";

       
        public FormHome(SongPlayer mediaPlayer, FormUser FormUser, User user)
        {
            InitializeComponent();
            this.user = user;
            this.FormUser = FormUser;
            this.mediaPlayer = mediaPlayer;
            Panel pnl = new Panel();
            pnl.SetRoundedShape(button2, 30);
            SetLabelsTextWinings();
        }

        private void OpenChildForm(Form childForm, object btnSender, string titleText)
        {
            if (activeForm != null)
                activeForm.Dispose();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelHome.Controls.Add(childForm);
            this.panelHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGamesWildWest(FormUser, user), sender, "GAMES");
            mediaPlayer.playSong(SONG_WILD_WEST);
        }

        private void SetLabelsTextWinings()
        {
            string[] logins = new string[10] { "nverkhovodko", "nkuprianov", "botik", "dubinchik", "Paul", "masterAWP", "DMaster", "Messi", "Michael1998", "Gamer"};
            Random rnd = new Random();
            int a = rnd.Next(1, 9);
            int l1 = 0, l2 = 1, l3 = 2;
            switch (rnd.Next(1, 9))
            {
                case 0:
                    l1 = 0;
                    l2 = 2;
                    l3 = 3;
                    break;
                case 1:
                    l1 = 1;
                    l2 = 2;
                    l3 = 5;
                    break;
                case 2:
                    l1 = 0;
                    l2 = 4;
                    l3 = 9;
                    break;
                case 3:
                    l1 = 1;
                    l2 = 2;
                    l3 = 9;
                    break;
                case 4:
                    l1 = 0;
                    l2 = 4;
                    l3 = 8;
                    break;
                case 5:
                    l1 = 0;
                    l2 = 2;
                    l3 = 3;
                    break;
                case 6:
                    l1 = 1;
                    l2 = 7;
                    l3 = 0;
                    break;
                case 7:
                    l1 = 8;
                    l2 = 4;
                    l3 = 3;
                    break;
            }
            label2.Text = logins[l1] + ": " + rnd.Next(700, 2000).ToString();
            label3.Text = logins[l2] + ": " + rnd.Next(500, 700).ToString();
            label4.Text = logins[l3] + ": " + rnd.Next(300, 500).ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button2.Dispose();
            if (!isMusicPlayed)
            {
                volume = mediaPlayer.GetVolume();
                mediaPlayer.SetVolume(0);
                SongPlayer mp = new SongPlayer();
                mp.playSong(NEW_YEAR_SONG);
                isMusicPlayed = true;
                timer1.Enabled = true;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            numOfSeconds++;
            if(numOfSeconds > 110)
            {
                mediaPlayer.SetVolume(volume);
                timer1.Enabled = false;
                timer1.Stop();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
