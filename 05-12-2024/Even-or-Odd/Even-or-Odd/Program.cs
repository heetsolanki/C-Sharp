using System;

namespace Even_Odd
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int num = int.Parse (Console.ReadLine());
            if(num % 2 == 0)
                Console.WriteLine($"{num} is EVEN.");
            else
                Console.WriteLine($"{num} is ODD.");
            Console.ReadKey();
        }
    }
}