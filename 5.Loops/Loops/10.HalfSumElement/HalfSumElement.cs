using System;

public class HalfSumElement
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maxNum = int.MinValue;
        long allNumsSum = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            allNumsSum += currentNum;

            if (currentNum > maxNum)
            {
                maxNum = currentNum;
            }
        }

        if (allNumsSum.Equals(2 * maxNum))
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {maxNum}");
        }
        else
        {
            long difference = Math.Abs(2 * maxNum - allNumsSum);

            Console.WriteLine("No");
            Console.WriteLine($"Diff = {difference}");
        }
    }
}