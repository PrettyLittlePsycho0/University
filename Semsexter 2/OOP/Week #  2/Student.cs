using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student s1 = new Student();
            s1.StudentId = 1;
            s1.Name = "Ali";
            s1.GPA = 3.2;

            Student s2 = new Student(2, "Sara", 3.8);
            Student s3 = new Student(3, "Hassan", 2.9);

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);

            for (int i = 0; i < students.Count; i++)
            {
                students[i].DisplayDetails();
                Console.WriteLine("Honor Roll: " + students[i].IsHonorRoll());
                Console.WriteLine();
            }

            UpdateStudentGPA(students, 1, 3.7);

            Console.WriteLine("After GPA Update:");
            for (int i = 0; i < students.Count; i++)
            {
                students[i].DisplayDetails();
                Console.WriteLine("Honor Roll: " + students[i].IsHonorRoll());
                Console.WriteLine();
            }
        }

        static void UpdateStudentGPA(List<Student> students, int id, double newGpa)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentId == id)
                {
                    students[i].UpdateGPA(newGpa);
                }
            }
        }
    }

    class Student
    {
        public int StudentId;
        public string Name;
        public double GPA;

        public Student()
        {
            StudentId = 0;
            Name = "Unknown";
            GPA = 0.0;
        }

        public Student(int id, string name, double gpa)
        {
            StudentId = id;
            Name = name;
            GPA = gpa;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("ID: " + StudentId + ", Name: " + Name + ", GPA: " + GPA);
        }

        public void UpdateGPA(double newGpa)
        {
            GPA = newGpa;
        }

        public bool IsHonorRoll()
        {
            if (GPA >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
