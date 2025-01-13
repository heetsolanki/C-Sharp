using System;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements: ");
            int[] a = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{a[i]}\t");
            }
            Console.ReadKey();
        }
    }
}