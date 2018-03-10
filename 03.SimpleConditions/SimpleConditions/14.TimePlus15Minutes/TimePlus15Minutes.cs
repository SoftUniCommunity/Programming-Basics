﻿using System;

public class TimePlus15Minutes
{
    public static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 15;

        if (minutes > 59)
        {
            hours++;
            minutes -= 60;
        }

        if (hours > 23)
        {
            hours -= 24;
        }

        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}