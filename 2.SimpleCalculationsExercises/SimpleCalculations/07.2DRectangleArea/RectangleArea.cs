using System;

public class RectangleArea
{
    public static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        //var width = Math.Abs(x1 - x2);
        //var height = Math.Abs(y1 - y2);
        var width = Math.Max(x1, x2) - Math.Min(x1, x2);
        var height = Math.Max(y1, y2) - Math.Min(y1, y2);

        var area = width * height;
        var perimeter = 2 * (width + height);

        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }
}