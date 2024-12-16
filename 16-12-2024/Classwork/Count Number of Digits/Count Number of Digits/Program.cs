using System;

namespace Number_of_Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int count = 0;
            if(num < 0)
            {
                Console.WriteLine("Warning: Number is negative!");
            }
            else
            {
                while(temp != 0)
                {
                    temp /= 10;
                    count++;
                }
                Console.WriteLine($"{num} contains {count} digit(s).");
            }
            Console.ReadKey();
        }
    }
}