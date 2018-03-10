using System;
using System.Globalization;

public class ThousandDaysAfterBirth
{
    public static void Main()
    {
        string format = "dd-MM-yyyy";
        DateTime date = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

        date = date.AddDays(1000);

        Console.WriteLine(date.ToString(format));
    }
}