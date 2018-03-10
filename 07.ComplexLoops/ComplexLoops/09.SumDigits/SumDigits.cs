using System;

public class SumDigits
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long sumOfDigits = 0;

        do
        {
            int lastDigit = n % 10;
            sumOfDigits += lastDigit;
            n /= 10;
        } while (n > 0);

        Console.WriteLine("Sum of digits: {0}", sumOfDigits);
    }
}