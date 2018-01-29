using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class TestParser
    {
        static void Main()
        {
            
            //int[] numArray = new int[i];

            List<int> numArray = new List<int>();
            Console.WriteLine("Give an array of numbers separated by a collom: ");

            string userInput = Console.ReadLine();
            string[] inputArray = userInput.Split(',');
            int nums;
            foreach (string j in inputArray)
            {
                if(Int32.TryParse(j, out nums))
                {
                    numArray.Add(nums);
                    
                }
            }

            int arrayCount = ItParser.Count(numArray);
            int arraySum = ItParser.Sum(numArray);
            int arrayAverage = ItParser.Average(numArray);


            Console.WriteLine("Given array has " + arrayCount + " numbers which sum is " + arraySum + " and an average number is " + arrayAverage);


            //numArray.ForEach(Console.WriteLine);

            


            Console.ReadLine();

            /*for (; i < numArray.Length; i++)
            {
                numArray[i];
            }*/

        }
    }
}
