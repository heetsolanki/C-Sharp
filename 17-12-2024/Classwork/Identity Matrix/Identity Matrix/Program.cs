using System;

namespace Identity
{
    class Identity
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("Identity Matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        a[i, j] = 1;
                    }
                    else
                    {
                        a[i, j] = 0;
                    }
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}