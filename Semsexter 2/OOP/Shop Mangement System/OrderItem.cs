using System;

namespace Classapp
{
    internal class OrderItem
    {
        public Product product;
        public int quantity;
        public double totalPrice;

        public OrderItem(Product product, int quantity)
        {
            this.product = new Product(product);
            this.quantity = quantity;
            totalPrice = this.product.salePrice * this.quantity;
        }

        public OrderItem(OrderItem item)
        {
            product = new Product(item.product);
            quantity = item.quantity;
            totalPrice = item.totalPrice;
        }
    }
}