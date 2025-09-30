using System;
using System.Collections.Generic;
using System.IO;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Documents\\Projects\\c#\\ConsoleApp1\\books.txt";
            List<Book> library = new List<Book>();
            LoadData(library, path);

            while (true)
            {
                Console.Clear();
                string option = Menu();

                if (option == "1")
                {
                    Book newBook = AddBook(library);

                    if (BookExists(library, newBook.Title, newBook.Author))
                    {
                        Console.WriteLine("Error: This book already exists in the library.");
                        Console.ReadKey();
                    }
                    else
                    {
                        library.Add(newBook);
                        SaveData(library, path);
                        Console.WriteLine("Book Added! Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "2") 
                {
                    if (library.Count == 0)
                    {
                        Console.WriteLine("No books in library.");
                    }
                    else
                    {
                        Console.WriteLine("Books in Library:");
                        Console.WriteLine("-----------------------------");
                        for (int i = 0; i < library.Count; i++)
                        {
                            Console.WriteLine(library[i].ToString());
                        }
                    }
                    Console.WriteLine("Press any key to go back...");
                    Console.ReadKey();
                }
                else if (option == "3") 
                {
                    Console.Write("Enter Book ID to remove: ");
                    int removeId;
                    if (int.TryParse(Console.ReadLine(), out removeId))
                    {
                        bool removed = false;
                        for (int i = 0; i < library.Count; i++)
                        {
                            if (library[i].BookId == removeId)
                            {
                                library.RemoveAt(i);
                                SaveData(library, path);
                                Console.WriteLine("Book removed successfully!");
                                removed = true;
                                break;
                            }
                        }

                        if (!removed)
                        {
                            Console.WriteLine("Book not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid ID.");
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

   
        static Book AddBook(List<Book> library)
        {
            int id = GenerateNextId(library);
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            return new Book(id, title, author);
        }

        static string Menu()
        {
            Console.WriteLine("Library Management >");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display All Books");
            Console.WriteLine("3. Remove Book by ID");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        static void SaveData(List<Book> library, string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < library.Count; i++)
            {
                file.WriteLine(library[i].BookId + "," + library[i].Title + "," + library[i].Author);
            }
            file.Flush();
            file.Close();
        }

        static void LoadData(List<Book> library, string path)
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
                string title = ParseData(record, 2);
                string author = ParseData(record, 3);
                library.Add(new Book(id, title, author));
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

        static bool BookExists(List<Book> library, string title, string author)
        {
            for (int i = 0; i < library.Count; i++)
            {
                if (library[i].Title == title && library[i].Author == author)
                {
                    return true;
                }
            }
            return false;
        }

        static int GenerateNextId(List<Book> library)
        {
            if (library.Count == 0)
                return 1;
            return library[library.Count - 1].BookId + 1;
        }
    }

    public class Book
    {
        public int BookId;
        public string Title;
        public string Author;

        public Book(int id, string title, string author)
        {
            BookId = id;
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return "ID: " + BookId + ", Title: " + Title + ", Author: " + Author;
        }
    }
}
