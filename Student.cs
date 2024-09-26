using System;

namespace execrise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentApp oneStudent = new StudentApp("0001234567", "Joan", "Logan",
                                             "Senior", "English");
            Console.WriteLine("First Test:");
            DisplayInfo(oneStudent);
            Console.WriteLine();
            Console.WriteLine("Another Test:");
            Console.WriteLine(oneStudent.ToString());

            Console.ReadKey();
        }
        static void DisplayInfo(StudentApp aStudent)
        {
            Console.WriteLine($"Name: {aStudent.ReturnFullName()}");
            Console.WriteLine($"Major: {aStudent.getMajor()}");
        }
    }
}
