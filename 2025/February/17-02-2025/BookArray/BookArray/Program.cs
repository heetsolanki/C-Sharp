using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Book
        {


            public string BookName;
            public string AuthorName;
            public decimal Price;


            public void GetData()
            {
                Console.Write("Enter Book Name: ");
                BookName = Console.ReadLine();

                Console.Write("Enter Author Name: ");
                AuthorName = Console.ReadLine();

                Console.Write("Enter Price: ");
                Price = Convert.ToDecimal(Console.ReadLine());
            }


            public void Display()
            {
                Console.WriteLine($"Book Name: {BookName} Author Name: {AuthorName} Price: {Price} ");
            }
        }

        static void Main(string[] args)
        {
            const int numberOfBooks = 3;
            Book[] books = new Book[numberOfBooks];


            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.WriteLine($"\nEnter details for Book {i + 1}:");
                books[i] = new Book();
                books[i].GetData();
            }

            Console.WriteLine("\nBook Details:");
            for (int i = 0; i < numberOfBooks; i++)
            {
                books[i].Display();
            }
            Console.ReadKey();
        }
    }
}
