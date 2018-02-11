using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1_2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public int AsioID { get; set; }

        public Student(string firstName, string lastName, string group, int asioID)
        {
            FirstName = firstName;
            LastName = lastName;
            Group = group;
            AsioID = asioID;
        }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " Group: " + Group + " AsioID: " + AsioID;
        }
    }
}
