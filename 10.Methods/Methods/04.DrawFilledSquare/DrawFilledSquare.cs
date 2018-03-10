using System;

public class DrawFilledSquare
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintFigure(n);
    }

    public static void PrintFigure(int n)
    {
        PrintHeaderFooter(n);

        for (int i = 0; i < n - 2; i++)
        {
            PrintMiddleRow(n);
        }

        PrintHeaderFooter(n);
    }

    public static void PrintMiddleRow(int n)
    {

        Console.Write("-");

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write("\\/");
        }

        Console.WriteLine("-");
    }

    public static void PrintHeaderFooter(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
}