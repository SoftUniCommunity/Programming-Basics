using System;

public class IncreasingElements
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int countLongest = 0;
        int countCurrentLongest = 0;
        int previousNum = 0;

        for (int i = 0; i < n; i++)
        {
            int currentNum = int.Parse(Console.ReadLine());

            countCurrentLongest = currentNum > previousNum ? ++countCurrentLongest : 1;

            if (countCurrentLongest > countLongest)
            {
                countLongest = countCurrentLongest;
            }

            previousNum = currentNum;
        }

        Console.WriteLine(countLongest);
    }
}