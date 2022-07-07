using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public string email { get; set; }

        public User() { }
        public User(int id, string login, string email, string pass)
        {

            this.id = id;
            this.login = login;
            this.pass = pass;
            this.email = email;
        }
    }
}
