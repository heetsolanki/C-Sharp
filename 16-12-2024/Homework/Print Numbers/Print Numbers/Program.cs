using System;

namespace Print
{
    class Print
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter elements: ");
            do
            {
                num = int.Parse(Console.ReadLine());
                if(num == 99)
                    break;
                Console.WriteLine($"You entered: {num}");
            } while (true);
            Console.WriteLine("Program ended, you entered 99.");
            Console.ReadKey();
        }
    }
}