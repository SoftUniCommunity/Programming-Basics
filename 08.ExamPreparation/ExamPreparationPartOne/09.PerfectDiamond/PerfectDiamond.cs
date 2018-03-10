using System;

public class PerfectDiamond
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Top
        for (int row = 1; row <= n; row++)
        {
            Console.Write("{0}*", new string(' ', n - row));

            for (int col = 0; col < row - 1; col++)
            {
                Console.Write("-*");
            }

            Console.WriteLine();
        }

        // Bottom
        for (int row = 1; row < n; row++)
        {
            Console.Write("{0}*", new string(' ', row));

            for (int col = n - 1 - row; col >= 1; col--)
            {
                Console.Write("-*");
            }

            Console.WriteLine();
        }
    }
}