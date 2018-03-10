using System;

public class Sunglasses
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintRow(n);

        for (int row = 1; row < n - 1; row++)
        {
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.Write("*");
            Console.Write(row != (n - 1) / 2 ? $"{new string(' ', n)}" :
                $"{new string('|', n)}");
            Console.Write("*");
            Console.Write(new string('/', 2 * n - 2));
            Console.WriteLine("*");
        }

        PrintRow(n);
    }

    public static void PrintRow(int n)
    {
        Console.Write(new string('*', 2 * n));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', 2 * n));
    }
}