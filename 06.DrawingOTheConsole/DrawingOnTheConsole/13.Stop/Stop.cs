using System;

public class Stop
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // First row
        Console.WriteLine("{0}{1}{0}",
            new string('.', n + 1),
            new string('_', 2 * n + 1));

        // Top
        int dots = n;
        int underscores = 2 * n - 1;

        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine("{0}//{1}\\\\{0}",
                new string('.', dots),
                new string('_', underscores));

            dots--;
            underscores += 2;
        }

        // Middle row
        Console.WriteLine("//{0}STOP!{0}\\\\",
            new string('_', 2 * n - 3));

        // Bottom
        dots = 0;
        underscores = 4 * n - 1;

        for (int row = 1; row <= n; row++)
        {
            Console.WriteLine("{0}\\\\{1}//{0}",
                new string('.', dots),
                new string('_', underscores));

            dots++;
            underscores -= 2;
        }
    }
}