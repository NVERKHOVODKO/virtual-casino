using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGames : Form
    {
        private Form activeForm;
        private User user;
        private FormUser FormUser;
        private Form currentChildForm;
        SongPlayer mediaPlayer;
        static string SONG_WILD_WEST = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\wild_west_3.mp3";
        static string SONG_PIRATES = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\pirate_song_1.wav";
        static string POSTAL_SONG = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\postal_song.mp3";

        


        public FormGames(FormUser FormUser, User user, SongPlayer mediaPlayer)
        {
            this.mediaPlayer = mediaPlayer;
            InitializeComponent();
            this.mediaPlayer = mediaPlayer;
            this.user = user;
            this.FormUser = FormUser;
        }

        private void FormGames_Load(object sender, EventArgs e)
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
                    btns.ForeColor = System.Drawing.Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            if(currentChildForm != null)
            {
                currentChildForm.Close();

            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelGames.Controls.Add(childForm);
            this.panelGames.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGamesSapper(FormUser, user), sender);
            mediaPlayer.playSong(SONG_PIRATES);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGamesWildWest(FormUser, user), sender);
            mediaPlayer.playSong(SONG_WILD_WEST);
        }

        private void buttonGames_2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGamesCrush(user), sender);
            mediaPlayer.playSong(POSTAL_SONG);
        }
    }
}
