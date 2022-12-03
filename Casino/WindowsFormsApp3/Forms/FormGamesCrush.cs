using Google.Protobuf.WellKnownTypes;
using System;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGamesCrush : Form
    {
        Random rnd = new Random();
        double curMultiplier, finalMultiplier, takeMult;
        int bet, countOfIterations = 0;
        User user;
        int numOfIterations = 0;
        private string EXPLOSION = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\bomb.wav";
        static string BUTTON = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\button.mp3";
        private bool isYourLblChanging = false;
        private FormUser FormUser;
        private bool isBombActive = true;
        private Database db = new Database();
        int numOfPlayers = 0;

        public FormGamesCrush(FormUser FormUser, User user)
        {
            this.FormUser = FormUser;
            this.user = user;
            InitializeComponent();
            Panel pnl = new Panel();
            pnl.SetRoundedShape(panel2, 20);
            btnTake.Visible = false;
            SetRadius();
            labelMult.Text = String.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private double GetMultiplier()
        {
            int num = rnd.Next(1, 1000);
            if (num < 3)
                return 100 + rnd.Next(-3, 2);
            if (num < 10)
                return 60 + rnd.Next(-3, 2);
            if (num < 40)
                return 25 + rnd.Next(-3, 2);
            if (num < 60)
                return 10 + rnd.Next(-2, 2);
            if (num < 90)
                return 6 + rnd.Next(-2, 2);
            if (num < 100)
                return 4 + rnd.Next(-1, 2);
            if (num < 300)
                return 3 + rnd.Next(-1, 2);
            if (num < 500)
                return 2;
            if (num < 600)
                return 1.7;
            if (num < 800)
                return 1.5;
            if (num < 900)
                return 1.2;
            if (num < 950)
                return 1.1;
            return 1.00;
        }

        private void playButtonSound()
        {
            MediaPlayer coin = new MediaPlayer();
            coin.Open(new Uri(BUTTON));
            coin.Play();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetRadius()
        {
            Panel pnl = new Panel();
            pnl.SetRoundedShape(btnTake, 30);
            pnl.SetRoundedShape(btnGo, 30);
            pnl.SetRoundedShape(panel5, 30);
            pnl.SetRoundedShape(panel4, 30);
            pnl.SetRoundedShape(panel6, 30);
            pnl.SetRoundedShape(btnMinus, 20);
            pnl.SetRoundedShape(btnPlus, 20);
        }

        private void textBoxBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)// цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void changePicture(int numOfIter)
        {
            switch (numOfIter)
            {
                case 1:
                    panel2.BackgroundImage = Properties.Resources.fire_1;
                    break;
                case 2:
                    panel2.BackgroundImage = Properties.Resources.fire_2;
                    break;
                case 3:
                    panel2.BackgroundImage = Properties.Resources.fire_3;
                    break;
                case 4:
                    panel2.BackgroundImage = Properties.Resources.fire_4;
                    break;
                default:
                    timer1.Stop();
                    curMultiplier = 0;
                    countOfIterations = 0;
                    numOfIterations = 0;
                    btnGo.Enabled = true;
                    btnTake.Visible = false;
                    btnGo.Visible = true;
                    break;
            }
        }

        private void explosion()
        {
            MediaPlayer bomb = new MediaPlayer();
            bomb.Open(new Uri(EXPLOSION));
            bomb.Play();
        }

        private void addBet(int bet1)
        {
            playButtonSound();
            if (bet + bet1 < 0)
                MessageBox.Show("Bet must be possitive");
            else if (bet + bet1 <= user.GetBalance())
                bet += bet1;
            else
                MessageBox.Show("Insuffcieint balance");
            lblBet.Text = bet.ToString();
        }

        private void btnTake_Click_1(object sender, EventArgs e)
        {
            playButtonSound();
            numOfPlayers++;
            string str = "";
            str = "\n" + user.GetLogin() + " won " + curMultiplier;
            label2.Text += str;
            labelMult.ForeColor = System.Drawing.Color.Gray;
            countOfIterations += 50;
            btnGo.Enabled = false;
            takeMult = curMultiplier;
            btnTake.Enabled = false;
            user.SetBalance(user.GetBalance() + Convert.ToInt32(bet * curMultiplier));
            db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
            FormUser.ChangeBalanceValue(user.GetBalance().ToString());
            isYourLblChanging = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            playButtonSound();
            bet = user.GetBalance();
            lblBet.Text = bet.ToString();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            addBet(10);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            addBet(100);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            addBet(50);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addBet(5);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            addBet(1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            addBet(-1);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            playButtonSound();
            if (bet > user.GetBalance())
            {
                MessageBox.Show("Insufficient balance");
                return;
            }
            if (bet < 1)
            {
                MessageBox.Show("Place your bet");
                return;
            }
            changeButtonsAvailability(false);
            isBombActive = true;
            user.SetBalance(user.GetBalance() - bet);
            db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
            btnGo.Visible = false;
            btnTake.Visible = true;
            panel2.BackgroundImage = Properties.Resources.dude_jpg;
            FormUser.ChangeBalanceValue(user.GetBalance().ToString());
            labelMult.ForeColor = System.Drawing.Color.Green;
            finalMultiplier = GetMultiplier();
            timer1.Enabled = true;
            btnTake.Enabled = true;
            btnGo.Enabled = false;
            curMultiplier = 1;
            isYourLblChanging = true;
            numOfPlayers = 0;
            label2.Text = string.Empty;
        }

        private void changeWinnersTable()
        {
            if (numOfPlayers > 15)
                return;
            numOfPlayers++;
            string str = "";
            str = "\nplayer" + numOfPlayers + " won " + curMultiplier;
            label2.Text += str;
        }

        private void btnDelBet_Click(object sender, EventArgs e)
        {
            playButtonSound();
            bet = 0;
            lblBet.Text = "0";
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countOfIterations > 100)
                curMultiplier += 0.1;
            else if (countOfIterations > 70)
                curMultiplier += 0.05;
            else if (countOfIterations > 40)
                curMultiplier += 0.02;
            else if (countOfIterations > 20)
                curMultiplier += 0.01;
            else if (countOfIterations > 10)
                curMultiplier += 0.0075;
            else
                curMultiplier += 0.005;
            countOfIterations++;
            if (rnd.Next(1, 12) == 1)
            {
                changeWinnersTable();
            }
            if (curMultiplier >= finalMultiplier)
            {
                btnTake.Enabled = false;
                numOfIterations++;
                changePicture(numOfIterations);
                labelMult.ForeColor = System.Drawing.Color.Red;
                if (isYourLblChanging)
                {
                    lblYourBet.Text = "0";
                    lblWinBet.Text = "0";
                }
                if (isBombActive)
                {
                    explosion();
                    isBombActive = false;
                }
                changeButtonsAvailability(true);
            }
            if (isYourLblChanging)
                lblYourBet.Text = getMult(curMultiplier.
                    ToString());
            if(curMultiplier != 0)
                labelMult.Text = getMult(curMultiplier.ToString());
            if(btnTake.Enabled)
                lblWinBet.Text = (curMultiplier * bet).ToString();
        }

        private void changeButtonsAvailability(bool value)
        {
            btnMinus.Enabled = value;
            btnPlus.Enabled = value;
            btn10.Enabled = value;
            btn100.Enabled = value;
            btn50.Enabled = value;
            btn5.Enabled = value;
            btnAll.Enabled = value;
            btnDelBet.Enabled = value;
        }

        private string getMult(string str)
        {
            int length = str.Length, i = 0;
            string final = string.Empty;
            while (length > 0 && i < 4)
            {
                final += str[i].ToString();
                i++;
                length--;
            }
            return final;
        }
    }
}