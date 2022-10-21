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
        public FormAccount()
        {
            InitializeComponent();
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text, final = "";

            for(int i = 0; i < str.Length; i++)
            {
                final += str[i];
                if (i % 4 == 0)
                    final += "-";
            }
            textBox1.Text = final;
        }
    }
}
