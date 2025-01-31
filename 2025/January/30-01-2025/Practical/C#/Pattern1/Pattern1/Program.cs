using System;

namespace Pattern
{
    class Pattern
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
