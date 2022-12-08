using Org.BouncyCastle.Utilities;
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
    public partial class FormLiders : Form
    {
        private Database db = new Database();
        private List<string> logins= new List<string>();
        private List<string> balances = new List<string>();


        public FormLiders()
        {
            InitializeComponent();
            Panel pnl = new Panel();
            pnl.SetRoundedShape(panel2, 30);
            pnl.SetRoundedShape(panel3, 50);
            try
            {
                db.GetLidersFromDataBase(logins, balances);
                label1.Text = "1) " + logins[0] + ": " + balances[0];
                label2.Text = "2) " + logins[1] + ": " + balances[1];
                label3.Text = "3) " + logins[2] + ": " + balances[2];
                label4.Text = "4) " + logins[3] + ": " + balances[3];
                label5.Text = "5) " + logins[4] + ": " + balances[4];
                label6.Text = "6) " + logins[5] + ": " + balances[5];
                label7.Text = "7) " + logins[6] + ": " + balances[6];
                label8.Text = "8) " + logins[7] + ": " + balances[7];
                label9.Text = "9) " + logins[8] + ": " + balances[8];
                label10.Text = "10) " + logins[9] + ": " + balances[9];
            }
            catch
            {

            }
        }
    }
}
