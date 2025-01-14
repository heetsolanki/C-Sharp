using System;

namespace Constructors
{
    class Default
    {
        int a, b, sum;
        Default()
        {
            a = 12;
            b = 15;
            sum = a + b;
        }
        static void Main(string[] args)
        {
            Default obj = new Default();
            Console.WriteLine("a = " + obj.a);
            Console.WriteLine("b = " + obj.b);
            Console.WriteLine($"{obj.a} + {obj.b} = {obj.sum}");
            Console.ReadKey();
        }
    }
}