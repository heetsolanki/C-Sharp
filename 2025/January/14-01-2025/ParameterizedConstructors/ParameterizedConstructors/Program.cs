using System;

namespace Constructors
{
    class Parameterized
    {
        int a, b, sum;
        Parameterized(int x, int y)
        {
            a = x;
            b = y;
            sum = a + b;
        }
        static void Main(string[] args)
        {
            Parameterized obj = new Parameterized(25, 56);
            Console.WriteLine("a = " + obj.a);
            Console.WriteLine("b = " + obj.b);
            Console.WriteLine($"{obj.a} + {obj.b} = {obj.sum}");
            Console.ReadKey();
        }
    }
}