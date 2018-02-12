using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T3
{
    static class CardShuffle
    {

        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            
        }

        public static List<string> Fisher_Yates_CardDeck_Shuffle(List<string> aList)
        {

            System.Random _random = new System.Random();

            string myGO;

            int n = aList.Count;
            for (int i = 0; i < n; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                // ... It is equivalent to Math.random() in Java.
                int r = i + (int)(_random.NextDouble() * (n - i));
                myGO = aList[r];
                aList[r] = aList[i];
                aList[i] = myGO;
            }

            return aList;
        }



    }

}
