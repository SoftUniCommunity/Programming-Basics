using System;

public class RhombusOfStars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Printing the upper half
        for (int row = 1; row <= n; row++)
        {
            for (int space = 1; space <= n - row; space++)
            {
                Console.Write(" ");
            }

            Console.Write("*");

            for (int star = 1; star < row; star++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }

        // Print the bottom
        for (int row = 1; row < n; row++)
        {
            for (int i = 1; i <= row; i++)
            {
                Console.Write(" ");
            }

            Console.Write("*");

            for (int star = 1; star < n - row; star++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }
    }
}