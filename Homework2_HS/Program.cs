using System;

namespace Homework2_HS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t\t\t Hello!!! This is Has calculator. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            while (true)

            { 
                Console.Write("Enter first number: ");
                double num1 = InputeNumber();

                Console.Write("Do operation: ");
                string operation = Console.ReadLine();


                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Result = {Sum(num1)}");
                        break;
                    case "-":
                        Console.WriteLine($"Result = {Distinction(num1)}");
                        break;
                    case "*":
                        Console.WriteLine($"Result = {Multiplication(num1)}");
                        break;
                    case "/":
                        Division(num1);
                        break;
                    case "%":
                        Console.WriteLine($"Result = {Percent(num1)}%");
                        break;
                    case "root":
                        Root(num1);
                        break;
                    case "1/X":
                        Div1X(num1);
                        break;
                }
                Console.WriteLine();
            }
        }

        static double InputeNumber()
        {
            bool IsSameFormat;
            double number = default;
            do
            {
                try
                {
                    IsSameFormat = true;
                    number = int.Parse(Console.ReadLine());
                }
                catch (FormatException FE)
                {
                    IsSameFormat = false;
                    Console.Write($"{FE.Message}\nPlease enter again:) _ ");
                }
            } while (!IsSameFormat);
            return number;
        }

        static double Sum(double num1)
        {
            Console.Write("Enter second number: ");
            double num2 = InputeNumber();
            return (num1 + num2);
        }

        static double Distinction(double num1)
        {
            Console.Write("Enter second number: ");
            double num2 = InputeNumber();
            return num1 - num2;
        }

        static double Multiplication(double num1)
        {
            Console.Write("Enter second number: ");
            double num2 = InputeNumber();
            return num1 * num2;
        }

        static void Division(double num1)
        {
            Console.Write("Enter second number: ");
            double num2 = InputeNumber();
            if (num2 != 0)
            {
                Console.WriteLine($"Result = {num1 / num2}");
            }
            else
            {
                Console.Write("The number could not be 0. Enter number different 0 _ ");
                num2 = InputeNumber();
                Console.WriteLine($"Result = {num1 / num2}");
            }
        }

        static double Percent(double num1)
        {
            Console.Write("Enter persent: ");
            double num2 = InputeNumber();
            return num1 * num2 / 100;
        }

        static void Root(double num1)
        {
            Console.Write("Enter root: ");
            double num2 = InputeNumber();
            if (num2 != 0)
            {
                Console.WriteLine($"Result = {Math.Pow(num1, 1 / num2)}");
            }
            else
            {
                Console.Write("The number could not be 0. Enter number different 0 _ ");
                num2 = InputeNumber();
                Console.WriteLine($"Result = {Math.Pow(num1, 1 / num2)}");
            }
        }

        static void Div1X(double num1)
        {
            if (num1 != 0)
            {
                Console.WriteLine($"Result = {1 / num1}");
            }
            else
            {
                Console.Write("The number could not be 0. Enter number different 0 _ ");
                Console.WriteLine($"Result = {1 / num1}");
            }
        }

    }
}
