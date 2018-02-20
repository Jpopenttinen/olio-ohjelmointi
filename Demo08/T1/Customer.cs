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
        //public List<Order> Orders { get; set; }


        public Customer(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Name: " + Name;
        }

        public void ShowOrders(Customer customer, List<Order> order)
        {
            Console.WriteLine("Customers {0} orders: ", customer);
            foreach (Order i in order)
            {
                Console.WriteLine("Order {0} placed at {1} with products: ", i.Id, i.Date);
                foreach (OrderItem k in i.OrderItems)
                {
                    Console.WriteLine(k);
                }
            }
        }

    }
}
