using System;

public class DateAfterFiveDays
{
    public static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(2018, month, day);
        date = date.AddDays(5);

        Console.WriteLine(date.ToString("d.MM"));
    }
}