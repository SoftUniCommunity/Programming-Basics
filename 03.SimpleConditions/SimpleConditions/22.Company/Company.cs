using System;

public class Company
{
    public static void Main()
    {
        int projectHours = int.Parse(Console.ReadLine());
        int availableDays = int.Parse(Console.ReadLine());
        int overtimeWorkers = int.Parse(Console.ReadLine());

        double workDays = availableDays * 0.90;
        double workHours = workDays * 8;
        int overtimeHours = overtimeWorkers * availableDays * 2;
        double totalHours = Math.Floor(workHours + overtimeHours);
        double difference = Math.Abs(totalHours - projectHours);
        bool hasEnoughTime = totalHours >= projectHours;

        Console.WriteLine(hasEnoughTime ? "Yes!{0} hours left." :
            "Not enough time!{0} hours needed.", difference);
    }
}