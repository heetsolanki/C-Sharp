using System;

namespace Rectangle
{
    class Rectangle
    {
        int length, breadth;

        Rectangle()
        {
            length = 12;
            breadth = 6;
        }

        int area()
        {
            return length * breadth;
        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine($"Length = {r.length}");
            Console.WriteLine($"Breadth = {r.breadth}");
            Console.WriteLine("Area of rectangle is: " + r.area());
            Console.ReadKey();
        }
    }
}