using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms to  be displayed in the series: ");
            int terms = int.Parse(Console.ReadLine());
            int i = 0, j = 1, sum = 0;
            Console.Write($"{i} \t");
            Console.Write($"{j} \t");
            for (int k = 0; k < terms; k++)
            {
                sum = i + j;
                Console.Write($"{sum} \t");
                i = j;
                j = sum;
            }
            Console.ReadKey();
        }
    }
}
