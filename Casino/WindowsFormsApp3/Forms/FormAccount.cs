using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAccount : Form
    {
        private User user;

        public FormAccount(User user)
        {
            this.user = user; 
            InitializeComponent();
            panelDeposit.Visible = false;
            choiseMedal(user);
            labelLogin.Text = user.GetLogin();
            labelID.Text = user.GetId().ToString();
            labelBalance.Text = user.GetBalance().ToString() + " NC";
        }


        private void choiseMedal(User user)
        {
            int balance = user.GetBalance();
            if (balance > 1000)
                pictureBoxMedal.BackgroundImage = Properties.Resources.bronze_medal;
            else if (balance > 5000)
                pictureBoxMedal.BackgroundImage = Properties.Resources.silver_medal;
            else if (balance > 10000)
                pictureBoxMedal.BackgroundImage = Properties.Resources.gold_medal;
            pictureBoxMedal.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 4 || textBox1.Text.Length == 9 || textBox1.Text.Length == 14)
            {
                textBox1.Text += "-";
            }
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                int addBalance = Int32.Parse(Char.ToString(textBox1.Text[15]) + Char.ToString(textBox1.Text[16]) + Char.ToString(textBox1.Text[17]) + Char.ToString(textBox1.Text[18]));
                user.SetBalance(user.GetBalance() + addBalance);
                MessageBox.Show("Payment was successful");
                labelBalance.Text = user.GetBalance().ToString();
            }
            catch
            {
                MessageBox.Show("Payment was't successful");
            }

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelDeposit.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelDeposit.Visible = false;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 2 || textBox2.Text.Length == 5)
            {
                textBox2.Text += "/";
            }
            textBox2.SelectionStart = textBox2.Text.Length;
        }
    }
}
