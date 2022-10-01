using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
	public partial class Form1 : Form
	{
		private Button currentButton;
		private Random random;
		private int tempIndex;
		private Form activeForm;
		System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"C:\Users\user\Downloads\assasin.wav");
		public Form1()
		{
			InitializeComponent();
			random = new Random();
			buttonBack.Visible = false;

			//soundPlayer.Play();
		}


		IFirebaseConfig fcon = new FirebaseConfig()
		{
			AuthSecret = "p5qHU4a8afp0y67Gn3XdD4A4hI93Xqc59YNYcYnI",
			BasePath = "https://casino-827ad-default-rtdb.firebaseio.com/"
		};

		IFirebaseClient client;



	[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		//Methods
		private Color SelectThemeColor()
		{
			int index = random.Next(ThemeColor.ColorList.Count);
			while (tempIndex == index)
			{
				index = random.Next(ThemeColor.ColorList.Count);
			}
			tempIndex = index;
			string color = ThemeColor.ColorList[index];
			return ColorTranslator.FromHtml(color);
		}

		private void ActivateButton(object btnSender)
		{
			if (btnSender != null)
			{
				if (currentButton != (Button)btnSender)
				{
					DisableButton();
					Color color = SelectThemeColor();
					currentButton = (Button)btnSender;
					currentButton.BackColor = color;
					currentButton.ForeColor = Color.White;
					currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					panelTitle.BackColor = color;
					panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					ThemeColor.PrimaryColor = color;
					ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
					buttonBack.Visible = true;
				}
			}
		}

		private void DisableButton()
		{
			foreach (Control previousBtn in panelMenu.Controls)
			{
				if (previousBtn.GetType() == typeof(Button))
				{
					previousBtn.BackColor = Color.FromArgb(51, 51, 76);
					previousBtn.ForeColor = Color.Gainsboro;
					previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				}
			}
		}
		private void OpenChildForm(Form childForm, object btnSender, string titleText)
		{
			if (activeForm != null)
				activeForm.Close();
			ActivateButton(btnSender);
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			this.panelDesktopPanel.Controls.Add(childForm);
			this.panelDesktopPanel.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			labelMain.Text = titleText;

        }

		private void Reset()
		{
			DisableButton();
			panelTitle.Text = "HOME";
			panelTitle.BackColor = Color.FromArgb(0, 150, 136);
			panelLogo.BackColor = Color.FromArgb(39, 39, 58);
			currentButton = null;
			buttonBack.Visible = false;
		}



		private void button1_Click(object sender, EventArgs e)
		{

			ActivateButton(sender);
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void buttonGames_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Forms.FormGames(), sender, "GAMES");
		}

		private void buttonLiders_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);

		}

		private void buttonSettings_Click(object sender, EventArgs e)
		{
			ActivateButton(sender);
		}

		private void panelMenu_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelTitle_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			ActivateButton(sender);

		}

		private void btnBalance_Click(object sender, EventArgs e)
		{
			OpenChildForm(new Forms.FormAccount(), sender, "ACCOUNT");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			soundPlayer.Stop();
			if (activeForm != null)
				activeForm.Close();
			Reset();
		}

		private void labelLogo_Click(object sender, EventArgs e)
		{

		}

		private void panelLogo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
