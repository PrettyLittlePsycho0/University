using System;
using System.Collections.Generic;

namespace BookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>();

            while (true)
            {
                Console.Clear();
                string choice = ShowMenu();
                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Add Book\n");
                    Console.WriteLine("------------------------------\n");
                    AddBook(bookList);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    Console.WriteLine("View All Books\n");
                    Console.WriteLine("------------------------------\n");
                    ViewBooks(bookList);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Get Author by Title\n");
                    Console.WriteLine("------------------------------\n");
                    string result = GetAuthor(bookList);
                    Console.WriteLine(result);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Sell Copies of Book\n");
                    Console.WriteLine("------------------------------\n");
                    string result = SellBook(bookList);
                    Console.WriteLine(result);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "5")
                {
                    Console.Clear();
                    Console.WriteLine("Restock Book\n");
                    Console.WriteLine("------------------------------\n");
                    string result = RestockBook(bookList);
                    Console.WriteLine(result);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "6")
                {
                    Console.Clear();
                    Console.WriteLine("Count Books\n");
                    Console.WriteLine("------------------------------\n");
                    Console.WriteLine("Total Books: " + bookList.Count);
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "7")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice");
                    Console.Write("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static string ShowMenu()
        {
            Console.WriteLine("Book Management Menu");
            Console.WriteLine("------------------------------\n");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Get Author by Title");
            Console.WriteLine("4. Sell Copies of Book");
            Console.WriteLine("5. Restock Book");
            Console.WriteLine("6. Count Books");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");
            return Console.ReadLine();
        }

        static void AddBook(List<Book> bookList)
        {
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author: ");
            string author = Console.ReadLine();
            Console.Write("Enter publication year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter stock quantity: ");
            int stock = Convert.ToInt32(Console.ReadLine());

            bookList.Add(new Book(title, author, year, price, stock));
            Console.WriteLine("Book added!");
        }

        static void ViewBooks(List<Book> bookList)
        {
            for (int i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine(bookList[i].BookDetails());
            }
        }

        static string GetAuthor(List<Book> bookList)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].title == title)
                {
                    return bookList[i].GetAuthor();
                }
            }
            return "Book not found";
        }

        static string SellBook(List<Book> bookList)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter number of copies to sell: ");
            int copies = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].title == title)
                {
                    return bookList[i].SellCopies(copies);
                }
            }
            return "Book not found";
        }

        static string RestockBook(List<Book> bookList)
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter number of copies to restock: ");
            int copies = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].title == title)
                {
                    return bookList[i].Restock(copies);
                }
            }
            return "Book not found";
        }
    }

    class Book
    {
        public string title;
        public string author;
        public int publicationYear;
        public double price;
        public int quantityInStock;

        public Book(string t, string a, int y, double p, int q)
        {
            title = t;
            author = a;
            publicationYear = y;
            price = p;
            quantityInStock = q;
        }

        public string GetTitle()
        {
            return "Title: " + title;
        }

        public string GetAuthor()
        {
            return "Author: " + author;
        }

        public string GetPublicationYear()
        {
            return "Publication Year: " + publicationYear;
        }

        public string GetPrice()
        {
            return "Price: " + price;
        }

        public string SellCopies(int numberOfCopies)
        {
            if (quantityInStock >= numberOfCopies)
            {
                quantityInStock -= numberOfCopies;
                return numberOfCopies + " copies sold.";
            }
            else
            {
                return "Not enough stock available.";
            }
        }

        public string Restock(int additionalCopies)
        {
            quantityInStock += additionalCopies;
            return "Restocked " + additionalCopies + " copies.";
        }

        public string BookDetails()
        {
            return "Title: " + title + ", Author: " + author + ", Year: " + publicationYear + ", Price: " + price + ", Stock: " + quantityInStock;
        }
    }
}
