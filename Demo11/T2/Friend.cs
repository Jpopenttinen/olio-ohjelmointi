using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Friend(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Email: " + Email;
        }


    }
}
