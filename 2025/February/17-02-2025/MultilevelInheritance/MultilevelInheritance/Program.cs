using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Number
    {
        public int num1, num2;
        public void getNum()
        {
            Console.Write("Enter num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2: ");
            num2 = int.Parse(Console.ReadLine());
        }
    }

    class Addition : Number
    {
        public void add()
        {
            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }
    }

    class Multiplication : Addition
    {
        public void multiply()
        {
            int result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
        }

        static void Main(string[] args)
        {
            Multiplication m = new Multiplication();
            Console.WriteLine("Accepting Numbers: ");
            m.getNum();
            Console.WriteLine("\nAdding Numbers: ");
            m.add();
            Console.WriteLine("\nMultiplying Numbers: ");
            m.multiply();
            Console.ReadKey();
        }
    }
}
