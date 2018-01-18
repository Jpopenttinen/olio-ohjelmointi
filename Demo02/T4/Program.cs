using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenGrade;
            int grade;

            int zero = 0;
            int one = 0;
            int two = 0;
            int tree = 0;
            int four = 0;
            int five = 0;

            for (int i = 0; i < 10; i++)

            {

                Console.WriteLine("Give a grade between 0 - 5: ");
                givenGrade = Console.ReadLine();
                Int32.TryParse(givenGrade, out grade);

                if (grade >= 0 && grade <= 5)
                { 
                    
                    switch (grade)
                    {
                        case 0: zero++; break;
                        case 1: one++; break;
                        case 2: two++; break;
                        case 3: tree++; break;
                        case 4: four++; break;
                        case 5: five++; break;
                    }
                }
                else
                {
                    Console.WriteLine("Give a proper grade");
                    break;
                }
                   

            }

            string starZero = new string('*', zero);
            string starOne = new string('*', one);
            string starTwo = new string('*', two);
            string starTree = new string('*', tree);
            string starFour = new string('*', four);
            string starFive = new string('*', five);

            Console.WriteLine("0: " + starZero);
            Console.WriteLine("1: " + starOne);
            Console.WriteLine("2: " + starTwo);
            Console.WriteLine("3: " + starTree);
            Console.WriteLine("4: " + starFour);
            Console.WriteLine("5: " + starFive);

        
            Console.ReadLine();
        }
    }
}
