using System;

namespace Krishnamurthy
{
    class Krishnamurthy
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int temporary = num;
            int remainder;
            int sum = 0;
            do
            {
                int factorial = 1;
                remainder = temporary % 10;
                for (int i = 1; i <= remainder; i++)
                {
                    factorial *= i;
                }
                temporary /= 10;
                sum += factorial;
            } while (temporary != 0);
            if(sum == num)
            {
                Console.WriteLine($"{num} is a Krishnamurthy number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a Krishnamurthy number.");
            }
            Console.ReadKey();
        }
    }
}