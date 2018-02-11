using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }

        private int asioid = 0;
        public int AsioID
        {
            get
            {
                return asioid;
            }
            set
            {

                asioid++;
            }

        }

        public Student(string firstName, string lastName, string group, int asioID)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
            AsioID = asioID;
        }

        public override string ToString()
        {
            return "FirstName: " + FirstName + "LastName: " + LastName + "Group: " + Group + "AsioID: " + AsioID;
        }



    }
}
