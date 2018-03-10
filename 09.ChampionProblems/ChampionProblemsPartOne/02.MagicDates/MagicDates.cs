using System;

public class MagicDates
{
    public static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int magicNum = int.Parse(Console.ReadLine());

        DateTime currentDate = new DateTime(startYear, 1, 1);
        bool printed = false;

        while (currentDate.Year <= endYear)
        {
            int dateWeight = FindDateWeight(currentDate);

            if (dateWeight == magicNum)
            {
                Console.WriteLine(currentDate.ToString("dd-MM-yyyy"));
                printed = true;
            }

            currentDate = currentDate.AddDays(1);
        }

        if (!printed)
        {
            Console.WriteLine("No");
        }
    }

    public static int FindDateWeight(DateTime date)
    {
        int d1 = date.Day / 10;
        int d2 = date.Day % 10;
        int d3 = date.Month / 10;
        int d4 = date.Month % 10;
        int d5 = date.Year / 1000;
        int d6 = date.Year / 100 % 10;
        int d7 = date.Year / 10 % 10;
        int d8 = date.Year % 10;

        int dateWeight =
            d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) +
            d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
            d3 * (d4 + d5 + d6 + d7 + d8) +
            d4 * (d5 + d6 + d7 + d8) +
            d5 * (d6 + d7 + d8) +
            d6 * (d7 + d8) +
            d7 * d8;

        return dateWeight;
    }

    public static int GetDateWeight(DateTime date)
    {
        int dateWeight = 0;
        string dateStr = $"{date.Day:D2}" + $"{date.Month:D2}" + $"{date.Year}";

        for (int i = 0; i < dateStr.Length; i++)
        {
            int a = int.Parse(dateStr[i].ToString());

            for (int j = i; j < dateStr.Length; j++)
            {
                int b = int.Parse(dateStr[j].ToString());

                if (i != j)
                {
                    dateWeight += a * b;
                }
            }
        }

        return dateWeight;
    }
}