using System;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            while (true)
            {
                Console.Clear();
                string option = Menu();
                if (option == "1")
                {
                    products.Add(getProduct());
                    Console.WriteLine("Product Added!!");
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    DisplayAllProducts(products);
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.WriteLine(CalculateTotalWorth(products));
                    Console.ReadKey();
                }
                else if (option == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!");
                    Console.ReadKey();
                }
            }
        }
        static void DisplayAllProducts(List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].ToString());
            }
        }
        static string Menu()
        {
            Console.WriteLine("Products Management System >");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Product");
            Console.WriteLine("3. Total Store Worth");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string option = Console.ReadLine();
            return option;
        }
        static Product getProduct()
        {
            Console.Write("Enter Product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter Brand Name: ");
            string brandName = Console.ReadLine();
            Console.Write("Enter Country: ");
            string country = Console.ReadLine();
            Product obj = new Product(name, price, category, brandName, country);
            return obj;
        }
        static double CalculateTotalWorth(List<Product> products)
        {
            double Total = 0;
            for (int i = 0; i < products.Count; i++)
            {
                Total += products[i].price;
            }
            return Total;
        }
    }

    public class Product
    {
        public string name;
        public double price;
        public string category;
        public string brandName;
        public string country;

        public Product(string name, double price, string category, string brandName, string country)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.brandName = brandName;
            this.country = country;
        }

        override public string ToString()
        {
            return "Name: " + name + ", Price: " + price + ", Category: " + category + ", Brand Name: " + brandName + ", Country: " + country;
        }
    }
}