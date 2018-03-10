using System;

public class RectangleWithStars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // First row
        Console.WriteLine(new string('%', 2 * n));

        // Middle
        int numRows = n % 2 == 0 ? n - 1 : n;

        for (int row = 0; row < numRows; row++)
        {
            Console.Write("%");

            for (int col = 1; col < 2 * n - 1; col++)
            {
                if (row == numRows / 2 && (col == n - 1 || col == n))
                {
                    Console.Write("*");
                    continue;
                }

                Console.Write(" ");
            }

            Console.WriteLine("%");
        }

        // Last row
        Console.WriteLine(new string('%', 2 * n));
    }
}
