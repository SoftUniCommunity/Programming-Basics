using System;

public class MinMethod
{
    public static void Main()
    {
        var num1 = int.Parse(Console.ReadLine());
        var num2 = int.Parse(Console.ReadLine());
        var num3 = int.Parse(Console.ReadLine());

        var min = GetMin(num1, GetMin(num2, num3));

        Console.WriteLine(min);
    }

    public static int GetMin(int a, int b)
    {
        return Math.Min(a, b);
    }
}