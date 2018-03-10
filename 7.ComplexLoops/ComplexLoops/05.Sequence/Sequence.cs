using System;

public class Sequence
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double num = 1;

        while (num <= n)
        {
            Console.WriteLine(num);
            num = 2 * num + 1;
        }
    }
}