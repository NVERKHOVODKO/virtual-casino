using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace WindowsFormsApp3
{
    class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Access { get; set; }
        public int Balance { get; set; }
    }
}
