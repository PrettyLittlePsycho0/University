using System;
using System.Collections.Generic;
using System.IO;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "products.txt";
            List<Product> store = new List<Product>();
            LoadData(store, path);

            while (true)
            {
                Console.Clear();
                string option = Menu();

                if (option == "1")
                {
                    Product newProduct = AddProduct(store);

                    if (ProductExists(store, newProduct.Name))
                    {
                        Console.WriteLine("Error: This product already exists in the store.");
                        Console.ReadKey();
                    }
                    else
                    {
                        store.Add(newProduct);
                        SaveData(store, path);
                        Console.WriteLine("Product Added! Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "2")
                {
                    if (store.Count == 0)
                    {
                        Console.WriteLine("No products in store.");
                    }
                    else
                    {
                        Console.WriteLine("Products in Store:");
                        Console.WriteLine("-----------------------------");
                        for (int i = 0; i < store.Count; i++)
                        {
                            Console.WriteLine(store[i].ToString());
                        }
                    }
                    Console.WriteLine("Press any key to go back...");
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Write("Enter Product ID to search: ");
                    int searchId = int.Parse(Console.ReadLine());
                    bool found = false;

                    for (int i = 0; i < store.Count; i++)
                    {
                        if (store[i].ProductId == searchId)
                        {
                            Console.WriteLine("Product Found: " + store[i].ToString());
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Product not found.");
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else if (option == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Press any key to try again.");
                    Console.ReadKey();
                }
            }
        }

        static Product AddProduct(List<Product> store)
        {
            int id = GenerateNextId(store);
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            double price = double.Parse(Console.ReadLine());

            return new Product(id, name, price);
        }

        static string Menu()
        {
            Console.WriteLine("Store Management >");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display All Products");
            Console.WriteLine("3. Search Product by ID");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        static void SaveData(List<Product> store, string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < store.Count; i++)
            {
                file.WriteLine(store[i].ProductId + "," + store[i].Name + "," + store[i].Price);
            }
            file.Flush();
            file.Close();
        }

        static void LoadData(List<Product> store, string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                return;
            }

            StreamReader file = new StreamReader(path);
            string record;
            while ((record = file.ReadLine()) != null)
            {
                int id = int.Parse(ParseData(record, 1));
                string name = ParseData(record, 2);
                double price = double.Parse(ParseData(record, 3));
                store.Add(new Product(id, name, price));
            }
            file.Close();
        }

        static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item += record[i];
                }
            }
            return item;
        }

        static bool ProductExists(List<Product> store, string name)
        {
            for (int i = 0; i < store.Count; i++)
            {
                if (store[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        static int GenerateNextId(List<Product> store)
        {
            if (store.Count == 0)
            {
                return 1;
            }
            return store[store.Count - 1].ProductId + 1;
        }
    }

    public class Product
    {
        public int ProductId;
        public string Name;
        public double Price;

        public Product(int id, string name, double price)
        {
            ProductId = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return "ID: " + ProductId + ", Name: " + Name + ", Price: " + Price;
        }
    }
}
