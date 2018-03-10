using System;

public class SumSeconds
{
    public static void Main()
    {
        int firstCompetitor = int.Parse(Console.ReadLine());
        int secondCompetitor = int.Parse(Console.ReadLine());
        int thirdCompetitor = int.Parse(Console.ReadLine());

        int totalSeconds = firstCompetitor + secondCompetitor + thirdCompetitor;
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        Console.WriteLine($"{minutes}:{seconds:D2}");
    }
}