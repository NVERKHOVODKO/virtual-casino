using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WindowsFormsApp3.Forms
{
	public partial class FormGamesSapper : Form
	{
		bool isSecondlineActive = false, isThirdlineActive = false, isFourthlineActive = false, isFifthlineActive = false;
		Random rnd = new Random();
        static string BOMB = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\bomb.wav";
        static string SONG_1 = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\pirate_song_1.wav";
        static string SONG_2 = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\pirate_song_2.wav";
        static string SONG_3 = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\pirate_song_3.wav";
        static string KNOCK = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\wooden_knock";
        static string PAPER = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\filing_paper.mp3";
        static string COIN = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\coin.mp3";
        static string SONG;
        bool isBlownedUp = false;
        User user;
        int bet, startBet;

        private void choiseSong()
        {
            switch (rnd.Next(1, 3))
            {
                case 1:
                    SONG = SONG_1;
                    break;
                case 2:
                    SONG = SONG_2;
                    break;
                case 3:
                    SONG = SONG_3;
                    break;
            }
        }

        public FormGamesSapper()
		{
            choiseSong();
            InitializeComponent();
            FormAuthorization fa = new FormAuthorization();
            user = fa.GetUser();
            labelBalance.Text = user.GetBalance().ToString();
            panelInfo.Visible = false;
            panelInfo.Location = new System.Drawing.Point(930,410);
            MediaPlayer song = new MediaPlayer();
            song.Open(new Uri(SONG));
            song.Volume = 0.25;
            song.Play();
            panelFlag.Location = new Point(1200, 20);
            pictureBomb1.Visible = false;
			buttonTake.Visible = false;
            buttonTryAgain.Visible = false;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button15_Click(object sender, EventArgs e)
		{
            activateLine(1, 1, btn1_1, btn1_2, btn1_3);
        }

		private void btn2_3_Click(object sender, EventArgs e)
		{
            activateLine(3, 2, btn2_1, btn2_2, btn2_3);
        }

        private void btn2_2_Click(object sender, EventArgs e)
		{
            activateLine(2, 2, btn2_1, btn2_2, btn2_3);
        }

        private void btn2_1_Click(object sender, EventArgs e)
		{
            activateLine(1, 2, btn2_1, btn2_2, btn2_3);
        }

        private void btn3_3_Click(object sender, EventArgs e)
		{
            activateLine(3, 3, btn3_1, btn3_2, btn3_3);
        }

        private void btn3_2_Click(object sender, EventArgs e)
		{
            activateLine(2, 3, btn3_1, btn3_2, btn3_3);
        }

        private void btn3_1_Click(object sender, EventArgs e)
		{
            activateLine(1, 3, btn3_1, btn3_2, btn3_3);
        }

        private void btn4_3_Click(object sender, EventArgs e)
		{
            activateLine(3, 4, btn4_1, btn4_2, btn4_3);
        }

        private void btn4_2_Click(object sender, EventArgs e)
		{
            activateLine(2, 4, btn4_1, btn4_2, btn4_3);
        }

        private void btn4_1_Click(object sender, EventArgs e)
		{
            activateLine(1, 4, btn4_1, btn4_2, btn4_3);
        }

        private void btn5_3_Click(object sender, EventArgs e)
		{
            activateLine(3, 5, btn5_1, btn5_2, btn5_3);
        }

        private void btn5_2_Click(object sender, EventArgs e)
		{
            activateLine(2, 5, btn5_1, btn5_2, btn5_3);
        }

        private void btn5_1_Click(object sender, EventArgs e)
		{
            activateLine(1, 5, btn5_1, btn5_2, btn5_3);
        }

        private void buttonStart_Click(object sender, EventArgs e)
		{
            if (textBoxBet.Text != "" && (bet > 0 || bet < 1000) && bet <= user.GetBalance())
            {
                if (textBoxBet.Text != "" && textBoxBet.Text != "0")
                {
                    startBet = bet;
                    user.SetBalance(user.GetBalance() - bet);
                    labelBalance.Text = user.GetBalance().ToString();
                    buttonStart.Visible = false;
                    bet = Int32.Parse(textBoxBet.Text);
                    textBoxBet.Enabled = false;
                }
            }
            else if (user.GetBalance() < bet)
            {
                MessageBox.Show("Insuffcieint balance");
                textBoxBet.Text = "";
                bet = 0;
                startBet = 0;
            }
            else
                MessageBox.Show("Place your bet");
        }

		private void buttonTake_Click(object sender, EventArgs e)
		{
            user.SetBalance(user.GetBalance() + bet);
            buttonTake.Visible = false;
            buttonTryAgain.Visible = true;
            MessageBox.Show("You win " + bet);
            playWinSound();
            labelBalance.Text = user.GetBalance().ToString();
        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            btn1_1.Visible = true;
            btn1_2.Visible = true;
            btn1_3.Visible = true;
            btn2_1.Visible = true;
            btn2_2.Visible = true;
            btn2_3.Visible = true;
            btn3_1.Visible = true;
            btn3_2.Visible = true;
            btn3_3.Visible = true;
            btn4_1.Visible = true;
            btn4_2.Visible = true;
            btn4_3.Visible = true;
            btn5_1.Visible = true;
            btn5_2.Visible = true;
            btn5_3.Visible = true;
            pictureBomb1.Visible = false;
            textBoxBet.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
		{
            try
            {
                bet = Int32.Parse(textBoxBet.Text);
                if (bet == 0)
                    textBoxBet.Text = "";
            }
            catch
            {
                textBoxBet.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelWin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBomb1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxBet.Text = startBet.ToString();
            pictureBox1.Image = Properties.Resources.scale_coins_1;
            buttonTryAgain.Visible = false;
            btn1_1.Visible = true;
            btn1_2.Visible = true;
            btn1_3.Visible = true;
            btn2_1.Visible = true;
            btn2_2.Visible = true;
            btn2_3.Visible = true;
            btn3_1.Visible = true;
            btn3_2.Visible = true;
            btn3_3.Visible = true;
            btn4_1.Visible = true;
            btn4_2.Visible = true;
            btn4_3.Visible = true;
            btn5_1.Visible = true;
            btn5_2.Visible = true;
            btn5_3.Visible = true;
            pictureBomb1.Visible = false;
            isBlownedUp = false;
            textBoxBet.Visible = true;
            textBoxBet.Enabled = true;
            buttonStart.Visible = true;
        }

        bool isLineActive(int numOfLine)
        {
            switch(numOfLine)
            {
                case 1:
                    return true;
                case 2:
                    if(isSecondlineActive)
                        return true;
                    break;
                case 3:
                    if (isThirdlineActive)
                        return true;
                    break;
                case 4:
                    if (isFourthlineActive)
                        return true;
                    break;
                case 5:
                    if (isFifthlineActive)
                        return true;
                    break;
            }
            return false;
        }

        private void textBoxBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxBet_MouseEnter(object sender, EventArgs e)
        {

        }

        private void playWinSound()
        {
            MediaPlayer coin = new MediaPlayer();
            coin.Open(new Uri(COIN));
            coin.Volume = 0.7;
            coin.Play();
        }

        private void activateLine(int numOfButton,int numOfLine, Button btn1, Button btn2, Button btn3)
        {
            MediaPlayer knock = new MediaPlayer();
            knock.Open(new Uri(KNOCK));
            knock.Play();
            if (isLineActive(numOfLine) && bet > 0)
            {
                int random = rnd.Next(1, 4);
                pictureBomb1.Visible = true;
          
                switch (random)
                {
                    case 1:
                        pictureBomb1.Location = btn1.Location;
                        break;
                    case 2:
                        pictureBomb1.Location = btn2.Location;
                        break;
                    case 3:
                        pictureBomb1.Location = btn3.Location;
                        break;
                }
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;

                switch (numOfLine)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.scale_coins_1;
                        buttonTake.Visible = true;
                        isSecondlineActive = true;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.scale_coins_2;
                        isThirdlineActive = true;
                        bet *= 2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.scale_coins_3;
                        isFourthlineActive = true;
                        bet /= 2;
                        bet *= 3;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.scale_coins_4;
                        isFifthlineActive = true;
                        bet /= 3;
                        bet *= 4;
                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources.scale_coins_5;
                        bet /= 4;
                        bet *= 5;
                        buttonTake.Visible = false;
                        buttonTake.Visible = false;
                        buttonTryAgain.Visible = true;
                        if (random != numOfButton)
                        {
                            MessageBox.Show("You win " + bet);
                            playWinSound();
                            user.SetBalance(user.GetBalance() + bet);
                            labelBalance.Text = user.GetBalance().ToString();
                        }
                        break;
                }
                if (random == numOfButton)
                {
                    buttonTake.Visible = false;
                    isFifthlineActive = false;
                    isFourthlineActive = false;
                    isThirdlineActive = false;
                    isSecondlineActive = false;
                    buttonTryAgain.Visible = true;
                    isBlownedUp = true;
                    bet = 0;
                    pictureBox1.Image = Properties.Resources.scale_coins_1;
                }
                textBoxBet.Text = bet.ToString();
                if (random == numOfButton)
                {
                    MediaPlayer bomb = new MediaPlayer();
                    bomb.Open(new Uri(BOMB));
                    bomb.Play();
                }
            }
            else
            {
                if (isBlownedUp)
                    MessageBox.Show("You already lost");
                else if (bet < 1)
                    MessageBox.Show("Place a bet");
                else
                    MessageBox.Show("Unlock bottom buttons");
            }
        }

        private void btn1_2_Click(object sender, EventArgs e)
		{
			activateLine(2, 1, btn1_1, btn1_2, btn1_3);
		}

		private void btn1_3_Click(object sender, EventArgs e)
		{
            activateLine(3, 1, btn1_1, btn1_2, btn1_3);
        }
	}
}