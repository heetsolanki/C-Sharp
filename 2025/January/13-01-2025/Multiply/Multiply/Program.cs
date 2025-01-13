using System;
namespace Multiply
{
    class Multiply
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter number 4: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter number 4: ");
            int d = int.Parse(Console.ReadLine());
            int answer = a * b * c * d;
            Console.WriteLine($"Answer is {answer}");
            Console.ReadKey();
        }
    }
}
