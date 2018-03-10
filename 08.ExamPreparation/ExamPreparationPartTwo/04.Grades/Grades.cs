using System;

public class Grades
{
    public static void Main()
    {
        int numberOfStudents = int.Parse(Console.ReadLine());

        int topStudents = 0;
        int goodStudents = 0;
        int averageStudents = 0;
        int failedStudents = 0;
        double sumOfGrades = 0;

        for (int i = 0; i < numberOfStudents; i++)
        {
            double studentGrade = double.Parse(Console.ReadLine());
            sumOfGrades += studentGrade;

            if (studentGrade >= 5.00)
            {
                topStudents++;
            }
            else if (studentGrade >= 4.00)
            {
                goodStudents++;
            }
            else if (studentGrade >= 3.00)
            {
                averageStudents++;
            }
            else
            {
                failedStudents++;
            }
        }

        double topStudentsPercentage = 100.0 * topStudents / numberOfStudents;
        double goodStudentsPercentage = 100.0 * goodStudents / numberOfStudents;
        double averageStudentsPercentage = 100.0 * averageStudents / numberOfStudents;
        double failStudentsPercentage = 100.0 * failedStudents / numberOfStudents;
        double averageGrade = sumOfGrades / numberOfStudents;

        Console.WriteLine($"Top students: {topStudentsPercentage:F2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {goodStudentsPercentage:F2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {averageStudentsPercentage:F2}%");
        Console.WriteLine($"Fail: {failStudentsPercentage:F2}%");
        Console.WriteLine($"Average: {averageGrade:F2}");
    }
}