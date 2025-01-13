using System;

namespace Cube_Power
{
    class Cube_Power
    {
        public void calculate(int num, out int cube, out int power)
        {
            power = 1;
            cube = num * num * num;
            for(int i = 1; i <= num; i++)
            {
                power *= 2;
            }
        }

        static void Main(string[] args)
        {
            int cube, power;
            Cube_Power cp = new Cube_Power();
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            cp.calculate(num, out cube, out power);
            Console.WriteLine($"Cube: {cube}");
            Console.WriteLine($"Power: {power}");
            Console.ReadKey();
        }
    }
}