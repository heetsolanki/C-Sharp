using System;

namespace Addition
{
    class Addition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Addition is: " + sum);
            Console.ReadKey();
        }
    }
}