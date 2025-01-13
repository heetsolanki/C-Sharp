using System;

namespace LightOnOff
{
    class Light
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for positive: ");
            bool positive = bool.Parse(Console.ReadLine());
            Console.Write("Enter value for negative: ");
            bool negative = bool.Parse(Console.ReadLine());

            if ((positive && negative) == true)
            {
                Console.WriteLine("Light is ON!");
            }
            else if(positive == true &&  negative == false)
            {
                Console.WriteLine("Light is OFF!");
            }
            else if (positive == false && negative == true)
            {
                Console.WriteLine("Light is OFF!");
            }
            else
            {
                Console.WriteLine("Please plug in the switch!");
            }
            Console.ReadKey();
        }
    }
}