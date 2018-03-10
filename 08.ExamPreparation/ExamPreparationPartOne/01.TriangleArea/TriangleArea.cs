using System;

public class TriangleArea
{
    public static void Main()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        int side = Math.Abs(x2 - x3);
        int hight = Math.Abs(y2 - y1);

        double triangleArea = side * hight / 2.0;

        Console.WriteLine(triangleArea);
    }
}