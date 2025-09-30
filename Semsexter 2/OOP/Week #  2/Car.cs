using System;
using System.Collections.Generic;
using System.IO;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "cars.txt";
            List<Car> showroom = new List<Car>();
            LoadData(showroom, path);

            while (true)
            {
                Console.Clear();
                string option = Menu();

                if (option == "1")
                {
                    Car newCar = AddCar(showroom);

                    if (CarExists(showroom, newCar.Model))
                    {
                        Console.WriteLine("Error: This car model already exists in the showroom.");
                        Console.ReadKey();
                    }
                    else
                    {
                        showroom.Add(newCar);
                        SaveData(showroom, path);
                        Console.WriteLine("Car Added! Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "2")
                {
                    if (showroom.Count == 0)
                    {
                        Console.WriteLine("No cars in showroom.");
                    }
                    else
                    {
                        Console.WriteLine("Cars in Showroom:");
                        Console.WriteLine("-----------------------------");
                        for (int i = 0; i < showroom.Count; i++)
                        {
                            Console.WriteLine(showroom[i].ToString());
                        }
                    }
                    Console.WriteLine("Press any key to go back...");
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    if (showroom.Count == 0)
                    {
                        Console.WriteLine("No cars available.");
                    }
                    else
                    {
                        Car expensiveCar = showroom[0];
                        for (int i = 1; i < showroom.Count; i++)
                        {
                            if (showroom[i].Price > expensiveCar.Price)
                            {
                                expensiveCar = showroom[i];
                            }
                        }
                        Console.WriteLine("Most Expensive Car: " + expensiveCar.ToString());
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

        static Car AddCar(List<Car> showroom)
        {
            int id = GenerateNextId(showroom);
            Console.Write("Enter Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter Car Price: ");
            double price = double.Parse(Console.ReadLine());

            return new Car(id, model, price);
        }

        static string Menu()
        {
            Console.WriteLine("Car Showroom Management >");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Add Car");
            Console.WriteLine("2. Display All Cars");
            Console.WriteLine("3. Find Most Expensive Car");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        static void SaveData(List<Car> showroom, string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < showroom.Count; i++)
            {
                file.WriteLine(showroom[i].CarId + "," + showroom[i].Model + "," + showroom[i].Price);
            }
            file.Flush();
            file.Close();
        }

        static void LoadData(List<Car> showroom, string path)
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
                string model = ParseData(record, 2);
                double price = double.Parse(ParseData(record, 3));
                showroom.Add(new Car(id, model, price));
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

        static bool CarExists(List<Car> showroom, string model)
        {
            for (int i = 0; i < showroom.Count; i++)
            {
                if (showroom[i].Model == model)
                {
                    return true;
                }
            }
            return false;
        }

        static int GenerateNextId(List<Car> showroom)
        {
            if (showroom.Count == 0)
            {
                return 1;
            }
            return showroom[showroom.Count - 1].CarId + 1;
        }
    }

    public class Car
    {
        public int CarId;
        public string Model;
        public double Price;

        public Car(int id, string model, double price)
        {
            CarId = id;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return "ID: " + CarId + ", Model: " + Model + ", Price: " + Price;
        }
    }
}
