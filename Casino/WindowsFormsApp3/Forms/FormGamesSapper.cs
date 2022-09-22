using System;
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
	public partial class FormGamesSapper : Form
	{
		bool isFirstlineActive = true, isSecondlineActive = false, isThirdlineActive = false, isFourthlineActive = false, isFifthlineActive = false;
		Random rnd = new Random();
        public FormGamesSapper()
		{
			InitializeComponent();
            pictureBomb1.Visible = false;

        }

		private void activateLine()
		{
			btn1_1.Location = new Point(btn1_1.Location.X, btn1_1.Location.Y - 60);
			btn1_2.Location = new Point(btn1_2.Location.X, btn1_2.Location.Y - 60);
			btn1_3.Location = new Point(btn1_3.Location.X, btn1_3.Location.Y - 60);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button15_Click(object sender, EventArgs e)
		{
			activateLine_1(3);

		}

		private void activateLine_2(int numOfButton)
		{
			if (isSecondlineActive)
			{
                int random = rnd.Next(1, 4);
                switch (random)
				{
					case 1:
						pictureBomb1.Location = btn2_1.Location;
						break;
					case 2:
						pictureBomb1.Location = btn2_2.Location;
						break;
					case 3:
						pictureBomb1.Location = btn2_3.Location;
						break;
				}
                btn2_1.Dispose();
				btn2_2.Dispose();
				btn2_3.Dispose();
				if (random == numOfButton)
				{
					MessageBox.Show("Loser!");
				}
				isThirdlineActive = true;
			}
		}

		private void btn2_3_Click(object sender, EventArgs e)
		{
			activateLine_2(3);
		}

		private void btn2_2_Click(object sender, EventArgs e)
		{
			activateLine_2(2);
		}

		private void btn2_1_Click(object sender, EventArgs e)
		{
			activateLine_2(1);
		}




		private void activateLine_3(int numOfButton)
		{
			if (isSecondlineActive)
			{
				int random = rnd.Next(1, 4);
				switch (random)
				{
					case 1:
                        pictureBomb1.Location = btn3_1.Location;
						break;
					case 2:
                        pictureBomb1.Location = btn3_2.Location;
						break;
					case 3:
                        pictureBomb1.Location = btn3_3.Location;
						break;
				}
				btn3_1.Dispose();
				btn3_2.Dispose();
				btn3_3.Dispose();
				if (random == numOfButton)
				{
					MessageBox.Show("Loser!");
				}
				isFourthlineActive = true;
			}
		}


		private void btn3_3_Click(object sender, EventArgs e)
		{
			activateLine_3(3);
		}

		private void btn3_2_Click(object sender, EventArgs e)
		{
			activateLine_3(2);
		}

		private void btn3_1_Click(object sender, EventArgs e)
		{
			activateLine_3(1);
		}

		private void activateLine_4(int numOfButton)
		{
			if (isThirdlineActive)
			{
				int random = rnd.Next(1, 4);
				switch (random)
				{
					case 1:
						pictureBomb1.Location = btn4_1.Location;
						break;
					case 2:
						pictureBomb1.Location = btn4_2.Location;
						break;
					case 3:
						pictureBomb1.Location = btn4_3.Location;
						break;
				}
				btn4_1.Dispose();
				btn4_2.Dispose();
				btn4_3.Dispose();
				if (random == numOfButton)
				{
					MessageBox.Show("Loser!");
				}
				isFifthlineActive = true;
			}
		}
		private void btn4_3_Click(object sender, EventArgs e)
		{
			activateLine_4(3);
		}

		private void btn4_2_Click(object sender, EventArgs e)
		{
			activateLine_4(2);
		}

		private void btn4_1_Click(object sender, EventArgs e)
		{
			activateLine_4(1);
		}

		private void activateLine_5(int numOfButton)
		{
			if (isFourthlineActive)
			{
				int random = rnd.Next(1, 4);
				switch (random)
				{
					case 1:
						pictureBomb1.Location = btn5_1.Location;
						break;
					case 2:
						pictureBomb1.Location = btn5_2.Location;
						break;
					case 3:
						pictureBomb1.Location = btn5_3.Location;
						break;
				}
				btn5_1.Dispose();
				btn5_2.Dispose();
				btn5_3.Dispose();
				if (random == numOfButton)
				{
					MessageBox.Show("Loser!");
				}
			}
		}

		private void btn5_3_Click(object sender, EventArgs e)
		{
			activateLine_5(3);
		}

		private void btn5_2_Click(object sender, EventArgs e)
		{
			activateLine_5(2);
		}

		private void btn5_1_Click(object sender, EventArgs e)
		{
			activateLine_5(1);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void activateLine_1(int numOfButton)
		{
			if (isFirstlineActive)
			{
				int random = rnd.Next(1, 4);
                pictureBomb1.Visible = true;
                switch (random)
				{
					case 1:
						pictureBomb1.Location = btn1_1.Location;
						break;
					case 2:
						pictureBomb1.Location = btn1_2.Location;
						break;
					case 3:
						pictureBomb1.Location = btn1_3.Location;
						break;
				}
				btn1_1.Dispose();
				btn1_2.Dispose();
				btn1_3.Dispose();
				if (random == numOfButton)
				{
					MessageBox.Show("Loser!");
				}
				isSecondlineActive = true;
			}
		}



		private void btn1_2_Click(object sender, EventArgs e)
		{
			activateLine_1(2);
		}

		private void btn1_3_Click(object sender, EventArgs e)
		{
			activateLine_1(3);
		}
	}
}
