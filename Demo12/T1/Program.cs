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
            Dice dice = new Dice();
            int answr;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            double sum = 0;
            double avg;
            Console.WriteLine("How many times you wish to roll a dice?: ");
            int.TryParse(Console.ReadLine(), out answr);
            List<double> listRolls = new List<double>();
            for (int i = 0; i < answr; i++)
            {
                double diceNum = dice.CreateRndNumber();
                //Console.WriteLine(diceNum);
                listRolls.Add(diceNum);
                sum = diceNum + sum;
            }

            foreach (int a in listRolls)
            {
                switch (a)
                {
                    case 1: num1 += 1;
                        break;
                    case 2: num2 += 1;
                        break;
                    case 3: num3 += 1;
                        break;
                    case 4: num4 += 1;
                        break;
                    case 5: num5 += 1;
                        break;
                    case 6: num6 += 1;
                        break;
                }
            }
            avg = sum / answr;

            Console.WriteLine("Dice is thrown {0} times", answr);
            Console.WriteLine("- Average is : {0}", avg);
            Console.WriteLine("- 1 count is : {0}", num1);
            Console.WriteLine("- 2 count is : {0}", num2);
            Console.WriteLine("- 3 count is : {0}", num3);
            Console.WriteLine("- 4 count is : {0}", num4);
            Console.WriteLine("- 5 count is : {0}", num5);
            Console.WriteLine("- 6 count is : {0}", num6);

        }
    }
}
