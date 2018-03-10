using System;

public class House
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int stars = n % 2 == 0 ? 2 : 1;
        int roofLength = (int)Math.Ceiling(n / 2f);

        for (int row = 0; row < roofLength; row++)
        {
            int padding = (n - stars) / 2;
            string line = new string('-', padding) +
                new string('*', stars) +
                new string('-', padding);
            stars += 2;

            Console.WriteLine(line);
        }

        for (int row = 0; row < n / 2; row++)
        {
            string line = "|" + new string('*', n - 2) + "|";

            Console.WriteLine(line);
        }
    }
}