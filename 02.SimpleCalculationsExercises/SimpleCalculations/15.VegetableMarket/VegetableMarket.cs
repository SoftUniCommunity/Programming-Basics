using System;

public class VegetableMarket
{
    public static void Main()
    {
        double vegPrice = double.Parse(Console.ReadLine());
        double frPrice = double.Parse(Console.ReadLine());
        int vegWeight = int.Parse(Console.ReadLine());
        int frWeight = int.Parse(Console.ReadLine());

        double vegProfit = vegWeight * vegPrice;
        double frProfit = frWeight * frPrice;
        double totalProfit = (vegProfit + frProfit) / 1.94;

        Console.WriteLine(totalProfit);
    }
}