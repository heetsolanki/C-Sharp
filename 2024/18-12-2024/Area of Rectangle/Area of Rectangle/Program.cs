using System;

namespace Reactangle
{
    class Rectangle
    {
        public static void Area(int length, int breadth, out int area, out int perimeter) // static method name 'Area'
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
        static void Main(string[] args)
        {
            int area, perimeter;
            Console.Write("Enter length: ");
            int length = int.Parse(Console.ReadLine()); // accepting length
            Console.Write("Enter breadth: "); 
            int breadth= int.Parse(Console.ReadLine()); // accepting breadth
            Area(length, breadth, out area, out perimeter); // calling the method, no object required as it a static methods
            Console.WriteLine($"Area of Rectangle: {area}");
            Console.WriteLine($"Perimeter of Rectangle: {perimeter}");
            Console.ReadKey();
        }
        
    }
}