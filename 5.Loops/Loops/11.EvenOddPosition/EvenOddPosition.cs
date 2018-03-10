using System;

public class EvenOddPosition
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double oddSum = 0.00;
        double evenSum = 0.00;
        double oddMax = double.MinValue;
        double evenMax = double.MinValue;
        double oddMin = double.MaxValue;
        double evenMin = double.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            double currentNum = double.Parse(Console.ReadLine());

            if (i % 2 != 0)
            {
                oddSum += currentNum;

                if (currentNum > oddMax)
                {
                    oddMax = currentNum;
                }

                if (currentNum < oddMin)
                {
                    oddMin = currentNum;
                }
            }
            else
            {
                evenSum += currentNum;

                if (currentNum > evenMax)
                {
                    evenMax = currentNum;
                }

                if (currentNum < evenMin)
                {
                    evenMin = currentNum;
                }
            }
        }

        PrintResult(oddSum, evenSum, oddMax, evenMax, oddMin, evenMin);
    }

    public static void PrintResult(double oddSum, double evenSum, double oddMax, double evenMax, double oddMin, double evenMin)
    {
        Console.WriteLine($"OddSum={oddSum},");
        Console.Write("OddMin=");
        Console.WriteLine(oddMin != double.MaxValue ? $"{oddMin}," : "No,");
        Console.Write("OddMax=");
        Console.WriteLine(oddMax != double.MinValue ? $"{oddMax}," : "No,");
        Console.WriteLine($"EvenSum={evenSum},");
        Console.Write("EvenMin=");
        Console.WriteLine(evenMin != double.MaxValue ? $"{evenMin}," : "No,");
        Console.Write("EvenMax=");
        Console.WriteLine(evenMax != double.MinValue ? $"{evenMax}" : "No");
    }
}