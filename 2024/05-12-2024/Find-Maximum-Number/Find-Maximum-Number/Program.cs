using System;

namespace Maximum_Number
{
    class Maximum_Number
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number 3: ");
            int c = int.Parse(Console.ReadLine());
            if(a > b)
            {
                if(a > c)
                {
                    Console.WriteLine($"{a} is maximum.");
                }
                else
                {
                    Console.WriteLine($"{c} is maximum.");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine($"{b} is maximum.");
                }
                else
                {
                    Console.WriteLine($"{c} is maximum.");
                }
            }
            Console.ReadKey();
        }
    }
}