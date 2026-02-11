using System;
using Microsoft.VisualBasic;

namespace Classapp
{
    internal class Book
    {
        public string Title;
        public List<string> Authors;
        public string Publisher;
        public string ISBN;
        public double Price;
        public int Stock;
        public string YearOfPublication;

        public int NumberOfAuthors;

        public Book()
        {
            Authors = new List<string>();
        }
        public Book(string Title, List<string> Authors, string Publisher, string ISBN, double Price, int Stock, string YearOfPublication)
        {
            this.Title = Title;
            this.Authors = Authors;
            this.Publisher = Publisher;
            this.ISBN = ISBN;
            this.Price = Price;
            this.Stock = Stock;
            this.YearOfPublication = YearOfPublication;
            this.NumberOfAuthors = Authors.Count();
        }

        public void SetTitle(string title)
        {
            Title = title;
        }
        public string GetTitle()
        {
            return Title;
        }

        public void SetAuthors(List<string> a)
        {
            Authors = a;
        }

        public void ShowAuthors()
        {
            for (int i = 0; i < Authors.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + Authors[i]);
            }
        }

        public void SetPublisher(string p)
        {
            Publisher = p;
        }

        public string GetPublisher()
        {
            return Publisher;
        }

        public void SetISBN(string i)
        {
            ISBN = i;
        }

        public string GetISBN()
        {
            return ISBN;
        }

        public void SetPrice(double p)
        {
            Price = p;
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetStock(int s)
        {
            Stock = s;
        }

        public int GetStock()
        {
            return Stock;
        }
        public void UpdateStock(int change)
        {
            Stock += change;
        }

        public bool HasTitle(string t)
        {
            return Title == t.ToLower();
        }

        public bool HasISBN(string i)
        {
            return ISBN == i.ToLower();
        }

        public override string ToString()
        {
            string authorsJoined = "";
            for (int i = 0; i < Authors.Count; i++)
            {
                authorsJoined += Authors[i];
                if (i < Authors.Count - 1)
                {
                    authorsJoined += ", ";
                }
            }

            string Info = "Title: " + Title + "\n" +
                          "Authors: " + authorsJoined + "\n" +
                          "Publisher: " + Publisher + "\n" +
                          "ISBN: " + ISBN + "\n" +
                          "Price: " + Price + "\n" +
                          "Stock: " + Stock + "\n" +
                          "Year: " + YearOfPublication + "\n";

            return Info;
        }
    }
}