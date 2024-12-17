using System;

namespace Employee
{
    class Employee
    {
        String empName;
        int empID;
        double salary;
        int workingDays;

        public void acceptInfo()
        {
            Console.WriteLine("Accepting Employee Info: \n");
            Console.Write("Enter your name: ");
            empName = Console.ReadLine();
            Console.Write("Enter your ID: ");
            empID = int.Parse(Console.ReadLine());
            Console.Write("Enter your daily salary: ");
            salary = double.Parse(Console.ReadLine());
        }

        public void displayInfo()
        {
            Console.Write("Enter number of wokring days: ");
            workingDays = int.Parse(Console.ReadLine());

            double totalSalary = workingDays * salary;
            Console.WriteLine("\n------------------------");
            Console.WriteLine("Displaying Employee Info: \n");
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Daily Salary: {salary}");
            Console.WriteLine($"Total Salary: {totalSalary}");
        }

        static void Main(string [] args)
        {
            Employee emp = new Employee();
            emp.acceptInfo();
            emp.displayInfo();
            Console.ReadKey();
        }
    }
}