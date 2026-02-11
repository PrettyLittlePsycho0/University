using System;
using System.Collections.Generic;

namespace Classapp
{


    class Member
    {
        private string Name;
        private string MemberID;
        private List<Book> BooksBought;
        private int NumberOfBooksBought;
        private double MoneyInBank;
        private double AmountSpent;

        public Member()
        {
            BooksBought = new List<Book>();
        }

        public Member(string name, string id, double money)
        {
            Name = name;
            MemberID = id;
            MoneyInBank = money;
            AmountSpent = 0;
            NumberOfBooksBought = 0;
            BooksBought = new List<Book>();
        }

        public void SetName(string n)
        {
            Name = n;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetMemberID(string id)
        {
            MemberID = id;
        }

        public string GetMemberID()
        {
            return MemberID;
        }

        public void SetMoneyInBank(double money)
        {
            MoneyInBank = money;
        }

        public double GetMoneyInBank()
        {
            return MoneyInBank;
        }

        public double GetAmountSpent()
        {
            return AmountSpent;
        }

        public int GetNumberOfBooksBought()
        {
            return NumberOfBooksBought;
        }

        public void BuyBook(Book b)
        {
            if (b.GetStock() <= 0)
            {
                Console.WriteLine("Book is out of stock.");
                return;
            }
            if (MoneyInBank < b.GetPrice())
            {
                Console.WriteLine("Insufficient funds to buy this book.");
                return;
            }

            BooksBought.Add(b);
            NumberOfBooksBought++;
            MoneyInBank -= b.GetPrice();
            AmountSpent += b.GetPrice();
            b.UpdateStock(-1);

            Console.WriteLine("Book '" + b.GetTitle() + "' purchased successfully by " + Name + ".");
        }

        public void ShowBooksBought()
        {
            if (BooksBought.Count == 0)
            {
                Console.WriteLine(Name + " has not bought any books yet.");
            }
            else
            {
                Console.WriteLine("\nBooks bought by " + Name + ":");
                for (int i = 0; i < BooksBought.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + BooksBought[i].GetTitle() + " | Price: " + BooksBought[i].GetPrice());
                }
            }
            Console.WriteLine("Total books: " + NumberOfBooksBought + ", Amount spent: " + AmountSpent + ", Money left: " + MoneyInBank);
        }
    }
}