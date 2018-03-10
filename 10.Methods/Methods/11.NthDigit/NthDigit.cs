using System;

public class NthDigit
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var index = int.Parse(Console.ReadLine());

        var nthDigit = FindDigit(number, index);

        Console.WriteLine(nthDigit);
    }

    public static int FindDigit(int number, int index)
    {
        var currentIndex = 1;

        while (number > 0)
        {
            var currentDigit = number % 10;

            if (currentIndex == index)
            {
                return currentDigit;
            }

            currentIndex++;
            number /= 10;
        }

        return 0;
    }
}