using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.WriteLine("\n1. Add Book");
                Console.WriteLine("2. Search by Title");
                Console.WriteLine("3. Search by ISBN");
                Console.WriteLine("4. Update Stock");
                Console.WriteLine("5. Show All Books");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter number of authors (max 4): ");
                    int n = int.Parse(Console.ReadLine());
                    List<string> authors = new List<string>();
                    for (int i = 0; i < n && i < 4; i++)
                    {
                        Console.Write("Author " + (i + 1) + ": ");
                        authors.Add(Console.ReadLine());
                    }

                    Console.Write("Enter Publisher: ");
                    string publisher = Console.ReadLine();

                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Enter Stock: ");
                    int stock = int.Parse(Console.ReadLine());

                    Console.Write("Enter Year of Publication: ");
                    string year = Console.ReadLine();

                    Book b = new Book(title, authors, publisher, isbn, price, stock, year);
                    books.Add(b);

                    Console.WriteLine("Book added successfully!");
                }
                else if (choice == 2)
                {
                    Console.Write("Enter Title to search: ");
                    string title = Console.ReadLine().ToLower();
                    bool found = false;

                    foreach (Book b in books)
                    {
                        if (b.GetTitle().ToLower() == title)
                        {
                            Console.WriteLine(b.ToString());
                            found = true;
                        }
                    }

                    if (!found) Console.WriteLine("Book not found.");
                }
                else if (choice == 3)
                {
                    Console.Write("Enter ISBN to search: ");
                    string isbn = Console.ReadLine().ToLower();
                    bool found = false;

                    foreach (Book b in books)
                    {
                        if (b.GetISBN().ToLower() == isbn)
                        {
                            Console.WriteLine(b.ToString());
                            found = true;
                        }
                    }

                    if (!found) Console.WriteLine("Book not found.");
                }
                else if (choice == 4)
                {
                    Console.Write("Enter ISBN to update stock: ");
                    string isbn = Console.ReadLine().ToLower();
                    bool found = false;

                    foreach (Book b in books)
                    {
                        if (b.GetISBN().ToLower() == isbn)
                        {
                            Console.Write("Enter change in stock (+/-): ");
                            int change = int.Parse(Console.ReadLine());
                            b.UpdateStock(change);
                            Console.WriteLine("Stock updated successfully!");
                            found = true;
                        }
                    }

                    if (!found) Console.WriteLine("Book not found.");
                }
                else if (choice == 5)
                {
                    if (books.Count == 0)
                    {
                        Console.WriteLine("No books available.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Book List ---");
                        foreach (Book b in books)
                        {
                            Console.WriteLine(b.ToString());
                        }
                    }
                }
                else if (choice == 6)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}
