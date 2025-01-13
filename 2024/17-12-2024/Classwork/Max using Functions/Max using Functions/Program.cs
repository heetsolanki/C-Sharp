using System;

namespace Max
{
    class Max
    {
        public int max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            int b = int.Parse(Console.ReadLine());

            Max m = new Max();
            Console.WriteLine($"Max: {m.max(a,b)}");
            Console.ReadKey();
        }
    }
}