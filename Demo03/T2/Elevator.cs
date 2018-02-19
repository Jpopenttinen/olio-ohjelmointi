using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class Elevator
    {
        private int elevStatus;
        public int ElevStatus
        {
            get
            {
                return elevStatus;
            }
            set
            {
                if (value > 1 || value < 5)
                {
                    elevStatus = value;
                }
                else { Console.WriteLine("There is not such a level in this building"); }
            }
                
        }
        public int GetUp(int level, int atBegin)
        {


            for (int i = atBegin; i < level; i++)
            {
                ElevStatus++;
                Console.WriteLine(ElevStatus);
            }
            return elevStatus;
        }
        public int GetDown(int level, int atBegin)
        {
            for (int i = atBegin; i > level; i--)
            {
                ElevStatus--;
                Console.WriteLine(ElevStatus);
            }
            return elevStatus;
        }

    }
}
