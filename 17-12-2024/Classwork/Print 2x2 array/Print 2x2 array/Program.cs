using System;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2]; // Declaring the matrix
            Console.WriteLine("Enter elements:");
            // Accepting elements for 2x2 matrix
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            // Printing the matrix
            Console.WriteLine("\nPrinting Matrix: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}