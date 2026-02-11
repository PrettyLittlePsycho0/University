using ConsoleApp1;

namespace ClassApp
{
    
    internal class Program
    {
        class Person
        {
            protected string name;
            protected string address;

            public Person(string name, string address)
            {
                this.name = name;
                this.address = address;
            }
            public string getName()
            {
                return name;
            }
            public string getAddress()
            {
                return address;
            }
            public void setAddress(string address)
            {
                this.address = address;
            }
            public virtual string toString()
            {
                return $"Person[name={name},address={address}]";
            }
        }
        class Student : Person
        {
            public string program;
            public int year;
            public double fee;

            public Student(string name, string address, string program, int year, double fee) :
                base(name, address)
            {
                this.program = program;
                this.year = year;
                this.fee = fee;
            }

            public override string toString()
            {
                return $"Student[{base.toString()},program={program},year={year},fee{fee}]";
            }
        }

        class Staff : Person
        {
            public string school;
            public double pay;

            public Staff(string name, string address, string school, double pay) :
                base(name, address)
            {
                this.school = school;
                this.pay = pay;
            }

            public override string toString()
            {
                return $"Staff[{base.toString()},school={school},pay={pay}]";
            }
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali", "Lahore", "CS", 2, 100000);
            Student s2 = new Student("Ahmed", "Lahore", "CS", 1, 150000);
            Staff st1 = new Staff("Ironman", "New York", "djk", 100000000000);
            Staff st2 = new Staff("Spider-Man", "Lahore", "asfds", 213423421);

            Console.Write(s1.toString() + "\n" +
            s2.toString() + "\n" +
            st1.toString() + "\n" +
            st2.toString());
        }
    }
}
