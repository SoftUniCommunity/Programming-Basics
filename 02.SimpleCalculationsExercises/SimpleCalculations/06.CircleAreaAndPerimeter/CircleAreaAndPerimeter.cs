using System;

public class CircleAreaAndPerimeter
{
    public static void Main()
    {
        Console.Write("Enter circle radius. r = ");
        var r = double.Parse(Console.ReadLine());

        var area = Math.PI * r * r;
        var perimeter = 2 * Math.PI * r;

        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
    }
}