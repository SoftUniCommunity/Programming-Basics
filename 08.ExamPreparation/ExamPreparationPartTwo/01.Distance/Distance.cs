using System;

public class Distance
{
    public static void Main()
    {
        var initialSpeed = int.Parse(Console.ReadLine());
        var firstTimeMinutes = int.Parse(Console.ReadLine());
        var secondTimeMinutes = int.Parse(Console.ReadLine());
        var thirdTimeMinutes = int.Parse(Console.ReadLine());

        var minutesPerHour = 60m;
        var speedAfterIncrease = initialSpeed + 0.10m * initialSpeed;
        var speedAfterReduction = speedAfterIncrease - 0.05m * speedAfterIncrease;
        var firstDistance = initialSpeed * firstTimeMinutes / minutesPerHour;
        var secondDistance = speedAfterIncrease * secondTimeMinutes / minutesPerHour;
        var thirdDistance = speedAfterReduction * thirdTimeMinutes / minutesPerHour;

        var totalDistance = firstDistance + secondDistance + thirdDistance;

        Console.WriteLine($"{totalDistance:F2}");
    }
}