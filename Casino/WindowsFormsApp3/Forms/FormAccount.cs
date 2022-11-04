using Google.Protobuf.WellKnownTypes;
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


        public FormAccount(SongPlayer mediaPlayer, FormUser FormUser, User user)
        {
            this.mediaPlayer = mediaPlayer;
            this.FormUser = FormUser;
            this.user = user; 
            InitializeComponent();
            Panel pnl = new Panel();
            pnl.SetRoundedShape(panelChangeLogin, 50);
            pnl.SetRoundedShape(panelDeposit, 50);
            pnl.SetRoundedShape(panelMain, 50);
            pnl.SetRoundedShape(button4, 20);
            pnl.SetRoundedShape(button3, 20);
            pnl.SetRoundedShape(panel1, 15);
            pnl.SetRoundedShape(button2, 20);
            pnl.SetRoundedShape(buttonSignOut, 20);
            pnl.SetRoundedShape(btnChangeLogin, 20);
            pnl.SetRoundedShape(button1, 20);


            panelDeposit.Visible = false;
            panelChangeLogin.Visible = false;
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
                if(user.GetBalance() > 999999)
                {
                    MessageBox.Show("Too much balance");
                    return;
                }
                
                int addBalance = Int32.Parse(Char.ToString(textBox1.Text[15]) + Char.ToString(textBox1.Text[16]) + Char.ToString(textBox1.Text[17]) + Char.ToString(textBox1.Text[18]));
                user.SetBalance(user.GetBalance() + addBalance);
                MessageBox.Show("Payment was successful");
                labelBalance.Text = user.GetBalance().ToString();
                MediaPlayer player = new MediaPlayer();
                player.Open(new Uri(@"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\saul_goodman.mp3"));
                player.Play();
                FormUser.ChangeBalanceValue(user.GetBalance().ToString());
                db.UpdateBalance(user.GetId().ToString(), user.GetBalance());
                choiseMedal();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panelChangeLogin.Visible = false;
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
    }
}
