using System;

namespace Inheritance
{
    class MyNum
    {
        public int num;
        public void getNum(int x)
        {
            num = x;
        }
    }

    class Square:MyNum
    {
        public void calculateSquare()
        {
            int sqaure = num * num;
            Console.WriteLine($"Sqaure of {num} is {sqaure}");
        }

        static void Main(string[] args)
        {
            Square square = new Square();
            square.getNum(12);
            square.calculateSquare();
            Console.ReadKey();
        }
    }
}