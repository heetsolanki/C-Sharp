using System;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3]; // Declaring the matrix 'a'
            int[,] b = new int[3, 3]; // Declaring the matrix 'b'
            int answer;

            Console.WriteLine("Enter elements for matrix a:");
            // Accepting elements for 3x3 matrix 'a'
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements for matrix b:");
            // Accepting elements for 3x3 matrix 'b'
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n------------------");

            // Printing the matrix 'a'
            Console.WriteLine("\nPrinting Matrix A: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            // Printing the matrix 'b'
            Console.WriteLine("\nPrinting Matrix A: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n------------------");

            // Subtracting and printing the matrix 'a'
            Console.WriteLine("\nSubtracting & Printing Matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    answer = a[i, j] - b[i, j];
                    Console.Write($"{answer} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}