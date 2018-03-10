using System;

public class SumNumbers
{
    public static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Enter {n} numbers:");

        long sum = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            sum += currentNum;
        }

        Console.WriteLine($"Sum = {sum}");
    }
}