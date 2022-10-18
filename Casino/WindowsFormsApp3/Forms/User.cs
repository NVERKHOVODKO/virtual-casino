using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsApp3.Forms
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Access { get; set; }
        public int Balance { get; set; }

        public User(int Id, string Login, string Password, int Access, int Balance)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.Access = Access;
            this.Balance = Balance;
        }
    }
}