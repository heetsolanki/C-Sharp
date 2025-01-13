using System;

namespace Positive_Negative
{
    class Positive_Negative
    {
        static void Main(string [] args)
        {
            int[] a = new int[10];
            int countP = 0; // Will be used for counting the number of positive numbers
            int countN = 0; // Will be used for counting the number of negative numbers
            Console.WriteLine("Enter 10 numbers: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] > 0)
                {
                    countP++;
                } 
                else
                {
                    countN++;
                }
            }
            Console.WriteLine($"There are {countP} positive and {countN} negative numbers.");
            Console.ReadKey();
        }
    }
}