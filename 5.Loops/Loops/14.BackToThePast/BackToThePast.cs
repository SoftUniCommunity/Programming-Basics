using System;

public class BackToThePast
{
    public static void Main()
    {
        double heritage = double.Parse(Console.ReadLine());
        int yearToLive = int.Parse(Console.ReadLine());

        int age = 18;

        for (int year = 1800; year <= yearToLive; year++)
        {
            if (year % 2 == 0)
            {
                heritage -= 12000;
            }
            else
            {
                heritage -= 12000 + 50 * age;
            }

            age++;
        }

        bool hasEnoughMoney = heritage >= 0;

        Console.WriteLine(hasEnoughMoney ?
            $"Yes! He will live a carefree life and will have {heritage:F2} dollars left." :
            $"He will need {Math.Abs(heritage):F2} dollars to survive.");
    }
}