using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Order
    {
        public Customer customer;
        public List<OrderItem> items;
        public double totalPrice;

        public Order(Customer customer, List<OrderItem> items)
        {
            this.customer = new Customer(customer);
            this.items = new List<OrderItem>();
            for (int i = 0; i < items.Count(); i++)
            {
                this.items.Add(new OrderItem(items[i]));
            }
            this.totalPrice = 0;
            CalculateTotal();
        }

        public void CalculateTotal()
        {
            for (int i = 0; i < items.Count(); i++)
            {
                this.totalPrice += items[i].totalPrice;
            }
        }
    }
}
