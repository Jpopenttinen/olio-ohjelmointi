using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {

            Tank bigOne = new Tank();
            bigOne.Name = "Tank 12345-3234-UI";
            bigOne.Type = "154-GU-342";

            int attendedCrew = 0;
            Console.WriteLine("How many of you lazyasses wanted to attend: ");
            Int32.TryParse(Console.ReadLine(), out attendedCrew);

            bigOne.CrewCount = attendedCrew;

            if (bigOne.CrewCount == 1)
                {
                Console.WriteLine("Give a proper number");
                }
            else
                {
                Console.WriteLine(("CrewCount is: ") + bigOne.CrewCount);
                }
            Console.WriteLine(bigOne.Name);

            float speedAtFirst = bigOne.Speed;
            Console.WriteLine(("Speed at first is: ") + speedAtFirst);

            int wantedSpeed = 0;
            Console.WriteLine("Give a speed: ");
            Int32.TryParse(Console.ReadLine(), out wantedSpeed);

            Console.WriteLine(wantedSpeed);
            float currentSpeed = bigOne.AccelerateTo(wantedSpeed);
            Console.WriteLine(currentSpeed);
            Console.WriteLine(("Big1 speed is: ") + currentSpeed);

            Console.ReadLine();
        }
    }
}
