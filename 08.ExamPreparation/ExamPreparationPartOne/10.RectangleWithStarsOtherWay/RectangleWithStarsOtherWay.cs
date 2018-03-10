using System;

public class RectangleWithStarsOtherWay
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // First row
        Console.WriteLine(new string('%', 2 * n));

        // Middle rows
        int numRows = n % 2 == 0 ? n - 1 : n;

        for (int row = 0; row < numRows; row++)
        {
            Console.Write("%");

            if (row == numRows / 2)
            {
                Console.Write(new string(' ', n - 2));
                Console.Write("**");
                Console.Write(new string(' ', n - 2));
            }
            else
            {
                Console.Write(new string(' ', 2 * n - 2));
            }

            Console.WriteLine("%");
        }

        // Last row
        Console.WriteLine(new string('%', 2 * n));
    }
}