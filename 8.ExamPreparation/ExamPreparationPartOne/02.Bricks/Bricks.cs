using System;

public class Bricks
{
    public static void Main()
    {
        int bricksCount = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int trolleyCapacity = int.Parse(Console.ReadLine());

        double bricksPerCourse = workers * trolleyCapacity;
        double totalCourses = Math.Ceiling(bricksCount / bricksPerCourse);

        Console.WriteLine(totalCourses);
    }
}