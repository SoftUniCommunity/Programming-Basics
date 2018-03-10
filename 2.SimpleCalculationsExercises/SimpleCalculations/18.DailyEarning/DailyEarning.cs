using System;

public class DailyEarning
{
    public static void Main()
    {
        int workingDays = int.Parse(Console.ReadLine());
        double dollarsPerDay = double.Parse(Console.ReadLine());
        double exchangeRate = double.Parse(Console.ReadLine());

        double monthSalary = workingDays * dollarsPerDay;
        double yearSalaryInDollars = 12 * monthSalary + 2.5 * monthSalary;
        double tax = 0.25 * yearSalaryInDollars;
        double yearSalaryAfterTaxInDollars = yearSalaryInDollars - tax;
        double yearSalaryInLevs = yearSalaryAfterTaxInDollars * exchangeRate;
        double dailyEarning = yearSalaryInLevs / 365;

        Console.WriteLine($"{dailyEarning:F2}");
    }
}