using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{

    interface IOrderStatus
    {
        void OnCreateOrder();
        void OnOrderSuccess();
        void OnOrderFailed();
    }


    class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        List<OrderItem> OrderItems { get; set; }


        public Order()
        {

        }
        public void Ordering(int id, DateTime date, List<OrderItem> ordItem)
        {

            Id = id;
            Date = date;
            OrderItems = ordItem;
            OrderItem ItemOrder = new OrderItem();
            foreach (OrderItem k in ordItem)
            {
                k = ItemOrder;
            }

            
        }

        public override string ToString()
        {
            return "Id: " + Id + "Date: " + Date + "OrderItems: " + OrderItems;// + "Orders: " + Orders;
        }
        
        /*
        public void Ordering(IOrderStatus follower)
        {

            Console.WriteLine("Creating an Order");

            if (follower != null)
            {
                follower.OnCreateOrder();
            }
            if (Items.Count <= 0)
            {
                follower.OnOrderFailed();
            }
            else
            {
                follower.OnOrderSuccess();
            }


        }
        */
    }
}
