using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public Account() { }
        public Account(string u, string p)
        {
            username = u;
            password = p;
        }
    }
}
