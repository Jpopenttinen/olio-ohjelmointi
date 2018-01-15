using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    class ClassTest
    {
        private string model;
        private readonly int speed = 10;
        public string Color { get; set; }
        public int Speed { get; set; }

        public void Accelerate()
        {
            Speed += 5;

        }

        public void Break()
        {
            Speed -= 5;
            if (Speed < 0) Speed = 0;
        }

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

        public ClassTest()
        {
            model = "nissan";
        }

        public ClassTest(string _model)
        {
            this.Model = "nissan";
        }
        public ClassTest(string _model, string color)
        {
            this.Model = "nissan";
            this.Color = color;
        }

        ~ClassTest()
        {
            Console.WriteLine("ClassTest dstructor");
        }

    }
}
