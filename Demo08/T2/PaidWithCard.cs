using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class PaidWithCard : ITransaction
    {


        public float Cash { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public int CardNumber { get; set; }
        private float sum;

        public PaidWithCard(float amount, int cardnumber)
        {
            CardNumber = cardnumber;
            Date = DateTime.Now;
            Amount = amount;
        }
        public override string ToString()
        {
            return " CardNumber " + CardNumber + " Date: " + Date;
        }
        public float ShowAccount(List<PaidWithCard> list)
        {
            foreach (PaidWithCard i in list)
            {
                sum += i.Amount;
            }
            return sum;
        }

        public string ShowTransaction()
        {
            return "Paid With Cash: " + Amount + " in Euros";
        }
        public float GetAmount()
        {
            return Amount;
        }


    }
}
