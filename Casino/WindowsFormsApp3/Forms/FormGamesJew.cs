using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGamesJew : Form
    {
        string picture1 = @"c:\\Users\\user\\Desktop\\Casino\\Bell icon.png";
        string picture2 = @"c:\\Users\\user\\Desktop\\Casino\\Coin icon.png";
        string picture3 = @"c:\\Users\\user\\Desktop\\Casino\\Jew icon.png";
        Random rnd = new Random();

        public FormGamesJew()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                pictureBox1.Image = Image.FromFile(picture1);
                Thread.Sleep(10);

                pictureBox1.Image = Image.FromFile(picture2);
                Thread.Sleep(10);

                pictureBox1.Image = Image.FromFile(picture3);
                /*switch (rnd.Next(1, 4))
                {
                    case 1:
                        pictureBox1.BackgroundImage = Image.FromFile(picture1);
                        break;
                    case 2:
                        pictureBox1.BackgroundImage = Image.FromFile(picture2);
                        break;
                    case 3:
                        pictureBox1.BackgroundImage = Image.FromFile(picture3);
                        break;
                }
                switch (rnd.Next(1, 4))
                {
                    case 1:
                        pictureBox2.BackgroundImage = Image.FromFile(picture1);
                        break;
                    case 2:
                        pictureBox2.BackgroundImage = Image.FromFile(picture2);
                        break;
                    case 3:
                        pictureBox2.BackgroundImage = Image.FromFile(picture3);
                        break;
                }
                switch (rnd.Next(1, 4))
                {
                    case 1:
                        pictureBox3.BackgroundImage = Image.FromFile(picture1);
                        break;
                    case 2:
                        pictureBox3.BackgroundImage = Image.FromFile(picture2);
                        break;
                    case 3:
                        pictureBox3.BackgroundImage = Image.FromFile(picture3);
                        break;
                }*/
                Thread.Sleep(10);
            }
        }
    }
}
