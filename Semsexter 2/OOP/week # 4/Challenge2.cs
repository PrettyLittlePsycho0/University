using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Program
    {
        static void Main()
        {
             List<Book> storeBooks = new List<Book>()
            {
                new Book("The Alchemist", new List<string>{"Paulo Coelho"}, "HarperCollins", "1111", 1200, 5, "23"),
                new Book("Inferno", new List<string>{"Dan Brown"}, "Doubleday", "2222", 1500, 3, "23"),
                new Book("The Hobbit", new List<string>{"J.R.R. Tolkien"}, "Allen & Unwin", "3333", 1000, 7, "23")
            };

            List<Member> members = new List<Member>();

            while (true)
            {
                Console.WriteLine("\n--- Member Management Menu ---");
                Console.WriteLine("1. Add Member");
                Console.WriteLine("2. Show All Members");
                Console.WriteLine("3. Buy Book");
                Console.WriteLine("4. Show Books Bought by Member");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter member name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter member ID: ");
                    string id = Console.ReadLine();
                    Console.Write("Enter money in bank: ");
                    double money = double.Parse(Console.ReadLine());
                    members.Add(new Member(name, id, money));
                    Console.WriteLine("Member added successfully.");
                }
                else if (choice == 2)
                {
                    if (members.Count == 0)
                    {
                        Console.WriteLine("No members added yet.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Members List ---");
                        for (int i = 0; i < members.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + members[i].GetName());
                        }
                    }
                }
                else if (choice == 3)
                {
                    Console.Write("Enter member ID: ");
                    string id = Console.ReadLine();
                    Member m = null;
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (members[i].GetMemberID() == id)
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

                    Console.WriteLine("\n--- Available Books ---");
                    for (int i = 0; i < storeBooks.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + storeBooks[i].GetTitle() + " | Price: " + storeBooks[i].GetPrice() + " | Stock: " + storeBooks[i].GetStock());
                    }
                    Console.Write("Enter book number to buy: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num < 1 || num > storeBooks.Count)
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                    else
                    {
                        m.BuyBook(storeBooks[num - 1]);
                    }
                }
                else if (choice == 4)
                {
                    Console.Write("Enter member ID: ");
                    string id = Console.ReadLine();
                    Member m = null;
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (members[i].GetMemberID() == id)
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
                        m.ShowBooksBought();
                    }
                }
                else if (choice == 5)
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
