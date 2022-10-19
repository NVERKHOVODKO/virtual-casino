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
        private int Id;
        private string Login;
        private string Password;
        private int Access;
        private int Balance;

        public User(int Id, string Login, string Password, int Access, int Balance)
        {
            this.Id = Id;
            this.Login = Login;
            this.Password = Password;
            this.Access = Access;
            this.Balance = Balance;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int Id)
        {
            this.Id = Id;
        }

        public string GetLogin()
        {
            return Login;
        }

        public void SetLogin(string Login)
        {
            this.Login = Login;
        }
        public string GetPassword()
        {
            return Password;
        }

        public void SetPassword(string Password)
        {
            this.Password = Password;
        }

        public int GetBalance()
        {
            return Balance;
        }

        public void SetBalance(int Balance)
        {
            this.Balance = Balance;
        }

        public int GetAccess()
        {
            return Access;
        }

        public void SetAccess(int Access)
        {
            this.Access = Access;
        }
    }
}