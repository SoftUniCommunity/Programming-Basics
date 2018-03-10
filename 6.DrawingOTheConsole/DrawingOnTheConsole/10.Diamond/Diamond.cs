using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            if (n == 2)
            {
                Console.WriteLine("**");
            }
            else
            {
                for (int row = 0; row < n / 2; row++)
                {
                    Console.WriteLine(new string('-', (n - 1) / 2 - row) + "*" + new string('-', 2 * row) + "*" + new string('-', (n - 1) / 2 - row));
                }

                for (int row = 0; row < n / 2 - 1; row++)
                {
                    Console.WriteLine(new string('-', row + 1) + "*" + new string('-', (n - 4) - 2 * row) + "*" + new string('-', row + 1));
                }
            }
        }
        else // odd n
        {
            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                Console.WriteLine(new string('-', (n - 1) / 2) + "*"
                    + new string('-', (n - 1) / 2));

                for (int row = 1; row <= (n - 1) / 2; row++)
                {
                    Console.WriteLine(new string('-', (n - 1) / 2 - row) + "*"
                        + new string('-', 2 * row - 1) + "*"
                        + new string('-', (n - 1) / 2 - row));
                }

                for (int row = 0; row < (n - 1) / 2 - 1; row++)
                {
                    Console.WriteLine(new string('-', row + 1) + "*"
                        + new string('-', n - 4 - 2 * row) + "*"
                        + new string('-', row + 1));
                }

                Console.WriteLine(new string('-', (n - 1) / 2) + "*"
                    + new string('-', (n - 1) / 2));
            }
        }
    }
}