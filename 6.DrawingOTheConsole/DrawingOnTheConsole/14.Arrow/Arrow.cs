using System;

public class Arrow
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // First row
        int rowLength = 2 * n - 1;
        int hashLength = n;
        int dotsLength = (rowLength - hashLength) / 2;

        Console.WriteLine("{0}{1}{0}",
            new string('.', dotsLength),
            new string('#', hashLength));

        // Top
        for (int row = 1; row <= n - 2; row++)
        {
            Console.WriteLine("{0}#{1}#{0}",
                new string('.', dotsLength),
                new string('.', hashLength - 2));
        }

        // Middle row
        Console.WriteLine("{0}{1}{0}",
            new string('#', dotsLength + 1),
            new string('.', hashLength - 2));

        // Bottom
        for (int row = 1; row <= n - 2; row++)
        {
            int outerDots = row;
            int midDots = rowLength - 2 * outerDots - 2;

            Console.WriteLine("{0}#{1}#{0}",
                new string('.', outerDots),
                new string('.', midDots));
        }

        Console.WriteLine("{0}#{0}",
            new string('.', (rowLength - 1) / 2));
    }
}