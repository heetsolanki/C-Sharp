using System;

namespace Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of {n} numbers is {sum}");
            Console.ReadKey();
        }
    }
}