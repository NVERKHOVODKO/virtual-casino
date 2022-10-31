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
            panelDeposit.Visible = false;
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
                pictureBoxMedal.BackgroundImage = Properties.Resources.silver_medal;
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
                FormUser.ChangeBalanceValue(user.GetBalance().ToString());
                db.updateBalance(user.GetId().ToString(), user.GetBalance());
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
                mediaPlayer.Dispose();
                FormUser.Dispose();
                this.Dispose();
                OpenChildForm(new FormAuthorization());
            }
        }
    }
}
