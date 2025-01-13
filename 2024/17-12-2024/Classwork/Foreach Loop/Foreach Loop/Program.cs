using System;

namespace Foreach
{
    class Foreach
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < 3; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Printing Matrix");
            foreach (int i in a)
            {
                Console.Write($"{i}\t");
            }
            Console.ReadKey();
        }
    }
}