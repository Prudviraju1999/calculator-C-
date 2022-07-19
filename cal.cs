using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input to be performed\n");
            Console.WriteLine("*input should be posive integer\n");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Factorial of Maximum value\n");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter 1st input");
            int inp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int inp2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (option)
            {
                case 1:
                    {
                        result = Calculator.Addition(inp1, inp2);
                        break;
                    }
                case 2:
                    {
                        result = Calculator.Subtraction(inp1, inp2);
                        break;
                    }
                case 3:
                    {
                        result = Calculator.Multiplication(inp1, inp2);
                        break;
                    }
                case 4:
                    {
                        result = Calculator.Division(inp1, inp2);
                        break;
                    }
                case 5:
                    {
                        result = SciCalculator.Max(inp1, inp2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong input!! try again");
                    break;
            }
            Console.WriteLine("\nYour result is " + result);
            Console.ReadKey();
        }
    }


    // Basic Calculator
    abstract class Calculator
    {
        //addition
        public static int Addition(int inp1, int inp2)
        {
            int result = inp1 + inp2;
            return result;
        }
        // Subtraction
        public static int Subtraction(int inp1, int inp2)
        {
            int result = inp1 - inp2;
            return result;
        }
        // Multiplication
        public static int Multiplication(int inp1, int inp2)
        {
            int result = inp1 * inp2;
            return result;
        }
        // Division
        public static int Division(int inp1, int inp2)
        {
            int result = inp1 / inp2;
            return result;
        }
    }


    // Scientific Calculator
    class SciCalculator : Calculator
    {
        // Factorial of Maximum
        public static int Max(int inp1, int inp2)
        {
            int maxVal = 0;
            if (inp1 > inp2)
            {
                maxVal = inp1;
            }
            else
            {
                maxVal =  inp2;
            }
            Console.WriteLine("\nMaximum Value is " + maxVal + " and");
            int fact = 1;
            for (int x = 1; x <= maxVal; x++)
            {
                fact *= x;
            }
            return fact;
        }

    }
}
