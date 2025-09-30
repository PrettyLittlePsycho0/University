using System;
using System.Collections.Generic;
using System.IO;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Medicine> medicines = LoadMedicines("medicines.txt");
            DisplayMedicines(medicines);
        }

        static List<Medicine> LoadMedicines(string fileName)
        {
            List<Medicine> medicines = new List<Medicine>();
            string[] lines = File.ReadAllLines(fileName);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string title = parts[0];
                string expiryDate = parts[1];
                int price = int.Parse(parts[2]);
                Medicine med = new Medicine(title, expiryDate, price);
                medicines.Add(med);
            }
            return medicines;
        }

        static void DisplayMedicines(List<Medicine> medicines)
        {
            for (int i = 0; i < medicines.Count; i++)
            {
                Console.WriteLine(medicines[i].ToString());
            }
        }
    }

    class Medicine
    {
        public string Title;
        public string ExpiryDate;
        public int Price;

        public Medicine(string title, string expiryDate, int price)
        {
            Title = title;
            ExpiryDate = expiryDate;
            Price = price;
        }

        public override string ToString()
        {
            return "Title: " + Title + ", Expiry Date: " + ExpiryDate + ", Price: " + Price;
        }
    }
}
