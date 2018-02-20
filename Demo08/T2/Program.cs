using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    public interface ITransaction
    {
        // interface members 
        string ShowTransaction();
        float GetAmount();
    }

    class Program
    {
        static void Main(string[] args)
        {
            float apple = 25.65f;
            float banana = 32.34f;
            float sum;

            string paidCash;
            string paidCash2;
            int billCount = 1;

            PaidWithCash paid = new PaidWithCash(apple, billCount);
            billCount += 1;
            PaidWithCash paid2 = new PaidWithCash(banana, billCount);
            billCount += 1;

            paidCash = paid.ShowTransaction();
            paidCash2 = paid2.ShowTransaction();

            Console.WriteLine(paidCash + paid);
            Console.WriteLine(paidCash2 + paid2);

            List<PaidWithCash> cashList = new List<PaidWithCash>();
            cashList.Add(paid);
            cashList.Add(paid2);


            sum = paid.ShowCash(cashList);
            Console.WriteLine("Total money in cash: " + sum);


            float socks = 23.45f;
            float shoes = 244.45f;
            float sum2;

            string paidCard;
            string paidCard2;
            int cardNumb1 = 132-2134;
            int cardNumb2 = 132-6234;

            PaidWithCard paidCrd = new PaidWithCard(socks, cardNumb1);
            billCount += 1;
            PaidWithCard paidCrd2 = new PaidWithCard(shoes, cardNumb2);
            billCount += 1;

            paidCard = paidCrd.ShowTransaction();
            paidCard2 = paidCrd2.ShowTransaction();

            Console.WriteLine(paidCard + paid);
            Console.WriteLine(paidCard2 + paid2);

            List<PaidWithCard> cardList = new List<PaidWithCard>();
            cardList.Add(paidCrd);
            cardList.Add(paidCrd2);


            sum2 = paidCrd.ShowAccount(cardList);
            Console.WriteLine("Total money in cash: " + sum2);
            float sum3 = sum + sum2;
            Console.WriteLine("Total sales today " + DateTime.Today + " is " + sum3);
            
        }
    }
}
