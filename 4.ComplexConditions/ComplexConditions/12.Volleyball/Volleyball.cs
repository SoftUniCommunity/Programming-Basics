using System;

public class Volleyball
{
    public static void Main()
    {
        string yearType = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());

        int sofiaWeekends = 48 - weekendsHome;
        double saturdayPlays = sofiaWeekends * 3 / 4.0;
        double playsInHolidaysSf = holidays * 2 / 3.0;
        double totalPlays = saturdayPlays + weekendsHome + playsInHolidaysSf;
        double leapPlays = totalPlays * 0.15;

        Console.WriteLine(yearType == "leap" ? Math.Floor(totalPlays + leapPlays) :
            Math.Floor(totalPlays));
    }
}