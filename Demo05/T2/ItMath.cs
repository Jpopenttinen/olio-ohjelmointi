using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class ItMath
    {
        public static int Date()
        {

            string date;
            char[] day = new char[2];
            char[] month = new char[2];
            char[] year = new char[4];

            char point = '.';
            int check = 0;


            // Ask the date and convert it to Array
            Console.WriteLine("Give a date: ");
            date = Console.ReadLine();
            char[] dateArray = date.ToCharArray();

            // Checking if given proper date
            for (int i = 0; i < dateArray.Length; i++)
            {
                if (Char.IsNumber(dateArray[i]) || dateArray[i] == '.') { } // checking if char is number or a dot
                
                else
                {
                    check = 1;
                    Console.WriteLine("Give a proper date!");
                    return 0;
                }
            }

            int[] monthInt = new int[2];
            int[] dayInt = new int[2];
            int daySum = 0;
            int monthSum = 0;

            // Divine date to days, months and years

            while (check == 0)
            {
                int j = 0;
                while (true)
                {
                    if (dateArray[j] == point) { break; } // if index is dot => break == Checks how long array is.
                    else { day[j] = dateArray[j]; }
                    dayInt[j] = day[j];
                    j++;
                }
                int k = j + 1;
                int a = 0;
                while (true)
                {
                    if (dateArray[k] == point) { break; }
                    else { month[a] = dateArray[k]; }
                    monthInt[a] = month[a];
                    
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

                // Check the date Sum

                if (dayInt[1] == 0) // If dayInt.lenght == 1
                {
                    daySum = Convert.ToInt16(Convert.ToString(day[0]));
                }
                else
                {
                    daySum = Convert.ToInt16(Convert.ToString(day[0]) + Convert.ToInt16(Convert.ToString(day[1])));
                }
                if (monthInt[1] == 0)
                {
                    monthSum = Convert.ToInt16(Convert.ToString(month[0]));
                }
                else
                {
                    monthSum = Convert.ToInt16(Convert.ToString(month[0]) + Convert.ToInt16(Convert.ToString(month[1])));
                }

                // Check if the date is valid

                if (monthSum > 13 || monthSum < 1) { Console.WriteLine("Check the Month!"); return 0; }

                if (daySum == 31 && (monthSum != 1 || monthSum != 3 || monthSum != 5 || monthSum != 7 || monthSum != 8 || monthSum != 10 || monthSum != 12))
                {
                    switch (monthSum)
                    {
                        case 2:
                            { Console.WriteLine("There is no " + daySum + " days in February"); }
                            break;
                        case 4:
                            { Console.WriteLine("There is no " + daySum + " days in April"); }
                            break;
                        case 6:
                            { Console.WriteLine("There is no " + daySum + " days in June"); }
                            break;
                        case 9:
                            { Console.WriteLine("There is no " + daySum + " days in September"); }
                            break;
                        case 11:
                            { Console.WriteLine("There is no " + daySum + " days in November"); }
                            break;
                    }

                    return 0;
                }
                if ((monthSum == 2) && (daySum > 28))
                {
                    Console.WriteLine("There is no " + daySum + " days in February!");
                    return 0;
                }


                break;
            }

            return 1;
        }
    }
}
