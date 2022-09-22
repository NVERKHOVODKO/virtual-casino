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

            moveCups();
            //moving

        }


        private void changeLocation(Panel panel, Point point)
        {
            int x1 = panel.Location.X, x2 = point.X, y1 = panel.Location.Y, y2 = point.Y;
            if(x1 > x2)
                while(x1 > x2)
                {
                    Thread.Sleep(1);
                    panel.Location = new Point(x1, y1);
                    x1 -= 20;
                }
            else if (x1 < x2) 
                while (x2 > x1)
                {
                    Thread.Sleep(1);
                    panel.Location = new Point(x1, y1);
                    x1 += 20;
                }
        }

        private void moveCups()
        {

            //создать массив п1 -п2 и менять стакны местами
            Point point1 = new Point(570, 245);
            Point point2 = new Point(340, 245);
            Point point3 = new Point(130, 245);

            /*panelCup1.Location = point1;
            panelCup2.Location = point2;
            panelCup3.Location = point3;*/

            changeLocation(panelCup1, point3);
            changeLocation(panelCup3, point1);
            changeLocation(panelCup2, point3);
            changeLocation(panelCup1, point1);
            changeLocation(panelCup2, point2);
            changeLocation(panelCup3, point1);
            changeLocation(panelCup2, point2);
            changeLocation(panelCup1, point3);

        }
    }
}