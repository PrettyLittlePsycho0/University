using System;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter washing machine price: ");
            double priceWashingMachine = double.Parse(Console.ReadLine());
            Console.Write("Enter unit price of each toy: ");
            int toyPrice = int.Parse(Console.ReadLine());              

            double savedMoney = 0;
            int toysCount = 0;
            int moneyGift = 10;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) 
                {
                    savedMoney += moneyGift - 1; 
                    moneyGift += 10;
                }
                else
                {
                    toysCount++;
                }
            }

            savedMoney += toysCount * toyPrice;

            if (savedMoney >= priceWashingMachine)
            {
                Console.WriteLine("Yes!" + (savedMoney - priceWashingMachine));
            }
            else
            {
                Console.WriteLine($"No!" + (priceWashingMachine - savedMoney));
            }
        }
    }
}