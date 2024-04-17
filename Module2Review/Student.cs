using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public List<double> Grades { get; } = new List<double>();

    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
            return 0;

        double sum = 0;
        foreach (var grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Count;
    }
}
