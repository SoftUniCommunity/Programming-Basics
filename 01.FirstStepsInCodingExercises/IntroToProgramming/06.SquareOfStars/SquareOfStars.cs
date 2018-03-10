using System;

public class SquareOfStars
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //First row
        Console.WriteLine(new string('*', n));

        //Body
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write('*');
            Console.Write(new string(' ', n - 2));
            Console.WriteLine('*');
        }

        //Last row
        Console.WriteLine(new string('*', n));
    }
}