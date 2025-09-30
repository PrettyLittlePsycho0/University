using System;
using System.IO;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter minimum orders: ");
            int minOrders = int.Parse(Console.ReadLine());
            Console.Write("Enter minimum orders price: ");
            int minPrice = int.Parse(Console.ReadLine());
            pizza_points("Customers.txt", minOrders, minPrice);
        }

        static void pizza_points(string fileName, int minOrders, int minPrice)
        {
            StreamReader reader = new StreamReader(fileName);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(' ');
                string name = parts[0];
                int orderCount = int.Parse(parts[1]);

                int start = line.IndexOf('[') + 1;
                int end = line.IndexOf(']');
                string ordersPart = line.Substring(start, end - start);

                string[] orderStrings = ordersPart.Split(',');
                int[] orders = new int[orderStrings.Length];

                for (int j = 0; j < orderStrings.Length; j++)
                {
                    orders[j] = int.Parse(orderStrings[j]);
                }

                int qualifyingOrders = 0;
                for (int j = 0; j < orders.Length; j++)
                {
                    if (orders[j] >= minPrice)
                    {
                        qualifyingOrders++;
                    }
                }

                if (qualifyingOrders >= minOrders)
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}
