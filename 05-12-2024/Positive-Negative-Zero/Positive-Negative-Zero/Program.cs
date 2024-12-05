using System;

namespace Positve_Negative_Zero
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"{num} is POSITIVE.");
            } else if (num == 0)
            {
                Console.WriteLine($"{num} is ZERO.");
            } else
            {
                Console.WriteLine($"{num} is NEGATIVE.");
            }
            Console.ReadKey();
        }
    }
}