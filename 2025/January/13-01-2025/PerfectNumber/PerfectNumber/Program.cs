using System;

namespace PerfectNumber
{
    class PerfectNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine($"{num} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number.");
            }
            Console.ReadKey();
        }
    }
}
