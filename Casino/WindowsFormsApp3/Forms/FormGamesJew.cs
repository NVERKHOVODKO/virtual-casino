using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGamesJew : Form
    {
        static string SONG_PHONK_1 = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\phonk_1.wav";
        static string SONG_PHONK_2 = @"C:\НЕ СИСТЕМА\BSUIR\второй курс\OOP-CourseWork\Songs\phonk_2.wav";

        Random rnd = new Random();
        int a, b, c, move, bet;

        private void textBoxBet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bet = Int32.Parse(textBoxBet.Text);
            }
            catch
            {
                textBoxBet.Text = "";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public FormGamesJew()
        {

            InitializeComponent();
            pictureBox1.Size = new Size(200, 200);
            pictureBox2.Size = new Size(200, 200);
            pictureBox3.Size = new Size(200, 200);

            Player.Play(SONG_PHONK_2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxBet.Text != "")
			{
                bet = Int32.Parse(textBoxBet.Text);
            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(move != 5)
            {
                move++;
                a = rnd.Next(4);
                b = rnd.Next(4);
                c = rnd.Next(4);

                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.sun;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.moon;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.saturn;
                        break;
                }
                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.sun;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.moon;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.saturn;
                        break;
                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.sun;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.moon;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.saturn;
                        break;
                }
            }
            else
            {
                timer1.Enabled = false;
                move = 0;
            }
            if(move == 5 && pictureBox1.Image == pictureBox2.Image && pictureBox1.Image == pictureBox3.Image)
            {
                Image image1 = pictureBox1.Image;
                Image image2 = pictureBox2.Image;
                Image image3 = pictureBox3.Image;

                pictureBox1.Image = Properties.Resources.red;
                pictureBox2.Image = Properties.Resources.red;
                pictureBox3.Image = Properties.Resources.red;
                
                /*
                Thread.Sleep(10);
                pictureBox1.Image = image1;
                pictureBox2.Image = image2;
                pictureBox3.Image = image3;
*/

                if (pictureBox1.Image == Properties.Resources.sun)
                {
                    MessageBox.Show("You win " + bet * 30);
                }
                MessageBox.Show("You win " + bet * 10);
            }else if(move == 5)
            {
                MessageBox.Show("You lose");

            }

        }
    }
}
