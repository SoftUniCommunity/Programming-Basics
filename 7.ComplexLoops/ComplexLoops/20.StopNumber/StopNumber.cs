using System;

public class StopNumber
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());

        bool temp = false;

        for (int num = m; num >= n; num--)
        {
            if (num % 6 == 0)
            {
                if (num == s) break;

                Console.Write(temp ? $" {num}" : $"{num}");
                temp = true;
            }
        }

        Console.WriteLine();
    }
}