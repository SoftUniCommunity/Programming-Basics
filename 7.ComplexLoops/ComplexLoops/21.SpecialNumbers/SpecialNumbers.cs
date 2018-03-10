using System;
using System.Collections.Generic;

public class SpecialNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool temp = false;

        for (int num = 1111; num <= 9999; num++)
        {
            List<int> digitsOfNum = GetDigits(num);

            int d1 = digitsOfNum[0];
            int d2 = digitsOfNum[1];
            int d3 = digitsOfNum[2];
            int d4 = digitsOfNum[3];

            bool hasZeroDigit = d1 == 0 || d2 == 0 || d3 == 0 || d4 == 0;

            if (!hasZeroDigit)
            {
                bool isSpecial = n % d1 == 0 && n % d2 == 0 && n % d3 == 0 && n % d4 == 0;

                if (isSpecial)
                {
                    Console.Write(temp ? $" {num}" : $"{num}");
                    temp = true;
                }
            }
        }

        Console.WriteLine();
    }

    public static List<int> GetDigits(int num)
    {
        List<int> digits = new List<int>();

        while (num > 0)
        {
            int lastDigit = num % 10;
            digits.Insert(0, lastDigit);
            num /= 10;
        }

        return digits;
    }
}