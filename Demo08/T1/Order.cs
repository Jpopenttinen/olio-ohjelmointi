using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{

    class Order
    {
        private int id;
        public int Id
        {
            get { return id; }
        }
        public DateTime Date { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        Customer Customer { get; set; }
        List<Order> Orders { get; set; }

        public Order()
        {
            id += 1;
        }
        public Order PlaceOrder(List<OrderItem> orderItems, Customer customer)
        {
            Order order = new Order();
            //order.id += 1;
            order.Date = DateTime.Now;
            order.OrderItems = orderItems;
            order.Customer = customer;
            return order;
        }
    }
}
