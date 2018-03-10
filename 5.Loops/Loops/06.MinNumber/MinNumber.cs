using System;

public class MinNumber
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double minNumber = double.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());

            if (currentNum < minNumber)
            {
                minNumber = currentNum;
            }
        }

        Console.WriteLine(minNumber);
    }
}