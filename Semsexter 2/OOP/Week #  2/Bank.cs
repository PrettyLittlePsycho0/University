using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Classapp
{
    internal class Program
    {
        static int nextId = 0;
        static void Main(string[] args)
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();

            while (true)
            {
                string choice = Menu();

                if (choice == "1")
                {
                    bankAccounts.Add(OpenAccount(bankAccounts));
                    nextId++;
                }
                else if (choice == "2")
                {
                    Console.Write("Enter the account number: ");
                    int accountNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter the amount to deposit: ");
                    double amount = double.Parse(Console.ReadLine());
                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                        if (bankAccounts[i].AccountNumber == accountNumber)
                        {
                            bankAccounts[i].Deposit(amount);
                            Console.WriteLine("Success. Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Enter the account number: ");
                    int accountNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter the amount to deposit: ");
                    double amount = double.Parse(Console.ReadLine());
                    for (int i = 0; i < bankAccounts.Count; i++)
                    {
                        if (bankAccounts[i].AccountNumber == accountNumber)
                        {
                            if (bankAccounts[i].Withdraw(amount))
                            {
                                Console.WriteLine("Success. Press any key to continue...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Funds. Press any key to continue...");
                                Console.ReadKey();
                            }
                            break;
                        }
                    }

                }
                else if (choice == "4")
                {
                    DisplayAllAccount(bankAccounts);
                    Console.ReadKey();
                }
                else if (choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static string Menu()
        {
            Console.Clear();
            Console.WriteLine("Bank >");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Open an Account.");
            Console.WriteLine("2. Deposit.");
            Console.WriteLine("3. Withdraw.");
            Console.WriteLine("4. Show all accounts.");
            Console.WriteLine("5. Exit.");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        static BankAccount OpenAccount(List<BankAccount> bankAccounts)
        {
            Console.WriteLine("Enter Holder's name: ");
            string holderName = Console.ReadLine();
            Console.WriteLine("Enter starting balance: ");
            double balance = double.Parse(Console.ReadLine());
            return new BankAccount(nextId, holderName, balance);
        }
        static void DisplayAllAccount(List<BankAccount> bankAccounts)
        {
            Console.WriteLine("Bank Accounts >");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < bankAccounts.Count; i++)
            {
                Console.WriteLine(i+1 + ". " + bankAccounts[i].ToString());
            }
        }
    }

    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public override string ToString()
        {
            return "Account Number: " + AccountNumber + ", Holder's Name" + HolderName + ", Balance: " + Balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
