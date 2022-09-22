using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormGames : Form
    {
        private Form activeForm;

        public FormGames()
        {
            InitializeComponent();
        }

        private void FormGames_Load(object sender, EventArgs e)
        {

        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelGames.Controls.Add(childForm);
            this.panelGames.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGamesSapper(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGames_2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGamesCups(), sender);
        }
    }
}
