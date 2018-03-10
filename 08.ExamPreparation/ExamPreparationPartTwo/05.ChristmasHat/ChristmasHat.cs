using System;

public class ChristmasHat
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 4 * n + 1;
        //int height = 2 * n + 5;

        // Top
        Console.WriteLine("{0}/|\\{0}", new string('.', (width - 3) / 2));
        Console.WriteLine("{0}\\|/{0}", new string('.', (width - 3) / 2));

        // Middle
        for (int row = 0; row < 2 * n; row++)
        {
            Console.Write(new string('.', 2 * n - 1 - row));
            Console.Write("*{0}*{0}*", new string('-', row));
            Console.WriteLine(new string('.', 2 * n - 1 - row));
        }

        // Bottom
        Console.WriteLine(new string('*', width));

        for (int col = 0; col < width; col++)
        {
            char symbol = col % 2 == 0 ? '*' : '.';

            Console.Write(symbol);
        }

        Console.WriteLine();

        Console.WriteLine(new string('*', width));
    }
}