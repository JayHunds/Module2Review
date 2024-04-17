using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        // Creating instances of Student
        var student1 = new Student { Name = "John Doe", ID = 1 };
        var student2 = new Student { Name = "Jane Smith", ID = 2 };
        var student3 = new Student();
        student3.Name = "Alice Johnson";
        student3.ID = 3;
        var student4 = new Student();
        student4.Name = "Bob Brown";
        student4.ID = 4;

        // Populating the list with instances
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);

        // Adding grades for each student
        student1.AddGrade(94.3);
        student1.AddGrade(90.0, 78.9, 95.4);

        student2.AddGrade(85.0, 88.5);
        student2.AddGrade(92.3);

        student3.AddGrade(75.0, 80.5, 77.8);

        student4.AddGrade(88.9);

        // Displaying student information
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
            Console.WriteLine("Grades: ");
            foreach (var grade in student.Grades)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade()}");
            Console.WriteLine();
        }
    }
}