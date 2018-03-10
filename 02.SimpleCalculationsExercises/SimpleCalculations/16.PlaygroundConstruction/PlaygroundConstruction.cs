using System;

public class PlaygroundConstruction
{
    public static void Main()
    {
        double sideOfPlayground = double.Parse(Console.ReadLine());
        double tileWidth = double.Parse(Console.ReadLine());
        double tileLength = double.Parse(Console.ReadLine());
        double benchWidth = double.Parse(Console.ReadLine());
        double benchLength = double.Parse(Console.ReadLine());

        double playgroundArea = sideOfPlayground * sideOfPlayground;
        double benchArea = benchLength * benchWidth;
        double playgroundCovered = playgroundArea - benchArea;
        double tileArea = tileLength * tileWidth;
        double allTiles = playgroundCovered / tileArea;
        double buildTime = allTiles * 0.2;

        Console.WriteLine(allTiles);
        Console.WriteLine(buildTime);
    }
}