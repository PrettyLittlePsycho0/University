using System;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.Clear();
                string option = Menu();
                if (option == "1")
                {
                    students.Add(getStudentData());
                    Console.WriteLine("Student Added!!");
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    DisplayAllStudents(students);
                    Console.ReadKey();
                }
                else if (option == "3")
                {
                    CalculateAggregate(students);
                    Console.WriteLine("Aggregate Calculated!!");
                    Console.ReadKey();
                }
                else if (option == "4")
                {
                    SortByAggregate(students);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(students[i].ToString());
                    }
                    Console.ReadKey();
                }
                else if (option == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!");
                    Console.ReadKey();
                }
            }
        }
        static void DisplayAllStudents(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }
        static string Menu()
        {
            Console.WriteLine("Student Management System >");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Calculate Aggregate");
            Console.WriteLine("4. Top 3 Students");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string option = Console.ReadLine();
            return option;
        }
        static Student getStudentData()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Matric marks: ");
            double matric = double.Parse(Console.ReadLine());
            Console.Write("Enter Inter marks: ");
            double inter = double.Parse(Console.ReadLine());
            Console.Write("Enter ecat marks: ");
            double ecat = double.Parse(Console.ReadLine());
            Student obj = new Student(name, matric, inter, ecat);
            return obj;
        }
        static void CalculateAggregate(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                students[i].aggregate = ((0.25 * (students[i].matric / 1100)) + (0.45 * (students[i].inter / 560)) + (0.30 * (students[i].ecat / 400))) * 100;
            }
        }
        static void SortByAggregate(List<Student> students)
        {
            students.Sort(CompareStudents);
        }
        static int CompareStudents(Student s1, Student s2)
        {
            if (s1.aggregate > s2.aggregate) return -1;
            if (s1.aggregate < s2.aggregate) return 1;
            return 0;
        }
    }

    public class Student
    {
        public string name;
        public double matric;
        public double inter;
        public double ecat;
        public double aggregate;

        public Student(string name, double matric, double inter, double ecat)
        {
            this.name = name;
            this.matric = matric;
            this.inter = inter;
            this.ecat = ecat;
        }

        override public string ToString()
        {
            return "Name: " + name + ", Matric: " + matric + ", Inter: " + inter + ", ECAT: " + ecat + ", Aggregate: " + aggregate;
        }
    }

}