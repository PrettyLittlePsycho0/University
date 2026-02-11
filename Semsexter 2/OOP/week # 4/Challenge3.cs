using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>();
            List<Member> members = new List<Member>();
            double totalSales = 0;
            double totalMembershipFees = 0;

            while (true)
            {
                Console.WriteLine("\n--- Bookstore Menu ---");
                Console.WriteLine("a. Add a Book");
                Console.WriteLine("b. Search Book by Title");
                Console.WriteLine("c. Search Book by ISBN");
                Console.WriteLine("d. Update Stock");
                Console.WriteLine("e. Add a Member");
                Console.WriteLine("f. Search Member by Name/ID");
                Console.WriteLine("g. Update Member Info");
                Console.WriteLine("h. Purchase a Book");
                Console.WriteLine("i. Display Total Sales & Membership Stats");
                Console.WriteLine("j. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "a")
                {
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author (comma separated if multiple): ");
                    List<string> authors = new List<string>(Console.ReadLine().Split(','));
                    Console.Write("Enter publisher: ");
                    string publisher = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Enter price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Enter stock: ");
                    int stock = int.Parse(Console.ReadLine());
                    Console.Write("Enter year of publication: ");
                    string year = Console.ReadLine();

                    books.Add(new Book(title, authors, publisher, isbn, price, stock, year));
                    Console.WriteLine("Book added successfully.");
                }
                else if (choice == "b")
                {
                    Console.Write("Enter title to search: ");
                    string title = Console.ReadLine();
                    Book b = null;
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].GetTitle() == title)
                        {
                            b = books[i];
                            break;
                        }
                    }
                    if (b == null) Console.WriteLine("Book not found.");
                    else Console.WriteLine(b.ToString());
                }
                else if (choice == "c")
                {
                    Console.Write("Enter ISBN to search: ");
                    string isbn = Console.ReadLine();
                    Book b = null;
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].GetISBN() == isbn)
                        {
                            b = books[i];
                            break;
                        }
                    }
                    if (b == null) Console.WriteLine("Book not found.");
                    else Console.WriteLine(b.ToString());
                }
                else if (choice == "d")
                {
                    Console.Write("Enter book title or ISBN: ");
                    string key = Console.ReadLine();
                    Book b = null;
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].GetTitle() == key || books[i].GetISBN() == key)
                        {
                            b = books[i];
                            break;
                        }
                    }
                    if (b == null)
                    {
                        Console.WriteLine("Book not found.");
                    }
                    else
                    {
                        Console.Write("Enter change in stock (+ to increase, - to decrease): ");
                        int change = int.Parse(Console.ReadLine());
                        b.UpdateStock(change);
                        Console.WriteLine("Stock updated. New stock: " + b.GetStock());
                    }
                }
                else if (choice == "e")
                {
                    Console.Write("Enter member name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter member ID: ");
                    string id = Console.ReadLine();
                    Console.Write("Enter money in bank: ");
                    double money = double.Parse(Console.ReadLine());
                    members.Add(new Member(name, id, money));
                    totalMembershipFees += 10;
                    Console.WriteLine("Member added. $10 membership fee charged.");
                }
                else if (choice == "f")
                {
                    Console.Write("Enter name or ID: ");
                    string key = Console.ReadLine();
                    Member m = null;
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (members[i].GetName() == key || members[i].GetMemberID() == key)
                        {
                            m = members[i];
                            break;
                        }
                    }
                    if (m == null)
                    {
                        Console.WriteLine("Member not found.");
                    }
                    else
                    {
                        Console.WriteLine("Name: " + m.GetName() + ", ID: " + m.GetMemberID() + ", Books Bought: " + m.GetNumberOfBooksBought() + ", Spent: " + m.GetAmountSpent());
                    }
                }
                else if (choice == "g")
                {
                    Console.Write("Enter member name or ID to update: ");
                    string key = Console.ReadLine();
                    Member m = null;
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (members[i].GetName() == key || members[i].GetMemberID() == key)
                        {
                            m = members[i];
                            break;
                        }
                    }
                    if (m == null)
                    {
                        Console.WriteLine("Member not found.");
                    }
                    else
                    {
                        Console.WriteLine("1. Update Name\n2. Update ID\n3. Update Both");
                        int opt = int.Parse(Console.ReadLine());
                        if (opt == 1)
                        {
                            Console.Write("Enter new name: ");
                            m.SetName(Console.ReadLine());
                        }
                        else if (opt == 2)
                        {
                            Console.Write("Enter new ID: ");
                            m.SetMemberID(Console.ReadLine());
                        }
                        else if (opt == 3)
                        {
                            Console.Write("Enter new name: ");
                            m.SetName(Console.ReadLine());
                            Console.Write("Enter new ID: ");
                            m.SetMemberID(Console.ReadLine());
                        }
                        Console.WriteLine("Member info updated.");
                    }
                }
                else if (choice == "h")
                {
                    Console.Write("Enter buyer name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter member ID (0 if non-member): ");
                    string id = Console.ReadLine();

                    Member m = null;
                    bool isMember = false;
                    if (id != "0")
                    {
                        for (int i = 0; i < members.Count; i++)
                        {
                            if (members[i].GetMemberID() == id && members[i].GetName() == name)
                            {
                                m = members[i];
                                break;
                            }
                        }
                        if (m == null)
                        {
                            Console.WriteLine("Member not found.");
                            continue;
                        }
                        isMember = true;
                    }

                    Console.WriteLine("\n--- Available Books ---");
                    for (int i = 0; i < books.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + books[i].GetTitle() + " | Price: " + books[i].GetPrice() + " | Stock: " + books[i].GetStock());
                    }

                    Console.Write("Enter book number to buy: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num < 1 || num > books.Count)
                    {
                        Console.WriteLine("Invalid selection.");
                        continue;
                    }

                    Book book = books[num - 1];
                    Console.Write("Enter quantity: ");
                    int qty = int.Parse(Console.ReadLine());
                    if (book.GetStock() < qty)
                    {
                        Console.WriteLine("Not enough stock.");
                        continue;
                    }

                    double totalPrice = book.GetPrice() * qty;
                    if (isMember)
                    {
                        totalPrice -= totalPrice * 0.05; // 5% discount
                        for (int i = 0; i < qty; i++)
                        {
                            m.BuyBook(book);
                        }

                        if (m.GetNumberOfBooksBought() % 11 == 0)
                        {
                            double discount = m.GetAmountSpent() / 10;
                            m.SetMoneyInBank(m.GetMoneyInBank() + discount);
                            Console.WriteLine("Loyalty reward! Discount of " + discount + " applied.");
                        }
                    }
                    else
                    {
                        book.UpdateStock(-qty);
                    }

                    totalSales += totalPrice;
                    Console.WriteLine("Purchase complete. Total cost: " + totalPrice);
                }
                else if (choice == "i")
                {
                    Console.WriteLine("Total Sales: " + totalSales);
                    Console.WriteLine("Total Members: " + members.Count);
                    Console.WriteLine("Membership Fees Collected: " + totalMembershipFees);
                }
                else if (choice == "j")
                {
                    Console.WriteLine("Exiting program...");
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
