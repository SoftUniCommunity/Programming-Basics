using System;

public class PowersOfTwo
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long num = 1;

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(num);
            num *= 2;
        }
    }
}