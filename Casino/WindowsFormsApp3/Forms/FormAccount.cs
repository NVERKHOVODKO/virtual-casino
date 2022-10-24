using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FormAccount : Form
    {
        private User user;

        public FormAccount()
        {
            InitializeComponent();
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
                FormAuthorization fa = new FormAuthorization();
                user = fa.GetUser();
                int addBalance = Int32.Parse(Char.ToString(textBox1.Text[15]) + Char.ToString(textBox1.Text[16]) + Char.ToString(textBox1.Text[17]) + Char.ToString(textBox1.Text[18]));
                user.SetBalance(user.GetBalance() + addBalance);
                MessageBox.Show("Payment was successful");
            }
            catch
            {
                MessageBox.Show("Payment was't successful");
            }

        }
    }
}
