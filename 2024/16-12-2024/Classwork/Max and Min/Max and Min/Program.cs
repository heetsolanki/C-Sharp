using System;

namespace Min_Max
{
    class Min_max
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int min = 0;
            int max = 0;
            Console.WriteLine("Enter 10 elements: ");
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            min = a[0];
            max = a[0];
            for(int i = 0; i < 10; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine($"{min} is minimum and {max} is maximum.");
            Console.ReadKey();
        }
    }
}