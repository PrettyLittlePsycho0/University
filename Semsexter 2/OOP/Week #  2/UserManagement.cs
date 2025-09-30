using System;
using System.Collections.Generic;
using System.IO;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Documents\\Projects\\c#\\ConsoleApp1\\users.txt";
            List<MUser> users = new List<MUser>();
            LoadData(users, path);

            while (true)
            {
                Console.Clear();
                string option = Menu();

                if (option == "1") 
                {
                    MUser newUser = AddUser();

                    if (UserExists(users, newUser.Usernme))
                    {
                        Console.WriteLine("Error: Username already exists. Try another.");
                        Console.ReadKey();
                    }
                    else
                    {
                        users.Add(newUser);
                        SaveData(users, path);
                        Console.WriteLine("User Added! Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "2") 
                {
                    Console.Write("Enter Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].Usernme == username && users[i].Password == password)
                        {
                            Console.WriteLine("Signed In as " + username + "!");
                            Console.WriteLine("Press any key to sign out...");
                            Console.ReadKey();
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Invalid Credentials. Press any key to go back...");
                        Console.ReadKey();
                    }
                }
                else if (option == "3") 
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

        static MUser AddUser()
        {
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter the Role: ");
            string role = Console.ReadLine();

            return new MUser(username, password, role);
        }

        static string Menu()
        {
            Console.WriteLine("User Management >");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        static void SaveData(List<MUser> users, string path)
        {
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < users.Count; i++)
            {
                file.WriteLine(users[i].Usernme + "," + users[i].Password + "," + users[i].Role);
            }
            file.Flush();
            file.Close();
        }

        static void LoadData(List<MUser> users, string path)
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
                string username = ParseData(record, 1);
                string password = ParseData(record, 2);
                string role = ParseData(record, 3);
                users.Add(new MUser(username, password, role));
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

        static bool UserExists(List<MUser> users, string username)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Usernme == username)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class MUser
    {
        public string Usernme;
        public string Password;
        public string Role;

        public MUser(string usernme, string password, string role)
        {
            Usernme = usernme;
            Password = password;
            Role = role;
        }
    }
}
