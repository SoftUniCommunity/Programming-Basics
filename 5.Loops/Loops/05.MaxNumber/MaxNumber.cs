using System;

public class MaxNumber
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double maxNumber = double.MinValue;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());

            if (currentNum > maxNumber)
            {
                maxNumber = currentNum;
            }
        }

        Console.WriteLine(maxNumber);
    }
}