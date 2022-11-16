using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private SongPlayer mediaPlayer;
        private static string SONG_WILD_WEST = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\wild_west_3.mp3";


        public FormHome(SongPlayer mediaPlayer, FormUser FormUser, User user)
        {
            InitializeComponent();
            this.user = user;
            this.FormUser = FormUser;
            this.mediaPlayer = mediaPlayer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
