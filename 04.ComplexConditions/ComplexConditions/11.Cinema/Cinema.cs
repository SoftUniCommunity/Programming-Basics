using System;

public class Cinema
{
    public static void Main()
    {
        string type = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double ticketPrice = -1;

        switch (type)
        {
            case "premiere":
                ticketPrice = 12;
                break;
            case "normal":
                ticketPrice = 7.50;
                break;
            case "discount":
                ticketPrice = 5.00;
                break;
        }

        int seats = rows * columns;
        double income = seats * ticketPrice;

        Console.WriteLine($"{income:F2}");
    }
}