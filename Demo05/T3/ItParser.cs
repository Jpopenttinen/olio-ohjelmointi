using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    class ItParser
    {
        
        public static int Count(List<int> countNumbers)
        {

            List<int> countNumb = new List<int>();
            countNumb = countNumbers;

            int l = countNumb.Count;


            return l;
        }

        public static int Sum(List<int> sumNumbers)
        {
            List<int> sumNumb = new List<int>();
            sumNumb = sumNumbers;

            int k = sumNumb.Sum();

            return k;
        }


        public static int Average(List<int> aveNumbers)
        {
            List<int> aveNumb = new List<int>();
            aveNumb = aveNumbers;

            int x = aveNumb.Sum();
            int y = aveNumb.Count();

            int z = x / y;

            return z;
        }

    }
}
