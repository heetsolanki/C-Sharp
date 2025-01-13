using System;
namespace Student
{
    class Student
    {
        int studentID;
        String studentName;
        String course;
        float percentage;

        void getData()
        {
            Console.Write("Enter your Student ID: ");
            studentID = int.Parse(Console.ReadLine());
            Console.Write("Enter your Name: ");
            studentName = Console.ReadLine();
            Console.Write("Enter your Course: ");
            course = Console.ReadLine();
            Console.Write("Enter your Percentage: ");
            percentage = float.Parse(Console.ReadLine());
        }

        void displayInfo()
        {
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Percentage: {percentage}");
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Accepting Student Information: ");
            student.getData();
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Displaying Student Information: ");
            student.displayInfo();
            Console.ReadKey();
        }
    }
}
