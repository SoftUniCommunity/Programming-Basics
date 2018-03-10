using System;

public class TriangleArea
{
    public static void Main()
    {
        var sideA = double.Parse(Console.ReadLine());
        var heightA = double.Parse(Console.ReadLine());

        var area = Math.Round(sideA * heightA / 2, 2);

        Console.WriteLine($"Triangle area = {area}");
    }
}