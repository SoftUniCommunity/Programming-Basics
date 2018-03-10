using System;

public class LeftAndRightSum
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long leftSum = 0L;
        long rightSum = 0L;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            leftSum += currentNum;
        }

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());
            rightSum += currentNum;
        }

        long difference = Math.Abs(leftSum - rightSum);
        string output = leftSum == rightSum ? $"Yes, sum = {leftSum}" :
            $"No, diff = {difference}";

        Console.WriteLine(output);
    }
}