using System;

public class Startup
{
    public static void Main()
    {
        for (var r = 1; r <= 5; r++)
        {
            Console.Write("*");

            for (var c = 1; c < 5; c++)
            {
                Console.Write(" *");
            }

            Console.WriteLine();
        }
    }
}