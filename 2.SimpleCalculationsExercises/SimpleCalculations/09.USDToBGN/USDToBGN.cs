using System;

public class USDToBGN
{
    static void Main()
    {
        decimal usd = decimal.Parse(Console.ReadLine());
        const decimal factor = 1.79549m;

        decimal bgn = Math.Round(usd * factor, 2);

        Console.WriteLine($"{bgn} BGN");
    }
}