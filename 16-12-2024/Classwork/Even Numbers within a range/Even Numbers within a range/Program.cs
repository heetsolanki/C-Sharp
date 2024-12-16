using System;

namespace EvenNumber
{
    class Even
    {
        static void Main(string[] args)
        {
            Console.Write("Enter starting number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter ending number: ");
            int end = int.Parse(Console.ReadLine());
            for(int i = start; i <= end; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write($"{i} \t");
                }
            }
            Console.ReadKey();
        }
    }
}