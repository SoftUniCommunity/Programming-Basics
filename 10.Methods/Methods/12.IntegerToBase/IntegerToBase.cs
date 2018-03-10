using System;

public class IntegerToBase
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var toBase = int.Parse(Console.ReadLine());

        IntToBase(number, toBase);
    }

    public static void IntToBase(int number, int toBase)
    {
        var result = string.Empty;

        while (number > 0)
        {
            var remainder = number % toBase;
            result = remainder + result;
            number /= toBase;
        }

        Console.WriteLine(result);
    }
}