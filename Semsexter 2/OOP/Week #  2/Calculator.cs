using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(2F, 6F);
            Console.WriteLine(c1.add());
            Console.WriteLine(c1.subtract());
            Console.WriteLine(c1.multiply());
            Console.WriteLine(c1.divide());
        }
    }

    class Calculator
    {
        public float oprnd1;
        public float oprnd2;

        public Calculator(float op1, float op2)
        {
            oprnd1 = op1;
            oprnd2 = op2;
        }

        public float add()
        {
            return oprnd1 + oprnd2;
        }

        public float subtract()
        {
            return oprnd1 - oprnd2;
        }

        public float multiply()
        {
            return oprnd1 * oprnd2;
        }

        public float divide()
        {
            return oprnd1 / oprnd2;
        }
    }
}
