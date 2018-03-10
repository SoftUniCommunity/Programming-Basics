using System;

public class BonusScore
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        double bonusScore = 0.0;

        if (num > 1000)
        {
            bonusScore += 0.10 * num;
        }
        else if (num > 100)
        {
            bonusScore += 0.20 * num;
        }
        else //score <= 100
        {
            bonusScore += 5;
        }

        if (num % 2 == 0)
        {
            bonusScore += 1;
        }

        if (num % 10 == 5)
        {
            bonusScore += 2;
        }

        double totalScore = num + bonusScore;

        Console.WriteLine(bonusScore);
        Console.WriteLine(totalScore);
    }
}