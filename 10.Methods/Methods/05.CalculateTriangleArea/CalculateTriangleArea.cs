using System;

public class CalculateTriangleArea
{
    public static void Main()
    {
        var side = decimal.Parse(Console.ReadLine());
        var height = decimal.Parse(Console.ReadLine());

        var triangleArea = GetTriangleArea(side, height);

        Console.WriteLine(triangleArea);
    }

    public static decimal GetTriangleArea(decimal side, decimal height)
    {
        var area = side * height / 2;

        return area;
    }
}