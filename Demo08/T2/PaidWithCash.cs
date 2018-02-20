using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2
{
    class PaidWithCash : ITransaction
    {
        //PaidWithCash-luokalle toteuta metodi public float ShowCash(), 
        //joka kertoo paljonko rahaa kassasa on, eli se tallentaa itselleen 
        //kaikki kassaan laitetut rahat.

        public float Cash { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public int BillNumber;
        private float sum;

        public PaidWithCash(float amount, int billNumber)
        {
            BillNumber = billNumber;
            Date = DateTime.Now;
            Amount = amount;
        }
        public override string ToString()
        {
            return " billNumber " + BillNumber + " Date: " + Date;
        }
        public float ShowCash(List<PaidWithCash> list)
        {
            foreach(PaidWithCash i in list)
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
