using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenLevel;
            int levelNow = 0;
            int status;

            Elevator Kone = new Elevator();

            while (true)
            {
                Console.WriteLine("Where you wish to go: (heaven in 6)");
                int.TryParse(Console.ReadLine(), out givenLevel);
                if (givenLevel == 6) { Console.WriteLine("You have chosen to leave the prog"); break; }

                if (givenLevel > levelNow)
                {
                    status = Kone.GetUp(givenLevel, levelNow);
                }
                else
                {
                    status = Kone.GetDown(givenLevel, levelNow);
                }
                levelNow = status;

                Console.WriteLine("You are now at level: " + status);
            }

        }
    }
}
