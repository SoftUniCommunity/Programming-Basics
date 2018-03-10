using System;

public class Flowers
{
    public static void Main()
    {
        int chrysanthemums = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int tulips = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        string dayType = Console.ReadLine();

        decimal roseAutumnWinterPrice = 4.50m;
        decimal roseSpringSummerPrice = 4.10m;
        decimal tulipAutumnWinterPrice = 4.15m;
        decimal tulipSpringSummerPrice = 2.50m;
        decimal chrysanthemumAutumnWinterPrice = 3.75m;
        decimal chrysanthemumSpringSummerPrice = 2m;
        decimal arrangePrice = 2m;
        int priceIncreasePercentage = 15;
        int tulipPriceDecreasePercentage = 5;
        int rosePriceDecreasePercentage = 10;
        int totalPriceDecreasePercentage = 20;
        int tulipPriceDecreaseTreshhold = 7;
        int rosePriceDecreaseTreshhold = 10;
        int totalPriceDecreaseTreshhold = 20;
        decimal rosesPrice;
        decimal tulipsPrice;
        decimal chrysanthemumsPrice;

        if (season == "Winter" || season == "Autumn")
        {
            rosesPrice = roses * roseAutumnWinterPrice;
            tulipsPrice = tulips * tulipAutumnWinterPrice;
            chrysanthemumsPrice = chrysanthemums * chrysanthemumAutumnWinterPrice;
        }
        else
        {
            rosesPrice = roses * roseSpringSummerPrice;
            tulipsPrice = tulips * tulipSpringSummerPrice;
            chrysanthemumsPrice = chrysanthemums * chrysanthemumSpringSummerPrice;
        }

        decimal bouquetPrice = rosesPrice + tulipsPrice + chrysanthemumsPrice;

        if (dayType == "Y")
        {
            bouquetPrice += priceIncreasePercentage * bouquetPrice / 100;
        }

        if (tulips > tulipPriceDecreaseTreshhold && season == "Spring")
        {
            bouquetPrice -= tulipPriceDecreasePercentage * bouquetPrice / 100;
        }

        if (roses >= rosePriceDecreaseTreshhold && season == "Winter")
        {
            bouquetPrice -= rosePriceDecreasePercentage * bouquetPrice / 100;
        }

        int allFlowers = chrysanthemums + roses + tulips;

        if (allFlowers > totalPriceDecreaseTreshhold)
        {
            bouquetPrice -= totalPriceDecreasePercentage * bouquetPrice / 100;
        }

        bouquetPrice += arrangePrice;

        Console.WriteLine($"{bouquetPrice:F2}");
    }
}