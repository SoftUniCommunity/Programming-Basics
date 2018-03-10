using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int previousSum = 0;
        int currentSum = 0;
        int maxDiff = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            previousSum = currentSum;
            currentSum = 0;
            currentSum += int.Parse(Console.ReadLine());
            currentSum += int.Parse(Console.ReadLine());

            if (i != 0)
            {
                int diff = Math.Abs(previousSum - currentSum);

                if (diff != 0 && diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }
        }

        if (previousSum == currentSum || n == 1)
        {
            Console.WriteLine($"Yes, value={currentSum}");
        }
        else
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
    }
}