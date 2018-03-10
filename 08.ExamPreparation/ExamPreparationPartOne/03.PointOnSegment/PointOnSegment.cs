using System;

public class PointOnSegment
{
    public static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());

        int left = Math.Min(first, second);
        int right = Math.Max(first, second);
        int leftDistance = Math.Abs(left - point);
        int rightDistance = Math.Abs(right - point);
        int minDistance = Math.Min(leftDistance, rightDistance);
        bool inSegment = point >= left && point <= right;

        Console.WriteLine(inSegment ? "in" : "out");
        Console.WriteLine(minDistance);
    }
}