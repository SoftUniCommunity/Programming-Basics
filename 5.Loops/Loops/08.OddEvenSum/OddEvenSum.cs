using System;

public class OddEvenSum
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long oddSum = 0L;
        long evenSum = 0L;

        for (int i = 0; i < n; i++)
        {
            int element = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += element;
            }
            else
            {
                oddSum += element;
            }
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = " + evenSum);
        }
        else
        {
            long difference = Math.Abs(evenSum - oddSum);

            Console.WriteLine("No");
            Console.WriteLine("Diff = " + difference);
        }
    }
}