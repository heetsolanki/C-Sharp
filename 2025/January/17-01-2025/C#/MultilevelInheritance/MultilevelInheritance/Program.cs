using System;

namespace Inheritance
{
    class Number
    {
        public int a;
        public int b;

        public void getNum()
        {
            Console.Write("Enter num one: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter num two: ");
            b = int.Parse(Console.ReadLine());
        }
    }

    class Add:Number
    {
        public int addition()
        {
            return a + b;
        }
    }

    class Multiply:Add
    {
        public int multiplication()
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Multiply m = new Multiply();
            m.getNum();
            int add = m.addition();
            int multiply = m.multiplication();
            Console.WriteLine($"{m.a} + {m.b} = {add}");
            Console.WriteLine($"{m.a} * {m.b} = {multiply}");
            Console.ReadKey();
        }
    }
}