using System;

public class Butterfly
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int halfRowSize = n - 2;

        for (int row = 1; row <= n - 2; row++)
        {
            if (row % 2 != 0)
            {
                Console.WriteLine("{0}\\ /{0}",
                    new string('*', halfRowSize));
            }
            else
            {
                Console.WriteLine("{0}\\ /{0}",
                    new string('-', halfRowSize));
            }
        }

        Console.WriteLine("{0}@{0}", new string(' ', halfRowSize + 1));

        for (int row = 1; row <= n - 2; row++)
        {
            if (row % 2 != 0)
            {
                Console.WriteLine("{0}/ \\{0}",
                    new string('*', halfRowSize));
            }
            else
            {
                Console.WriteLine("{0}/ \\{0}",
                    new string('-', halfRowSize));
            }
        }
    }
}