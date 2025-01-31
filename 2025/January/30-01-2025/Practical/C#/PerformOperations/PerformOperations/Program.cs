using System;

namespace PerformOperation
{
    class Operation
    {
        public void factorial()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = num; i > 0; i--)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {num} is {fact}");
        }

        public void moneyConverter()
        {
            double inr = 86.58;
            Console.Write("Enter number of dollars: ");
            double usd = double.Parse(Console.ReadLine());
            double convertedAmount = usd * inr;
            Console.WriteLine($"{usd}USD = {convertedAmount}INR");
        }

        public void temperatureConverter()
        {
            Console.Write("Enter temperature: ");
            double celsius = double.Parse(Console.ReadLine());
            double farenhiet = (9 / 5) * celsius + 32;
            Console.WriteLine($"{celsius}C = {farenhiet}F");
        }

        static void Main(string[] args)
        {
            Operation op = new Operation();
            Console.WriteLine("Enter number to perform the following operations:");
            Console.WriteLine("1 for factorial");
            Console.WriteLine("2 for money conversion");
            Console.WriteLine("3 for temperature conversion");
            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    op.factorial();
                    break;
                case 2:
                    op.moneyConverter();
                    break;
                case 3:
                    op.temperatureConverter();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            Console.ReadKey();
        }
    }
}
