using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{

    class Customer
    {

        public string Name { get; set; }
        //public string Orders { get; set; }
        public Order Orders { get; set; }
        public List<Order> Ords { get; set; }
        

        public void OrderPlcd()
        {

        }
        public void ShowOrder(List<Order> Ords)
        {
            foreach (Order o in Ords)
            {
                Console.WriteLine(o.ToString());
            }
        }
        public Customer()
        {

        }
        public Customer(string name)
        {
            Name = name;
            //Orders = orders;
        }

        public override string ToString()
        {
            return "Name: " + Name;// + "Orders: " + Orders;
        }
        /*
        public void OnCreateOrder()
        {
            Console.WriteLine("Creating Order!");
        }
        public void OnOrderSuccess()
        {
            Console.WriteLine("Creating is placed!");
            Ords.Add(Orders);

        }
        public void OnOrderFailed()
        {
            Console.WriteLine("Order Failed!");
        }



        public void MakeOrder()
        {


        }
        */


    }
}
