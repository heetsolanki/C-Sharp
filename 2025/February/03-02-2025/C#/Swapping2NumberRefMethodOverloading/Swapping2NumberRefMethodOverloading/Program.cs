using System;

namespace Swapping
{
    class Swapping
    {
        public void Swap(ref int num1, ref int num2)
        {
            num1 = num2 - num1;
            num2 = num2 - num1; 
            num1 = num1 + num2;
        }
        public void Swap(ref double num1, ref double num2)
        {
            num1 = num2 - num1;
            num2 = num2 - num1;
            num1 = num1 + num2;
        }

        static void Main(string[] args)
        {
            Swapping swap = new Swapping();
            Console.WriteLine("Swapping Interger Number");
            // swapping interger numbers
            Console.Write("Enter first interger number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second interger number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swapping num1 = {num1} & num2 = {num2}");
            swap.Swap(ref num1, ref num2);
            Console.WriteLine($"After swapping num1 = {num1} & num2 = {num2}");

            // swapping double/float number
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Swapping Double Numbers");
            Console.Write("Enter first double number: ");
            double dnum1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second double number: ");
            double dnum2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Before swapping num1 = {dnum1} & num2 = {dnum2}");
            swap.Swap(ref dnum1, ref dnum2);
            dnum1 = Math.Round(dnum1, 2);
            dnum2 = Math.Round(dnum2, 2);
            Console.WriteLine($"After swapping num1 = {dnum1} & num2 = {dnum2}");
            Console.ReadKey();
        }
    }
}