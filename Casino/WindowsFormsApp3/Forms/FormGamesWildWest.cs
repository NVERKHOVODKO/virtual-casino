using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGamesWildWest : Form
    {
        static string COIN = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\coin.mp3";
        static string BUTTON = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\button.mp3";
        static string LOSE = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\lose.mp3";
        static string AUGH = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\aughhhhhh.mp3";
        static string SONG = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\wild_west_3.mp3";


        Alert alert = new Alert();
        Random rnd = new Random();
        int a, b, c, move, bet;
        bool isBtnStartActive = true;
        MediaPlayer song = new MediaPlayer();


        public FormGamesWildWest()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            textBoxBet.Text = "Place your bet";
            LblTitle.Text = "------------------------------------------------";


            pictureBox1.Size = new Size(120, 120);
            pictureBox2.Size = new Size(120, 120);
            pictureBox3.Size = new Size(120, 120);
            isBtnStartActive = false;
            song.Open(new Uri(SONG));
            song.Volume = 0.5;
            song.Play();

        }

        private void FormCasino_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void textBoxBet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bet = Int32.Parse(textBoxBet.Text);
                if (bet == 0)
                    textBoxBet.Text = "Place your bet";
                isBtnStartActive = true;
            }
            catch
            {
                isBtnStartActive = false;
                textBoxBet.Text = "Place your bet";
            }
        }

        private void playCoinSound()
        {
            MediaPlayer coin = new MediaPlayer();
            coin.Open(new Uri(BUTTON));
            coin.Play();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            playCoinSound();
            bet += 100;
            textBoxBet.Text = bet.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playCoinSound();
            bet += 5;
            textBoxBet.Text = bet.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playCoinSound();
            bet += 20;
            textBoxBet.Text = bet.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playCoinSound();
            bet += 1;
            textBoxBet.Text = bet.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MediaPlayer coin = new MediaPlayer();
            coin.Open(new Uri(AUGH));
            coin.Play();
            textBoxBet.Text = "Place your bet";
            bet = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblTitle.BackColor = System.Drawing.Color.Yellow;
            if (isBtnStartActive)
            {
                LblTitle.Text = "------------------------------------------------";
                MediaPlayer button = new MediaPlayer();
                button.Open(new Uri(BUTTON));
                button.Play();
                if (textBoxBet.Text != "" && textBoxBet.Text != "0")
                {
                    bet = Int32.Parse(textBoxBet.Text);
                    timer1.Enabled = true;
                    isBtnStartActive = false;
                }
            }
        }


        private void changeImage(PictureBox pictureBox, int numOfPicture)
        {
            switch (numOfPicture)
            {
                case 1:
                    pictureBox.Image = Properties.Resources.rum;
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources.hat;
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources.cactoos;
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources.chiken;
                    break;
                case 5:
                    pictureBox.Image = Properties.Resources.gun;
                    break;
                case 6:
                    pictureBox.Image = Properties.Resources.barrel;
                    break;
                case 7:
                    pictureBox.Image = Properties.Resources.money_sack;
                    break;
            }
}


        private void timer1_Tick(object sender, EventArgs e)
        {
            int numberOfMoving = 10;
            if(move < numberOfMoving){

                move++;
                a = rnd.Next(1, 8);
                b = rnd.Next(1, 8);
                c = rnd.Next(1, 8);

                changeImage(pictureBox1, a);
                changeImage(pictureBox2, b);
                changeImage(pictureBox3, c);

            }
            else
            {
                timer1.Enabled = false;

                MediaPlayer coin = new MediaPlayer();   
                if (a == b && a == c)
                {
                    if (a == 7)
                    {
                        LblTitle.Text = "-X10- You win " + bet * 10 + "! Three matches!--";
                        LblTitle.BackColor = System.Drawing.Color.Red;
                        //alert.ShowAlert("You win " + bet * 30 +  "!", Alert.enmType.Success);
                    }
                    else
                    {
                        LblTitle.Text = "-X5- You win " + bet * 5 + "! Three matches!--";
                        LblTitle.BackColor = System.Drawing.Color.Red;
                        //alert.ShowAlert("You win " + bet * 10 + "!", Alert.enmType.Success);
                    }
                    isBtnStartActive = true;
                    coin.Open(new Uri(COIN));
                    coin.Play();
                }
                else if (a == b || a == c)
                {
                    LblTitle.Text = "-X2-- You win " + (bet * 2) + "! Two matches!--";
                    isBtnStartActive = true;
                    coin.Open(new Uri(COIN));
                    coin.Play();
                }
                else if (b == c)
                {
                    LblTitle.Text = "-X2-- You win " + (bet * 2) + "! Two matches!--";
                    isBtnStartActive = true;
                    coin.Open(new Uri(COIN));
                    coin.Play();
                }
                else if (move == numberOfMoving)
                {
                    LblTitle.Text = "-----------------No matches-----------------";
                    MediaPlayer mediaPlayer = new MediaPlayer();
                    mediaPlayer.Open(new Uri(LOSE));
                    mediaPlayer.Play();
                    //alert.ShowAlert("You lose!", Alert.enmType.Error);
                    isBtnStartActive = true;
                }

                move = 0;
            }

        }
    }
}