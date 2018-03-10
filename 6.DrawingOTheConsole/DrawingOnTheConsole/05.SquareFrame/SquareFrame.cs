using System;

public class SquareFrame
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Print the top row: + - - - - +
        Console.Write("+ ");

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("- ");
        }

        Console.WriteLine("+");

        // Print middle rows: | - - - - |
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("| ");

            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("- ");
            }

            Console.WriteLine("|");
        }

        // Print the bottom row: + - - - - +
        Console.Write("+ ");

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("- ");
        }

        Console.WriteLine("+");
    }
}