using System;

public class PointInFigure
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool pointInRect1 = x >= 2 && x <= 12 && y >= -3 && y <= 1;
        bool pointInRect2 = x >= 4 && x <= 10 && y >= -5 && y <= 3;
        bool pointInFigure = pointInRect1 || pointInRect2;

        Console.WriteLine(pointInFigure ? "in" : "out");
    }
}