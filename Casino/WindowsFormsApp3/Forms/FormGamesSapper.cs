using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using Panel = WindowsFormsApp3.Forms.Panel;


namespace WindowsFormsApp3.Forms
{
	public partial class FormGamesSapper : Form
	{
		bool isSecondlineActive = false, isThirdlineActive = false, isFourthlineActive = false, isFifthlineActive = false, isFirstineActive = false;
		Random rnd = new Random();
        static string BOMB = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\bomb.wav";
        static string PAPER = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\filing_paper.mp3";
        static string COIN = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\coin.mp3";
        static string BOX = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\wooden_sound.mp3";
        bool isBlownedUp = false;
        public MediaPlayer song = new MediaPlayer();
        User user;
        int bet, startBet;
        private FormUser FormUser;
        public Form Creator;
        private Database db = new Database();

        public FormGamesSapper(FormUser FormUser, User user)
		{
            InitializeComponent();
            this.user = user;
            this.FormUser = FormUser;
            Panel pnl = new Panel();
            pnl.SetRoundedShape(panel3, 50);
            pnl.SetRoundedShape(panelBoxes, 15);
            labelBalance.Text = user.GetBalance().ToString();
            panelInfo.Visible = false;
            panelInfo.Location = new System.Drawing.Point(1000,410);
            panelFlag.Location = new Point(1070, 0);
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
                    db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
                    labelBalance.Text = user.GetBalance().ToString();
                    FormUser.ChangeBalanceValue(user.GetBalance().ToString());
                    buttonStart.Visible = false;
                    bet = Int32.Parse(textBoxBet.Text);
                    textBoxBet.Enabled = false;
                    isFirstineActive = true;
                }
            }
            else if (user.GetBalance() < bet)
            {
                MessageBox.Show("Insuffcieint balance");
                textBoxBet.Text = "";
                bet = 0;
            }
            else
                MessageBox.Show("Place your bet");
        }

		private void buttonTake_Click(object sender, EventArgs e)
		{
            textBoxBet.Enabled = true;
            user.SetBalance(user.GetBalance() + bet);
            db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
            buttonTake.Visible = false;
            buttonTryAgain.Visible = true;
            MessageBox.Show("You win " + bet);
            playWinSound();
            labelBalance.Text = user.GetBalance().ToString();
            FormUser.ChangeBalanceValue(user.GetBalance().ToString());
            isFirstineActive = false;
        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            if (textBoxBet.Text != "" && bet > 0 && bet <= user.GetBalance())
            {
                if (textBoxBet.Text != "" && textBoxBet.Text != "0")
                {
                    user.SetBalance(user.GetBalance() - bet);
                    db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
                    labelBalance.Text = user.GetBalance().ToString();
                    FormUser.ChangeBalanceValue(user.GetBalance().ToString());
                    buttonStart.Visible = false;
                    bet = Int32.Parse(textBoxBet.Text);
                    isFirstineActive = true;
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
                    isFirstineActive = true;
                }
            }
            else if (user.GetBalance() < bet)
            {
                MessageBox.Show("Insuffcieint balance");
                textBoxBet.Text = "";
                bet = 0;
            }
            else
                MessageBox.Show("Place your bet");
            MessageBox.Show(bet.ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            isFifthlineActive = false;
            isFourthlineActive = false;
            isThirdlineActive = false;
            isSecondlineActive = false;
            try
            {
                bet = Int16.Parse(textBoxBet.Text);
                startBet = bet;
            }
            catch
            {
                MessageBox.Show("Incorrect bet");
                return;
            }
            if(bet > user.GetBalance())
            {
                MessageBox.Show("Insufficient balance");
                return;
            }
            user.SetBalance(user.GetBalance() - bet);
            db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
            labelBalance.Text = user.GetBalance().ToString();
            FormUser.ChangeBalanceValue(user.GetBalance().ToString());
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
            isFirstineActive = true;
            textBoxBet.Enabled = false;

        }

        bool isLineActive(int numOfLine)
        {
            switch(numOfLine)
            {
                case 1:
                    if (isFirstineActive)
                        return true;
                    break;
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
            knock.Open(new Uri(BOX));
            knock.Play();
            if (isLineActive(numOfLine) && bet > 0)
            {
                int random = rnd.Next(1, 3);
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
                            MessageBox.Show("You win " + (startBet * 5).ToString());
                            playWinSound();
                            user.SetBalance(user.GetBalance() + bet);
                            db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
                            labelBalance.Text = user.GetBalance().ToString();
                            textBoxBet.Enabled = true;
                        }
                        break;
                }
                if (random == numOfButton)
                {
                    MediaPlayer bomb = new MediaPlayer();
                    bomb.Open(new Uri(BOMB));
                    bomb.Play();
                    buttonTake.Visible = false;
                    isFifthlineActive = false;
                    isFourthlineActive = false;
                    isThirdlineActive = false;
                    isSecondlineActive = false;
                    buttonTryAgain.Visible = true;
                    isBlownedUp = true;
                    bet = 0;
                    textBoxBet.Enabled = true;
                    pictureBox1.Image = Properties.Resources.scale_coins_1;
                }
                FormUser.ChangeBalanceValue(user.GetBalance().ToString());
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