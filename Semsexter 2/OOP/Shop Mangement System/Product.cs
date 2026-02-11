using System;

namespace Classapp
{
    internal class Product
    {
        public string name;
        public double purchasePrice;
        public double salePrice;
        public double discount;

        public Product(string name, double purchasePrice)
        {
            this.name = name;
            this.purchasePrice = purchasePrice;
            discount = 0;
            salePrice = purchasePrice;
        }
        public Product(string name, double purchasePrice, double discount)
        {
            this.name = name;
            this.purchasePrice = purchasePrice;
            this.discount = discount;
            CalculateSalePrice(); 
        }

        public Product(Product otherProduct)
        {
            name = otherProduct.name;
            purchasePrice = otherProduct.purchasePrice;
            discount = otherProduct.discount;
            salePrice = otherProduct.salePrice;
        }

        public void CalculateSalePrice()
        {
            salePrice = purchasePrice - (purchasePrice * discount / 100);
        }
        public override string ToString()
        {
            return "Purchase Price: $" + purchasePrice + ", Discount: " + discount + "%, Sale Price: $" + salePrice;
        }
    }
}