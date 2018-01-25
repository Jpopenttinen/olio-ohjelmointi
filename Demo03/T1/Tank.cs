using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T1
{
    class Tank
    {
        public string Name { get; set; }
        public string Type { get; set; }
        private int crewcount;
        public int CrewCount
        {
            get { return crewcount; }

            set
            {
                if (value > 2 && value < 6)
                {
                    crewcount = value;
                }
                else
                {
                    crewcount = 1;
                }
            }
        }
        private float speed = 0;
        public float Speed
        {
            get { return speed; }

            set { }
        }
        public readonly float SpeedMax = 100;

        public float AccelerateTo(int accel)
        {

            for (int i = 0; i < accel; i++)
            {
                speed += 5;
                Console.WriteLine(speed);

                if (speed > 100)
                {
                    speed = 100;
                    break;
                }
                
            }
            

            return speed;
        }

        public float SlowTo(int bre)
        {
            for (int i = 0; i < bre; i++)
            {
                Speed -= 5;
                Console.WriteLine(Speed);

                if (Speed > 100)
                {
                    Speed = 100;
                    break;
                }
            }

            return Speed;
        }

        private string model;
        
        public string Color { get; set; }


        private string[] strings = new string[100];
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < 100)
                {
                    return strings[i];
                }
                else
                {

                    return "out of bounds";
                }

            }
            set
            {
                if (i >= 0 && i < 100)
                {
                    strings[i] = value;
                }

            }
        }


        public string Model
        {
            get { return model; }
            set
            {
                if (value != "toyota" && value != "nissan")
                {
                    model = " there is no other than toyota or nissan";
                }
                else
                {
                    model = value;
                }
            }
        }

      
    }
}
