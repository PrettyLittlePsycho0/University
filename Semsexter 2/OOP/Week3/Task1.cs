using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentResult s1 = new StudentResult(1, "Ali", "CS", 3, 78, 82, 91, 66, 74);
            StudentResult s2 = new StudentResult(2, "Sara", "IT", 2, 88, 90, 77, 69, 95);

            List<StudentResult> results = new List<StudentResult>();
            results.Add(s1);
            results.Add(s2);

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i].GetFullResult());
                Console.WriteLine();
            }
        }
    }

    class StudentResult
    {
        public int StudentId;
        public string Name;
        public string Department;
        public int Semester;
        public int MarksOfSubject1;
        public int MarksOfSubject2;
        public int MarksOfSubject3;
        public int MarksOfSubject4;
        public int MarksOfSubject5;

        public StudentResult(int id, string name, string department, int semester, int m1, int m2, int m3, int m4, int m5)
        {
            StudentId = id;
            Name = name;
            Department = department;
            Semester = semester;
            MarksOfSubject1 = m1;
            MarksOfSubject2 = m2;
            MarksOfSubject3 = m3;
            MarksOfSubject4 = m4;
            MarksOfSubject5 = m5;
        }

        public int GetTotalMarks()
        {
            return MarksOfSubject1 + MarksOfSubject2 + MarksOfSubject3 + MarksOfSubject4 + MarksOfSubject5;
        }

        public double GetAverageMarks()
        {
            return GetTotalMarks() / 5.0;
        }

        public string GetGrade()
        {
            double avg = GetAverageMarks();
            if (avg >= 85)
            {
                return "A";
            }
            else if (avg >= 70)
            {
                return "B";
            }
            else if (avg >= 55)
            {
                return "C";
            }
            else if (avg >= 40)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public string GetFullResult()
        {
            return "ID: " + StudentId + ", Name: " + Name + ", Department: " + Department + ", Semester: " + Semester
                   + ", Total: " + GetTotalMarks() + ", Average: " + GetAverageMarks() + ", Grade: " + GetGrade();
        }
    }
}
