using System;

public class CelsiusToFahrenheit
{
    static void Main()
    {
        double degreesC = double.Parse(Console.ReadLine());

        double degreesF = degreesC * 9 / 5 + 32;

        Console.WriteLine(degreesF);
    }
}