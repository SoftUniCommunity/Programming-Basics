using System;

public class LatinLetters
{
    public static void Main()
    {
        Console.Write("Latin alphabet:");

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            Console.Write(" " + letter);
        }

        Console.WriteLine();
    }
}