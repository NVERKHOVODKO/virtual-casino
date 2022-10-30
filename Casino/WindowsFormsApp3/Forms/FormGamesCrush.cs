﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGamesCrush : Form
    {
        Random rnd = new Random();
        double curMultiplier, finalMultiplier, takeMult;
        int bet, countOfIterations = 0, balance;
        User user;
        public FormGamesCrush(User user)
        {
            this.user = user;
            InitializeComponent();
            balance = user.GetBalance();
            label1.Text = user.GetBalance().ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private double GetMultiplier()
        {
            int num = rnd.Next(1, 1000);
            if (num < 3)
                return 24 + rnd.Next(-3, 2);
            if (num < 10)
                return 15 + rnd.Next(-3, 2);
            if (num < 40)
                return 10 + rnd.Next(-3, 2);
            if (num < 60)
                return 5 + rnd.Next(-3, 2);
            if (num < 90)
                return 4 + rnd.Next(-3, 2);
            if (num < 100)
                return 2 + rnd.Next(-1, 2);
            if (num < 500)
                return 1.37;
            if (num < 600)
                return 1.29;
            if (num < 800)
                return 1.2;
            if (num < 900)
                return 1.09;
            if (num < 950)
                return 1.01;
            return 1.05;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxBet.Enabled = false;
            user.SetBalance(user.GetBalance() - bet);
            label1.Text = user.GetBalance().ToString();
            textBoxMult.BackColor = Color.Green;
            finalMultiplier = GetMultiplier();
            timer1.Enabled = true;
            btnTake.Enabled = true;
            curMultiplier = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBet_TextChanged(object sender, EventArgs e)
        {
            bet = Int32.Parse(textBoxBet.Text);
        }

        private void textBoxBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)// цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(countOfIterations > 100)
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
            if (curMultiplier >= 100)
            {
                timer1.Stop();
                curMultiplier = 0;
                textBoxMult.BackColor = Color.Red;
                MessageBox.Show("You lose");
            }
            textBoxMult.Text = curMultiplier.ToString();
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            textBoxMult.BackColor = Color.Gray;
            takeMult = curMultiplier;
            btnTake.Enabled = false;
            user.SetBalance(user.GetBalance() + Convert.ToInt32(bet * curMultiplier));
            label1.Text = user.GetBalance().ToString();
        }
    }
}