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
    public partial class FormGamesCrush : Form
    {
        Random rnd = new Random();
        double curMultiplier, finalMultiplier, takeMult;
        int bet, countOfIterations = 0, balance;
        User user;
        int numOfIterations = 0;
        private string EXPLOSION = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\bomb.wav";
        private bool isYourLblChanging = false;
        public FormGamesCrush(User user)
        {
            this.user = user;
            InitializeComponent();
            balance = user.GetBalance();
            label1.Text = user.GetBalance().ToString();
            lblYourBet.Text = string.Empty;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private double GetMultiplier()
        {
            int num = rnd.Next(1, 1000);
            if (num < 3)
                return 40 + rnd.Next(-3, 2);
            if (num < 10)
                return 20 + rnd.Next(-3, 2);
            if (num < 40)
                return 15 + rnd.Next(-3, 2);
            if (num < 60)
                return 8 + rnd.Next(-2, 2);
            if (num < 90)
                return 6 + rnd.Next(-2, 2);
            if (num < 100)
                return 3 + rnd.Next(-1, 2);
            if (num < 300)
                return 3 + rnd.Next(-1, 2);
            if (num < 500)
                return 1.75;
            if (num < 600)
                return 1.5;
            if (num < 800)
                return 1.3;
            if (num < 900)
                return 1.09;
            if (num < 950)
                return 1.01;
            return 1.05;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Properties.Resources.dude_jpg;
            textBoxBet.Enabled = false;
            user.SetBalance(user.GetBalance() - bet);
            label1.Text = user.GetBalance().ToString();
            labelMult.ForeColor = System.Drawing.Color.Green;
            finalMultiplier = GetMultiplier();
            timer1.Enabled = true;
            btnTake.Enabled = true;
            btnGo.Enabled = false;
            curMultiplier = 1;
            isYourLblChanging = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bet = Int32.Parse(textBoxBet.Text);
            }
            catch
            {
                bet = 0;
            }
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
                    //MessageBox.Show("You lose");
                    curMultiplier = 0;
                    countOfIterations = 0;
                    numOfIterations = 0;
                    btnGo.Enabled = true;
                    MediaPlayer mediaPlayer = new MediaPlayer();
                    mediaPlayer.Open(new Uri(EXPLOSION));
                    mediaPlayer.Play();
                    break;
            }
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
            if (curMultiplier >= finalMultiplier)
            {
                btnTake.Enabled = false;
                numOfIterations++;
                changePicture(numOfIterations);
                labelMult.ForeColor = System.Drawing.Color.Red;
                textBoxBet.Enabled = true;
                if (isYourLblChanging)
                    lblYourBet.Text = "0";
            }
            if(isYourLblChanging)
                lblYourBet.Text = getMult(curMultiplier.ToString());
            labelMult.Text = getMult(curMultiplier.ToString());
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
            return "X " + final;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            labelMult.ForeColor = System.Drawing.Color.Gray;
            countOfIterations += 50;
            btnGo.Enabled = false;
            takeMult = curMultiplier;
            btnTake.Enabled = false;
            user.SetBalance(user.GetBalance() + Convert.ToInt32(bet * curMultiplier));
            label1.Text = user.GetBalance().ToString();
            isYourLblChanging = false;
        }
    }
}
