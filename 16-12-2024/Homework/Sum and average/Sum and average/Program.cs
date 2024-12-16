using System;

namespace Sum_Average
{
    class Sum_Average
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            double sum = 0, average = 0;
            Console.WriteLine("Enter elements: ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
                sum += a[i];
            }
            average = sum / 5;
            Console.WriteLine($"Sum: {sum} and Average: {average}");
            Console.ReadKey();
        }
    }
}