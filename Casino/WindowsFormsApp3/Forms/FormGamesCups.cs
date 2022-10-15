using System;
using System.Drawing;
using System.Net.PeerToPeer.Collaboration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGamesCups : Form
    {
        public FormGamesCups()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                int bet = Int32.Parse(textBox1.Text);

            }
            catch
            {
                textBox1.Text = "";
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                panelEnterBet.Visible = false;

            System.Timers.Timer myTimer = new System.Timers.Timer(17);
            myTimer.Elapsed += new System.Timers.ElapsedEventHandler(myTimer_Elapsed);
            myTimer.Start();
            //moveCups();
            //moving

        }
        void myTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            panelCup3.Invoke((Action)(() => {
                panelCup3.Location = new Point(panelCup3.Location.X + 10, panelCup3.Location.Y);
            }));
        }


        private void changeLocation(Panel panel, Point point)
        {
            int x1 = panel.Location.X, x2 = point.X, y1 = panel.Location.Y, y2 = point.Y;
            if(x1 > x2)
                while(x1 > x2)
                {
                    Thread.Sleep(1);
                    panel.Location = new Point(x1, y1);
                    x1 -= 30;
                }
            else if (x1 < x2) 
                while (x2 > x1)
                {
                    Thread.Sleep(1);
                    panel.Location = new Point(x1, y1);
                    x1 += 20;
                }
        }

        private void moveCup(Panel panel)
        {
            Random random = new Random();
            Point point1 = new Point(570, 245);
            Point point2 = new Point(340, 245);
            Point point3 = new Point(130, 245);

            switch (random.Next(1, 4))
            {
                case 1:
                    changeLocation(panel, point1);
                    break;
                case 2:
                    changeLocation(panel, point2);
                    break;
                case 3:
                    changeLocation(panel, point3);
                    break;
            }
        }

        private void moveCups()
        {

            //создать массив п1 -п2 и менять стакны местами
            /*Point point1 = new Point(570, 245);
            Point point2 = new Point(340, 245);
            Point point3 = new Point(130, 245);*/

            /*panelCup1.Location = point1;
            panelCup2.Location = point2;
            panelCup3.Location = point3;*/

            /*for (int i = 0; i < 200; i++)
            {
                moveCup(panelCup1);
                moveCup(panelCup2);
                moveCup(panelCup3);
            }*/
            /*changeLocation(panelCup1, point3);
             changeLocation(panelCup3, point1);
             changeLocation(panelCup2, point3);
             changeLocation(panelCup1, point1);
             changeLocation(panelCup2, point2);
             changeLocation(panelCup3, point1);
             changeLocation(panelCup2, point2);
             changeLocation(panelCup1, point3);*/

        }

        private void panelCup3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormGamesCups_Load(object sender, EventArgs e)
        {

        }
    }
}