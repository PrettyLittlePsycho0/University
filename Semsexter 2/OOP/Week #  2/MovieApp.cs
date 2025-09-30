using System;
using System.Collections.Generic;
using System.IO;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "movies.txt";
            List<Movie> movies = new List<Movie>();
            LoadData(movies, path);

            while (true)
            {
                Console.Clear();
                string option = Menu();

                if (option == "1")
                {
                    Movie newMovie = AddMovie(movies);

                    if (MovieExists(movies, newMovie.Title))
                    {
                        Console.WriteLine("Error: This movie already exists.");
                        Console.ReadKey();
                    }
                    else
                    {
                        movies.Add(newMovie);
                        SaveData(movies, path);
                        Console.WriteLine("Movie Added! Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "2")
                {
                    if (movies.Count == 0)
                    {
                        Console.WriteLine("No movies in system.");
                    }
                    else
                    {
                        Console.WriteLine("Movies in System:");
                        Console.WriteLine("-----------------------------");
                        for (int i = 0; i < movies.Count; i++)
                        {
                            Console.WriteLine(movies[i].ToString());
                        }
                    }
                    Console.WriteLine("Press any key to go back...");
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    Console.Write("Enter Movie Title to search: ");
                    string searchTitle = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < movies.Count; i++)
                    {
                        if (movies[i].Title == searchTitle)
                        {
                            Console.WriteLine("Movie Found: " + movies[i].ToString());
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Movie not found.");
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

        static Movie AddMovie(List<Movie> movies)
        {
            int id = GenerateNextId(movies);
            Console.Write("Enter Movie Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Movie Duration (in minutes): ");
            int duration = int.Parse(Console.ReadLine());

            return new Movie(id, title, duration);
        }

        static string Menu()
        {
            Console.WriteLine("Movie Management >");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Display All Movies");
            Console.WriteLine("3. Search Movie by Title");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        static void SaveData(List<Movie> movies, string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < movies.Count; i++)
            {
                file.WriteLine(movies[i].MovieId + "," + movies[i].Title + "," + movies[i].Duration);
            }
            file.Flush();
            file.Close();
        }

        static void LoadData(List<Movie> movies, string path)
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
                int duration = int.Parse(ParseData(record, 3));
                movies.Add(new Movie(id, title, duration));
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

        static bool MovieExists(List<Movie> movies, string title)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Title == title)
                {
                    return true;
                }
            }
            return false;
        }

        static int GenerateNextId(List<Movie> movies)
        {
            if (movies.Count == 0)
            {
                return 1;
            }
            return movies[movies.Count - 1].MovieId + 1;
        }
    }

    public class Movie
    {
        public int MovieId;
        public string Title;
        public int Duration;

        public Movie(int id, string title, int duration)
        {
            MovieId = id;
            Title = title;
            Duration = duration;
        }

        public override string ToString()
        {
            return "ID: " + MovieId + ", Title: " + Title + ", Duration: " + Duration + " mins";
        }
    }
}
