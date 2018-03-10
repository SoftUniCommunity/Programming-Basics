using System;

public class TransportPrice
{
    public static void Main()
    {
        int distance = int.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        double price = 0;
        double taxiRate = dayOrNight == "day" ? 0.79 : 0.90;

        if (distance >= 100)
        {
            price = distance * 0.06;
        }
        else if (distance >= 20)
        {
            price = distance * 0.09;
        }
        else
        {
            price = 0.70 + distance * taxiRate;
        }

        Console.WriteLine(price);
    }
}