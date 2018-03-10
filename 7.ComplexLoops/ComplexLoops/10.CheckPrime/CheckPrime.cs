using System;

public class CheckPrime
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num < 2)
        {
            Console.WriteLine("Not prime");
            return;
        }

        bool isPrime = true;
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(num);

        while (isPrime && divider <= maxDivider)
        {
            if (num % divider == 0)
            {
                isPrime = false;
            }

            divider++;
        }

        Console.WriteLine(isPrime ? "Prime" : "Not prime");
    }
}