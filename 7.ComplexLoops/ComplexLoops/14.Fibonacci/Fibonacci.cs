using System;

public class Fibonacci
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int fib0 = 1;
        int fib1 = 1;

        for (int i = 0; i < n - 1; i++)
        {
            int fibNext = fib0 + fib1;
            fib0 = fib1;
            fib1 = fibNext;
        }

        Console.WriteLine(fib1);
    }
}