using System;

namespace Throw
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(String message) : base(message)
        {

        }
    }
    class Throw
    {
        static void validateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age should be greater than 18.");
            }
            else
            {
                Console.WriteLine("You are verified");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                validateAge(15);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}