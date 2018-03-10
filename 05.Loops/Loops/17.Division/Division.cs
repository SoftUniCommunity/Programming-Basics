using System;

public class Division
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int divisibleBy2 = 0;
        int divisibleBy3 = 0;
        int divisibleBy4 = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());

            if (currentNum % 2 == 0)
            {
                divisibleBy2++;
            }

            if (currentNum % 3 == 0)
            {
                divisibleBy3++;
            }

            if (currentNum % 4 == 0)
            {
                divisibleBy4++;
            }
        }

        double p1Percentage = divisibleBy2 * 100.0 / n;
        double p2Percentage = divisibleBy3 * 100.0 / n;
        double p3Percentage = divisibleBy4 * 100.0 / n;

        Console.WriteLine($"{p1Percentage:F2}%");
        Console.WriteLine($"{p2Percentage:F2}%");
        Console.WriteLine($"{p3Percentage:F2}%");
    }
}