//Write a program to swap two numbers without using temporary variables.
using System;

namespace Swapping
{
    class Swapping
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value of b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping");
            Console.WriteLine("a = " + a + ", b = " + b);
            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine("After Swapping");
            Console.WriteLine("a = " + a + ", b = " + b);
            Console.ReadKey();
        }
    }
}
