using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class ItMath
    {
        public static void Date()
        {
            string date;
            Console.WriteLine("Give a date: ");
            date = Console.ReadLine();
            char[] dateArray = date.ToCharArray();

            char[] day = new char[2];
            char[] month = new char[2];
            char[] year = new char[4];

            char point = '.';

            for (int i = 0; i < dateArray.Length; i++)
            {
                if (dateArray[i] == ',') { Console.WriteLine("Give a proper date!"); }
            }
           
            int j = 0;
            while (true)
            {
                if (dateArray[j] == point) { break; }
                else { day[j] = dateArray[j]; }
                j++;
            }
            int k = j + 1;
            int a = 0;
            while (true)
            {
                if (dateArray[k] == point) { break; }
                else { month[a] = dateArray[k]; }
                k++;
                a++;
            }
            int l = k + 1;
            int b = 0;
            while (true)
            {
                if (l == (dateArray.Length)) { break; }
                else { year[b] = dateArray[l]; }
                l++;
                b++;
            }

            
            
            int[] monthSum = month.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            int monthSumInt = monthSum.Sum();

            int[] daySumInt = day.Select(c => Convert.ToInt32(c.ToString())).ToArray();
            int daySum = daySumInt.Sum();

            if (monthSumInt > 13) { Console.WriteLine("Wrong month!"); }

            if (daySum == 31 && (monthSumInt != 1 || monthSumInt != 3 || monthSumInt != 5 || monthSumInt != 7 || monthSumInt != 8 || monthSumInt != 10 || monthSumInt != 12))
            {
                Console.WriteLine("Fix the day, you sucker!");
            }
            if (daySum == 30 && (monthSumInt != 4 || monthSumInt != 6 || monthSumInt != 9 || monthSumInt != 11))
            {
                Console.WriteLine("Fix the day, you sucker!");
            }
            if ((daySum == 28 || daySum == 29) && monthSumInt != 2 )
            {
                Console.WriteLine("Fix the day, you sucker!");
            }








            Console.WriteLine(day[0] + day[1] + month[0] + month[1] + year[0] + year[1] + year[2] + year[3]);
            



            Console.ReadLine();
        }
    }
}
