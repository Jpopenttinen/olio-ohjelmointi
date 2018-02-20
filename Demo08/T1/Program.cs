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
            OrderItem Sock = new OrderItem("Adidas socks", 50);
            OrderItem Shirt = new OrderItem("T-shirt", 25);
            List<OrderItem> order1 = new List<OrderItem>();
            List<OrderItem> order2 = new List<OrderItem>();
            order1.Add(Sock);
            order1.Add(Shirt);
            order2.Add(Sock);

            Customer Jukka = new Customer("Jukka");
            List<Order> JukkasOrders = new List<Order>();
            Order orderJukka = new Order();

            JukkasOrders.Add(orderJukka.PlaceOrder(order1, Jukka));
            JukkasOrders.Add(orderJukka.PlaceOrder(order2, Jukka));

            Jukka.ShowOrders(Jukka, JukkasOrders);
        }
    }
}
