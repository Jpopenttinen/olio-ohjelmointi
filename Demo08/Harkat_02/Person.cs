using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harkat_02
{
    class Person : IComparable
    {
        // properties
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }


        //method

        public int CompareTo(object obj)
        {
            int lastnames = Lastname.CompareTo(((Person)obj).Lastname);
            if (lastnames == 0) return Firstname.CompareTo(((Person)obj).Firstname);
            return lastnames;
        }
        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }
    }
}
