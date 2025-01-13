using System;

namespace HappyNumber
{
    class HappyNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            bool isHappy = false;
            int iteration = 100;
            while (tempNum != 1 && iteration != 0)
            {
                int sum = 0, rem = 0;
                while(tempNum > 0)
                {
                    rem = tempNum % 10;
                    sum += rem * rem;
                    tempNum /= 10;
                }
                tempNum = sum;
                iteration--;
                if (tempNum == 1)
                {
                    isHappy = true;
                    break;
                }
                if (tempNum == num)
                {
                    break;
                }
            }
            if (isHappy)
            {
                Console.WriteLine(num + " is a happy number.");
            }
            else
            {
                Console.WriteLine(num + " is not a happy number.");
            }
            Console.ReadKey();
        }
    }
}