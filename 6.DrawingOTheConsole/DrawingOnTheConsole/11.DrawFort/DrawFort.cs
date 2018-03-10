using System;

public class DrawFort
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Roof
        int colSize = n / 2;
        int midSize = 2 * n - 2 * colSize - 4;

        Console.WriteLine("/{0}\\{1}/{0}\\",
            new string('^', colSize),
            new string('_', midSize));

        // Body
        for (int i = 1; i <= n - 3; i++)
        {
            Console.WriteLine("|{0}|",
                new string(' ', 2 * n - 2));
        }

        //Bottom
        Console.WriteLine("|{0}{1}{0}|",
            new string(' ', colSize + 1),
            new string('_', midSize));
        Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', colSize),
            new string(' ', midSize));
    }
}