using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class ItMath
    {
        public static int TestiPeti()
        {
            int Line;
            Console.WriteLine("Write a line of text: ");
            string tulos = Console.ReadLine();
            char comma = ',';
            char[] resultArray = tulos.ToCharArray();

            bool result = Int32.TryParse(tulos, out Line);
            bool totalResult = true;

            if (resultArray[0] == comma)
            {
                totalResult = false;
            }
            else
            {
                for (int i = 0; i < resultArray.Length; i++)
                    {
                
                    if (result == true)
                    {
                        totalResult = true;
                    }
                    /*else if ((resultArray[i] == comma) && (resultArray[resultArray[(i+ 1)]] == comma))
                    {
                        totalResult = false;
                    }*/
                    else if ((resultArray[i] == comma) && (result = true) && (resultArray[resultArray.Length -1] != comma))
                    {
                        totalResult = true;
   
                    }
                    else { totalResult = false; }
                    }
            }


            Console.WriteLine("Syöte: " + tulos + " on luku: " + totalResult);


            //bool result = Int32.TryParse(tulos, out Line);

            if (tulos == "exit")
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        

    }
}
