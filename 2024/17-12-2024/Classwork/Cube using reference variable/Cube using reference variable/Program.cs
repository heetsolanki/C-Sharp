using System;

namespace Cube
{
    class Cube
    {
        public void cube(ref int a)
        {
            int result = a * a * a;
            Console.WriteLine($"Cube of {a} is {result}");
        }
        static void Main(string[] args )
        {
            Cube c = new Cube();
            Console.Write("Enter number: ");
            int x = int.Parse( Console.ReadLine() );
            c.cube(ref x);
            Console.ReadKey();
        }
    }
}