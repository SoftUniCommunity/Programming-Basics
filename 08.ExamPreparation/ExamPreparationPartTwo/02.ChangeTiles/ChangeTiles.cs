using System;

public class ChangeTiles
{
    public static void Main()
    {
        var savedMoney = double.Parse(Console.ReadLine());
        var floorWidth = double.Parse(Console.ReadLine());
        var floorLength = double.Parse(Console.ReadLine());
        var tileSide = double.Parse(Console.ReadLine());
        var tileHeight = double.Parse(Console.ReadLine());
        var tilePrice = double.Parse(Console.ReadLine());
        var workerHonorary = double.Parse(Console.ReadLine());

        var floorArea = floorWidth * floorLength;
        var tileArea = tileSide * tileHeight / 2;
        var neededTiles = Math.Ceiling(floorArea / tileArea) + 5;
        var totalPrice = neededTiles * tilePrice + workerHonorary;
        var difference = Math.Abs(savedMoney - totalPrice);
        var hasEnoughMoney = savedMoney >= totalPrice;

        Console.WriteLine(hasEnoughMoney ? 
            $"{difference:F2} lv left." : 
            $"You'll need {difference:F2} lv more.");
    }
}