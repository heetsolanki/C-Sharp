using System;

namespace ExceptionHandling
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                int result = 100 / num;
                Console.WriteLine($"100 / {num} = {result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot Divide by Zero.");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid Format");
            }
            catch(Exception e)
            {
                Console.WriteLine("Some error occured.");
            }
            Console.ReadKey();
        }
    }
}