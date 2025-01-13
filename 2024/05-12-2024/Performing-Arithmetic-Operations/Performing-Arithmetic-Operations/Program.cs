using System;
using System.Reflection.PortableExecutable;

namespace Performing_Arithmetic_Operation
{
    class Arithmetic_Operation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Operation to be performed: ");
            char operation = char.Parse(Console.ReadLine());
            if (operation == '+')
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            else if (operation == '-')
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else if (operation == '*')
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            else if (operation == '/')
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            else if (operation == '%')
            {
                Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            }
            else
            {
                Console.WriteLine("Invalid Operation");
            }
            Console.ReadKey();
        }
    }
}