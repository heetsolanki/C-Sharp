using System;

namespace Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("Area of Rectangle is: " + area);
            Console.ReadKey();
        }
    }
}