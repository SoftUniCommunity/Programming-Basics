using System;

public class Histogram
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int cntP1 = 0;
        int cntP2 = 0;
        int cntP3 = 0;
        int cntP4 = 0;
        int cntP5 = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());

            if (currentNum >= 800)
            {
                cntP5++;
            }
            else if (currentNum >= 600)
            {
                cntP4++;
            }
            else if (currentNum >= 400)
            {
                cntP3++;
            }
            else if (currentNum >= 200)
            {
                cntP2++;
            }
            else
            {
                cntP1++;
            }
        }

        double p1Percentage = cntP1 * 100.0 / n;
        double p2Percentage = cntP2 * 100.0 / n;
        double p3Percentage = cntP3 * 100.0 / n;
        double p4Percentage = cntP4 * 100.0 / n;
        double p5Percentage = cntP5 * 100.0 / n;

        Console.WriteLine($"{p1Percentage:F2}%");
        Console.WriteLine($"{p2Percentage:F2}%");
        Console.WriteLine($"{p3Percentage:F2}%");
        Console.WriteLine($"{p4Percentage:F2}%");
        Console.WriteLine($"{p5Percentage:F2}%");
    }
}