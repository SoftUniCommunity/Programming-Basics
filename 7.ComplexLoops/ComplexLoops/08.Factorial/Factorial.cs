using System;
using System.Numerics;

public class Factorial
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;

        do
        {
            factorial *= n;
            n--;
        } while (n > 1);

        Console.WriteLine(factorial);
    }
}