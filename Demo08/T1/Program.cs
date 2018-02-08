using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem Shirt = new OrderItem();
            Shirt.Name = "T-Shirt";
            Shirt.Size = 52;

            OrderItem Shoe = new OrderItem();
            Shoe.Name = "Boots";
            Shoe.Size = 43;

            Customer Jukka = new Customer();
            Jukka.Name = "Jukka";

            List<OrderItem> List1 = new List<OrderItem>();
            List1.Add(Shirt);
            List1.Add(Shoe);

            Order Order1 = new Order();
            int i = 0;
            i++;
            Order1.Ordering(i, DateTime.Now, List1);


            Console.WriteLine(Order1);






            Program test = new Program();
            test.ProductOrder(Jukka, List1);

            PlaceOrder Order_1 = new PlaceOrder();

            Order_1.Order_2(Shirt, i, Jukka);


            Console.ReadLine();
        }
        public void ProductOrder(Customer Custom, List<OrderItem> ListItems)
        {

            List<OrderItem> List = new List<OrderItem>();
            List = ListItems;
            Customer cust = new Customer();
            



        }
    }
}
