using System;

public class RadiansToDegrees
{
    public static void Main()
    {
        double rad = double.Parse(Console.ReadLine());

        double deg = rad * 180 / Math.PI;

        Console.WriteLine(Math.Round(deg, 2));
    }
}