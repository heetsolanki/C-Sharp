using System;

namespace Number_to_Day
{
    class Day
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int day = int.Parse(Console.ReadLine());
            switch(day)
            {
                case 1:
                    Console.WriteLine("MONDAY");
                    break;
                case 2:
                    Console.WriteLine("TUESDAY");
                    break;
                case 3:
                    Console.WriteLine("WEDNESDAY");
                    break;
                case 4:
                    Console.WriteLine("THURSDAY");
                    break;
                case 5:
                    Console.WriteLine("FRIDAY");
                    break;
                case 6:
                    Console.WriteLine("SATURDAY");
                    break;
                case 7:
                    Console.WriteLine("SUNDAY");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
            Console.ReadKey();
        }
    }
}