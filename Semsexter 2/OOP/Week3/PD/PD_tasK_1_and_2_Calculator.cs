using System;
using System.Collections.Generic;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = null;

            while(true)
            {
                Console.Clear();
                string option = Menu();

                if (option == "1")
                {
                    Console.Clear();
                    calc = CreateCalculator();
                    Console.Write("\nCalculator Object Created. Press any key to continue...");
                    Console.ReadKey();
                }
                else if (option == "2")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        ChangeValues(calc);
                        Console.Write("\nValues Updated. Press any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "3")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.WriteLine("Addition Result: " + calc.Add());
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "4")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.WriteLine("Subtraction Result: " + calc.Subtract());
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "5")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.WriteLine("Multiplication Result: " + calc.Multiply());
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "6")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        double result = calc.Divide();
                        if (result != double.MinValue)
                        {
                            Console.WriteLine("Division Result: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "7")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        double result = calc.Modulo();
                        if (result != double.MinValue)
                        {
                            Console.WriteLine("Modulo Result: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Error: Modulo by zero is not allowed.");
                        }
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "8")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.Write("Enter number for Square Root: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Square Root: " + calc.Sqrt(n));
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "9")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.Write("Enter exponent for Exponential Function: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Exponential: " + calc.Exp(n));
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "10")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.Write("Enter number for Logarithm: ");
                        int n = int.Parse(Console.ReadLine());
                        double result = calc.Log(n);
                        if (result != double.MinValue)
                        {
                            Console.WriteLine("Logarithm: " + result);
                        }
                        else
                        {
                            Console.WriteLine("Error: Logarithm not defined for non-positive numbers.");
                        }
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "11")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.Write("Enter angle in degrees for Sine: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Sine: " + calc.Sin(n));
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "12")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.Write("Enter angle in degrees for Cosine: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cosine: " + calc.Cos(n));
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "13")
                {
                    Console.Clear();
                    if (calc != null)
                    {
                        Console.Write("Enter angle in degrees for Tangent: ");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tangent: " + calc.Tan(n));
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("You must first create the calculator object. Press any key to continue...");
                        Console.ReadKey();
                    }
                }
                else if (option == "14")
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid Choice. Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        static string Menu()
        {
            Console.Write("Calculator App >\n" +
                          "---------------------------------\n" +
                          "1. Create Calculator Object.\n" +
                          "2. Change Values of Attributes.\n" +
                          "3. Add.\n" +
                          "4. Subtract.\n" +
                          "5. Multiply.\n" +
                          "6. Divide.\n" +
                          "7. Modulo.\n" +
                          "8. Square Root.\n" +
                          "9. Exponential Function.\n" +
                          "10. Logarithm.\n" +
                          "11. Sine.\n" +
                          "12. Cosine.\n" +
                          "13. Tangent.\n" +
                          "14. Exit.\n" +
                          "Enter your choice: "
            );
            return Console.ReadLine();
        }

        static Calculator CreateCalculator()
        {
            Console.WriteLine("Create Calculator Object >");
            Console.WriteLine("--------------------------\n");
            Console.Write("Enter First Number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            double n2 = double.Parse(Console.ReadLine());
            return new Calculator(n1, n2);
        }

        static void ChangeValues(Calculator calc)
        {
            Console.WriteLine("Change Calculator Values >");
            Console.WriteLine("--------------------------\n");
            Console.Write("Enter First Number: ");
            calc.number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            calc.number2 = double.Parse(Console.ReadLine());
        }
    }

    class Calculator
    {
        public double number1;
        public double number2;

        public Calculator()
        {
            number1 = 10;
            number2 = 10;
        }

        public Calculator(double n1, double n2)
        {
            number1 = n1;
            number2 = n2;
        }

        public Calculator(Calculator c)
        {
            number1 = c.number1;
            number2 = c.number2;
        }

        public double Add()
        {
            return number1 + number2;
        }

        public double Subtract()
        {
            return number1 - number2;
        }

        public double Multiply()
        {
            return number1 * number2;
        }

        public double Divide()
        {
            if (number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                return double.MinValue;
            }
        }

        public double Modulo()
        {
            if (number2 != 0)
            {
                return number1 % number2;
            }
            else
            {
                return double.MinValue;
            }
        }

        public double Sqrt(int n)
        {
            if (n >= 0)
            {
                return Math.Sqrt(n);
            }
            else
            {
                return double.MinValue;
            }
        }

        public double Exp(int n)
        {
            return Math.Exp(n);
        }

        public double Log(int n)
        {
            if (n > 0)
            {
                return Math.Log(n);
            }
            else
            {
                return double.MinValue;
            }
        }

        public double Sin(int angle)
        {
            return Math.Sin(angle * Math.PI / 180);
        }

        public double Cos(int angle)
        {
            return Math.Cos(angle * Math.PI / 180);
        }

        public double Tan(int angle)
        {
            return Math.Tan(angle * Math.PI / 180);
        }
    }
}
