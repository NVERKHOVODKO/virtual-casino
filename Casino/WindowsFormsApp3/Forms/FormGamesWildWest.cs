using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGamesWildWest : Form
    {
        static string COIN = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\coin.mp3";
        static string BUTTON = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\button.mp3";
        static string LOSE = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\lose.mp3";
        static string AUGH = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\aughhhhhh.mp3";
        static string SONG = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\wild_west_3.mp3";
        static string SPIN = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\spin.wav";
        static string PAPER = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\filing_paper.mp3";


        Alert alert = new Alert();
        Random rnd = new Random();
        int a, b, c, move, bet, balance;
        bool isBtnStartActive = true;
        MediaPlayer song = new MediaPlayer();
        bool isSpining = false;
        User user;
        FormUser fu = new FormUser();
        MediaPlayer spin = new MediaPlayer();


        public FormGamesWildWest()
        {
            InitializeComponent();
            FormAuthorization fa = new FormAuthorization();
            user = fa.GetUser();

            panelInfo.Location = new System.Drawing.Point(1030, 400);
            panelInfo.Visible = false;
            panelLogInfo.Location = label2.Location = new System.Drawing.Point(1300, 650);
            label2.BackColor = Color.FromArgb(0, 23, 23, 23);
            label2.ForeColor = Color.Black;
            label2.Location = new System.Drawing.Point(1160, 55);

            label2.Text = user.GetBalance().ToString();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            textBoxBet.Text = "Place your bet";
            LblTitle.Text = "------------------------------------------------------------------";


            pictureBox1.Size = new System.Drawing.Size(120, 120);
            pictureBox2.Size = new System.Drawing.Size(120, 120);
            pictureBox3.Size = new System.Drawing.Size(120, 120);
            isBtnStartActive = false;
            song.Open(new Uri(SONG));
            song.Volume = 0.35;
            song.Play();

            panelLogInfo.MouseEnter += new EventHandler(panelLogInfo_MouseEnter);
            panelLogInfo.MouseLeave += new EventHandler(panelLogInfo_MouseLeave);

        }


        void panelLogInfo_MouseLeave(object sender, EventArgs e)
        {
            MediaPlayer coin = new MediaPlayer();
            coin.Open(new Uri(PAPER));
            coin.Play();
            panelInfo.Visible = false;
        }

        private void panelLogInfo_MouseEnter(object sender, EventArgs e)
        {
            MediaPlayer coin = new MediaPlayer();
            coin.Open(new Uri(PAPER));
            coin.Play();
            panelInfo.Visible = true;
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
            addBet(100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addBet(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addBet(20);
        }

        private void addBet(int bet1)
        {
            playCoinSound();
            if(bet + bet1 <= user.GetBalance())
                bet += bet1;
            else
                MessageBox.Show("Insuffcieint balance");
            textBoxBet.Text = bet.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addBet(1);
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
            MediaPlayer aughhhh = new MediaPlayer();
            aughhhh.Open(new Uri(AUGH));
            aughhhh.Play();
            if (!isSpining)
            {
                
                textBoxBet.Text = "Place your bet";
                bet = 0;
            }
            else
            {
                MessageBox.Show("Wait!");
            }
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            playCoinSound();
            bet = user.GetBalance();
            textBoxBet.Text = bet.ToString();
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblTitle.BackColor = System.Drawing.Color.Yellow;
            try
            {
                bet = Int32.Parse(textBoxBet.Text);
            }
            catch
            {
                textBoxBet.Text = "Place your bet";
            }
            if (isBtnStartActive && bet <= user.GetBalance())
            {
                LblTitle.Text = "----------------------------------------------------------------";
                MediaPlayer button = new MediaPlayer();
                button.Open(new Uri(BUTTON));
                button.Play();
                if (textBoxBet.Text != "" && textBoxBet.Text != "0")
                {
                    user.SetBalance(user.GetBalance() - bet);
                    label2.Text = user.GetBalance().ToString();
                    timer1.Enabled = true;
                    isBtnStartActive = false;
                }
            } else if(user.GetBalance() < bet){
                MessageBox.Show("Insuffcieint balance");
            }
            else
                MessageBox.Show("Place your bet");
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
                case 8:
                    pictureBox.Image = Properties.Resources.cola;
                    break;
            }
}


        private void timer1_Tick(object sender, EventArgs e)
        {
            spin.Open(new Uri(SPIN));
            int numberOfMoving = 20;
            int isSpined = 5;
            if(move < numberOfMoving){

                spin.Volume = 0.07;
                spin.Play();

                move++;
                a = rnd.Next(1, 8);
                b = rnd.Next(1, 8);
                c = rnd.Next(1, 8);

                changeImage(pictureBox1, a);
                changeImage(pictureBox2, b);
                changeImage(pictureBox3, c);
                isSpining = true;
            }
            else
            {
                timer1.Enabled = false;

                MediaPlayer coin = new MediaPlayer();   
                if (a == b && a == c)
                {
                    if (a == 7)
                    {
                        bet *= 10;
                        LblTitle.Text = "---X10--- You win " + bet + "! Three matches!------";
                        LblTitle.BackColor = System.Drawing.Color.Red;
                        //alert.ShowAlert("You win " + bet * 30 +  "!", Alert.enmType.Success);
                    }
                    else
                    {
                        bet *= 5;
                        LblTitle.Text = "---X5--- You win " + bet + "! Three matches!------";
                        LblTitle.BackColor = System.Drawing.Color.Red;
                        //alert.ShowAlert("You win " + bet * 10 + "!", Alert.enmType.Success);
                    }
                    isBtnStartActive = true;
                    coin.Open(new Uri(COIN));
                    coin.Play();
                }
                else if (a == b || a == c)
                {
                    bet *= 2;
                    LblTitle.Text = "---X2--- You win " + bet + "! Two matches!------";
                    isBtnStartActive = true;
                    coin.Open(new Uri(COIN));
                    coin.Play();
                }
                else if (b == c)
                {
                    bet *= 2;
                    LblTitle.Text = "---X2--- You win " + bet + "! Two matches!------";
                    isBtnStartActive = true;
                    coin.Open(new Uri(COIN));
                    coin.Play();
                }
                else if (move == numberOfMoving)
                {
                    LblTitle.Text = "-------------------No matches----------------------";
                    MediaPlayer mediaPlayer = new MediaPlayer();
                    mediaPlayer.Open(new Uri(LOSE));
                    mediaPlayer.Play();
                    //alert.ShowAlert("You lose!", Alert.enmType.Error);
                    isBtnStartActive = true;
                    bet = 0;
                }
                user.SetBalance(user.GetBalance() + bet);

                label2.Text = user.GetBalance().ToString();
                move = 0;
                isSpining = false;
            }

        }
    }
}