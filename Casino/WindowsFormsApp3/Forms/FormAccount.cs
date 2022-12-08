using System;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAccount : Form
    {
        private User user;
        private FormUser FormUser;
        private Form activeForm;
        private Database db = new Database();
        private SongPlayer mediaPlayer;
        private MediaPlayer paySound = new MediaPlayer();
        private int withdrawMoney = 0;

        public FormAccount(SongPlayer mediaPlayer, FormUser FormUser, User user)
        {
            this.mediaPlayer = mediaPlayer;
            this.FormUser = FormUser;
            this.user = user; 
            InitializeComponent();
            trackBar1.Value = Convert.ToInt32(mediaPlayer.GetVolume() * 10);
            Panel pnl = new Panel();
            pnl.SetRoundedShape(panelChangeLogin, 50);
            pnl.SetRoundedShape(panelDeposit, 50);
            pnl.SetRoundedShape(panelMain, 50);
            pnl.SetRoundedShape(button4, 20);
            pnl.SetRoundedShape(button3, 20);
            pnl.SetRoundedShape(panel1, 15);
            pnl.SetRoundedShape(button2, 20);
            pnl.SetRoundedShape(btnWithdrawMoney, 20);
            pnl.SetRoundedShape(panelWithdraw, 50);
            pnl.SetRoundedShape(button5, 20);
            pnl.SetRoundedShape(buttonSignOut, 20);
            pnl.SetRoundedShape(btnChangeLogin, 20);
            pnl.SetRoundedShape(button1, 20);
            panelDeposit.Visible = false;
            panelChangeLogin.Visible = false;
            panelWithdraw.Visible = false;
            choiseMedal();
            labelLogin.Text = user.GetLogin();
            labelID.Text = user.GetId().ToString();
            labelBalance.Text = user.GetBalance().ToString() + " NC";        
        }


        private void choiseMedal()
        {
            if (user.GetBalance() > 10000)
                pictureBoxMedal.BackgroundImage = Properties.Resources.gold_medal;
            else if (user.GetBalance() > 5000)
                pictureBoxMedal.BackgroundImage = Properties.Resources.silver_medal1;
            else if (user.GetBalance() > 1000)
                pictureBoxMedal.BackgroundImage = Properties.Resources.bronze_medal;
            pictureBoxMedal.BackgroundImageLayout = ImageLayout.Stretch;
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
                int addBalance = 0;
                try
                {
                    addBalance = Int32.Parse(textBoxMoney.Text);
                }
                catch
                {
                    MessageBox.Show("Payment wasn't successful");
                    return;
                }
                if (user.GetBalance() + addBalance > 99999)
                {
                    MessageBox.Show("Too much balance");
                    return;
                }
                if (textBox1.Text.Length == 19)
                {
                    user.SetBalance(user.GetBalance() + addBalance);
                }
                else
                {
                    MessageBox.Show("Field card data" + "");
                    return;
                }
                labelBalance.Text = user.GetBalance().ToString();
                paySound.Open(new Uri(@"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\saul_goodman.mp3"));
                paySound.Play();
                FormUser.ChangeBalanceValue(user.GetBalance().ToString());
                db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
                choiseMedal();
                panelDeposit.Visible = false;
            }
            catch
            {
                MessageBox.Show("Payment was't successful");
            }
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
            if (!Char.IsDigit(number))
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
            if (textBox2.Text.Length == 2)
            {
                textBox2.Text += "/";
            }
            textBox2.SelectionStart = textBox2.Text.Length;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            FormUser.Controls.Add(childForm);
            FormUser.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to log out?", "Log out", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                mediaPlayer.Stop();
                FormUser.Dispose();
                this.Dispose();
                OpenChildForm(new FormAuthorization());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelChangeLogin.Visible = true;
            panelDeposit.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelDeposit.Visible = false;
            panelChangeLogin.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelChangeLogin.Visible = false;
            panelWithdraw.Visible = false;
            panelDeposit.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string newLogin = textBoxNewLogin.Text;
            if(newLogin.Length < 3)
            {
                MessageBox.Show("Login must be more than 3 characters");
                return;
            }
            db.EditUser(newLogin, user.GetPassword(), user.GetId().ToString(), user.GetBalance().ToString(), user.GetAccess().ToString());
            user.SetLogin(newLogin);
            FormUser.ChangeLoginText(newLogin);
            panelChangeLogin.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var volume = trackBar1.Value / 10.0;
            mediaPlayer.SetVolume(volume);
        }

        private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            panelWithdraw.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelWithdraw.Visible = false;
            panelChangeLogin.Visible = false;
            panelDeposit.Visible = false;
        }

        private void btnWithdrawMoney_Click_1(object sender, EventArgs e)
        {
            panelWithdraw.Visible = true;
            panelChangeLogin.Visible = false;
            panelDeposit.Visible = false;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonWithdrawMoneyGo_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == 19)
            {
                try
                {
                    withdrawMoney = Int16.Parse(textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("Can't withdraw money");
                    return;
                }
                if(user.GetBalance() < withdrawMoney)
                {
                    MessageBox.Show("Influenced balance");
                    return;
                }
                user.SetBalance(user.GetBalance() - withdrawMoney);
                Database db = new Database();
                db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
                FormUser.ChangeBalanceValue(user.GetBalance().ToString());
                choiseMedal();
                labelBalance.Text = user.GetBalance().ToString() + " NC";
                paySound.Open(new Uri(@"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\saul_goodman.mp3"));
                paySound.Play();
            }
            else
            {
                MessageBox.Show("Can't withdraw money. Fill in the field");
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = String.Empty;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == 4 || textBox7.Text.Length == 9 || textBox7.Text.Length == 14)
            {
                textBox7.Text += "-";
            }
            textBox7.SelectionStart = textBox7.Text.Length;
        }
    }
}
