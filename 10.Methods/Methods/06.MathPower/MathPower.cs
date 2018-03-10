using System;

public class MathPower
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        double result = CalculatePower(number, power);

        Console.WriteLine(result);
    }

    public static double CalculatePower(double number, double power)
    {
        return Math.Pow(number, power);
    }

    public static double GetPower(double number, double power)
    {
        double result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }
}