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
                    Console.Clear();
                    products.Add(TakeProductInput());
                    Console.Write("\nProduct Added. Press any key to continue...");
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    DisplayAllProducts(products);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Highest Priced Product >");
                    Console.WriteLine("------------------------------------\n");
                    int index = FindHighestPriceProductIndex(products);
                    if (index >= 0)
                    {
                        Console.WriteLine("Name: " + products[index].Name + ", Price: $" + products[index].Price);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("There are no products in the system.");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }

                }
                else if (option == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Sales Tax of All Products >");
                    Console.WriteLine("------------------------------------\n");
                    ViewSalesTaxOfAllProducts(products);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();

                }
                else if (option == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Products to be Ordered >");
                    Console.WriteLine("------------------------------------\n");
                    ViewProductsToBeOrdered(products);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (option == "6")
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid Choice. Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static string Menu()
        {
            Console.Write("Product Management >\n" +
                          "---------------------------------\n" +
                          "1. Add Product.\n" +
                          "2. View All Products.\n" +
                          "3. Find Product with highest unit price.\n" +
                          "4. View Sales Tax of all Products.\n" +
                          "5. Products to be Ordered.\n" +
                          "6. Exit.\n" +
                          "Enter your choice: "
            );
            return Console.ReadLine();
        }

        static Product TakeProductInput()
        {
            Console.WriteLine("Add Product >");
            Console.WriteLine("--------------------------\n");
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter " + name + "'s Category: ");
            string category = Console.ReadLine();
            Console.Write("Enter " + name + "'s Price: $");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter " + name + "'s Stock Quantity: ");
            int stock = int.Parse(Console.ReadLine());
            Console.Write("Enter Minimum Stock quantity for " + name + ": ");
            int minStock = int.Parse(Console.ReadLine());
            return new Product(name, category, price, stock, minStock);
        }

        static void DisplayAllProducts(List<Product> products)
        {
            Console.WriteLine("All Products >");
            Console.WriteLine("------------------------------\n");
            if (products.Count != 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". Name: " + products[i].Name + ", Category: " + products[i].Category + ", Price: $" + products[i].Price + ", Stock: " + products[i].StockQuantity + ", Min Stock: " + products[i].MinimumStockQuantity);
                }
            }
            else
            {
                Console.WriteLine("There are no products in the system.");
            }
        }

        static int FindHighestPriceProductIndex(List<Product> products)
        {
            if (products.Count > 0)
            {
                int index = 0;
                double highest = products[0].Price;

                for (int i = 1; i < products.Count; i++)
                {
                    if (products[i].Price > highest)
                    {
                        highest = products[i].Price;
                        index = i;
                    }
                }

                return index;
            }
            return -1;
        }

        static void ViewSalesTaxOfAllProducts(List<Product> products)
        {
            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". Name: " + products[i].Name + ", Sales Tax: $" + products[i].CalculateSalesTax());
                }
            }
            else
            {
                Console.WriteLine("There are no products in the system.");
            }
        }

        static void ViewProductsToBeOrdered(List<Product> products)
        {
            if (products.Count > 0)
            {
                int count = 1;
                bool exists = false;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].StockQuantity < products[i].MinimumStockQuantity)
                    {
                        exists = true;
                        Console.WriteLine(count + ". Name: " + products[i].Name + ", Stock: " + products[i].StockQuantity);
                        count++;
                    }
                }
                if (!exists)
                {
                    Console.WriteLine("There are no products to be oredered.");
                }
            }
            else
            {
                Console.WriteLine("There are no products in the system.");
            }
        }
    }

    class Product
    {
        public string Name;
        public string Category;
        public double Price;
        public int StockQuantity;
        public int MinimumStockQuantity;

        public Product()
        {
            Name = "";
            Category = "";
            Price = 0.0;
            StockQuantity = 0;
            MinimumStockQuantity = 0;
        }
        public Product(string name, string category, double price, int stockQuantity, int minimumStockQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
            MinimumStockQuantity = minimumStockQuantity;
        }
        public Product(Product product)
        {
            Name = product.Name;
            Category = product.Category;
            Price = product.Price;
            StockQuantity = product.StockQuantity;
            MinimumStockQuantity = product.MinimumStockQuantity;
        }

        public double CalculateSalesTax()
        {
            if (Category == "Groceries")
            {
                return Price * 0.10;
            }
            else if (Category == "Fresh Fruit")
            {
                return Price * 0.05;
            }
            else
            {
                return Price * 0.15;
            }
        }
    }
}