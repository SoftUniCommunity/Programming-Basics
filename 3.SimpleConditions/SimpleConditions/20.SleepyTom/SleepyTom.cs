using System;

public class SleepyTom
{
    public static void Main()
    {
        int holidays = int.Parse(Console.ReadLine());

        const int maxPlayingTimePerYear = 30000;
        int workingDays = 365 - holidays;
        int totalPlayMinutes = workingDays * 63 + holidays * 127;
        int difference = Math.Abs(maxPlayingTimePerYear - totalPlayMinutes);
        int hours = difference / 60;
        int minutes = difference % 60;

        if (totalPlayMinutes > maxPlayingTimePerYear)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
        }
    }
}