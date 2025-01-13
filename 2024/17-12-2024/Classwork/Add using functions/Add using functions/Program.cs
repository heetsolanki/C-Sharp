using System;

namespace Addition
{
    class Addition
    {
        public void add(int a, int b)
        {
            Console.WriteLine($"Addition: {a + b}");
        }
        static void Main(string[] args)
        {
            Addition a = new Addition();
            Console.Write("Enter number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            int y = int.Parse(Console.ReadLine());
            a.add(x, y);
            Console.ReadKey();
        }
    }
}