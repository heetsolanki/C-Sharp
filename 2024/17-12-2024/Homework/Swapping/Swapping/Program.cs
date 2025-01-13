using System;

namespace Swapping
{
    class Swapping
    {
        public void swapping(ref int a, ref int b)
        {
            Console.WriteLine("\nBefore Swapping: ");
            Console.WriteLine($"a = {a} and b = {b}");

            int temp;
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("\nAfter Swapping: ");
            Console.WriteLine($"a = {a} and b = {b}");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            int b = int.Parse(Console.ReadLine());

            Swapping s = new Swapping();
            s.swapping(ref a, ref b);
            Console.ReadKey();
        }
    }
}