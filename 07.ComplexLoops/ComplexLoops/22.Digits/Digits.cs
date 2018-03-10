using System;

public class Digits
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 100;
        int secondDigit = number / 10 % 10;
        int thirdDigit = number % 10;

        int n = firstDigit + secondDigit;
        int m = firstDigit + thirdDigit;

        for (int row = 0; row < n; row++)
        {
            bool temp = false;

            for (int col = 0; col < m; col++)
            {
                if (number % 5 == 0)
                {
                    number -= firstDigit;
                }
                else if (number % 3 == 0)
                {
                    number -= secondDigit;
                }
                else
                {
                    number += thirdDigit;
                }

                Console.Write(temp ? $" {number}" : $"{number}");
                temp = true;
            }

            Console.WriteLine();
        }
    }
}