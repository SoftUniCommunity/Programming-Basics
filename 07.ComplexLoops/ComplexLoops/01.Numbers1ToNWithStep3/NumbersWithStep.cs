using System;

public class NumbersWithStep
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int num = 1; num <= n; num += 3)
        {
            Console.WriteLine(num);
        }
    }
}