using System;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            int temporary = num;
            while(temporary != 0)
            {
                reverse = (reverse * 10) + (temporary % 10);
                temporary = temporary / 10;
            }
            Console.WriteLine($"Reverse: {reverse}");
            if(reverse == num)
            {
                Console.WriteLine($"{reverse} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{reverse} is not Palindrome.");
            }
            Console.ReadKey();
        }
    }
}