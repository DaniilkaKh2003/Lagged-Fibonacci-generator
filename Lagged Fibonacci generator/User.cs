using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagged_Fibonacci_generator
{
    public class User
    {
        public int id { get; set; }
        private string nickname, password;
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public User() { }
        public User(string nickname, string password)
        {
            this.nickname = nickname;
            this.password = password;
        }
    }
}
