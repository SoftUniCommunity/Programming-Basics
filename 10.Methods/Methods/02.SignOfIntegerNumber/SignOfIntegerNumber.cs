using System;

public class SignOfIntegerNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintSign(number);
    }

    public static void PrintSign(int number)
    {
        string kind = string.Empty;

        if (number > 0)
        {
            kind = "positive";
        }
        else if (number < 0)
        {
            kind = "negative";
        }
        else if (number.Equals(0))
        {
            kind = "zero";
        }

        Console.WriteLine("The number {0} is {1}.", number, kind);
    }
}