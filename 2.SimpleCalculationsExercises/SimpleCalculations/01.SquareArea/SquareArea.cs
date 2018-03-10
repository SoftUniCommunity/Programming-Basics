using System;

public class SquareArea
{
    public static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());

        double area = Math.Pow(a, 2);

        Console.Write("Square area = ");
        Console.WriteLine(area);
    }
}