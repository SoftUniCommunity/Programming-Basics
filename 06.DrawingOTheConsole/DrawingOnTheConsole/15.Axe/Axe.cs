using System;

public class Axe
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Top
        int width = 5 * n;
        int leftDashes = 3 * n;
        int middleDashes = 0;
        int rightDashes = width - leftDashes - 2;

        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftDashes),
                new string('-', middleDashes),
                new string('-', rightDashes));

            if (row != n)
            {
                middleDashes++;
                rightDashes--;
            }
        }

        // Middle
        int stars = leftDashes + 1;

        for (int row = 1; row <= n / 2; row++)
        {
            Console.WriteLine("{0}{1}*{2}",
                new string('*', stars),
                new string('-', middleDashes),
                new string('-', rightDashes));
        }

        // Bottom
        for (int row = 1; row <= n / 2 - 1; row++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftDashes),
                new string('-', middleDashes),
                new string('-', rightDashes));

            leftDashes--;
            middleDashes += 2;
            rightDashes--;
        }

        Console.WriteLine("{0}*{1}*{2}",
            new string('-', leftDashes),
            new string('*', middleDashes),
            new string('-', rightDashes));
    }
}