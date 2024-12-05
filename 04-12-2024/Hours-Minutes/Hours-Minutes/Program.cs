using System;
 namespace HoursMinutes
{
    class HoursMinutes
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time (in minutes): ");
            int time = int.Parse(Console.ReadLine());
            int hour = time / 60;
            int minute = time % 60;
            Console.WriteLine("Time: " + hour + " hour(s), " + minute + " minute(s)");
            Console.ReadKey();
        }
    }
}