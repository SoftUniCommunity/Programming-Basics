using System;

public class SpecialNumbersOtherWay
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool temp = false;

        for (int d1 = 1; d1 <= 9; d1++)
        {
            for (int d2 = 1; d2 <= 9; d2++)
            {
                for (int d3 = 1; d3 <= 9; d3++)
                {
                    for (int d4 = 1; d4 <= 9; d4++)
                    {
                        bool isSpecial = n % d1 == 0 && n % d2 == 0 &&
                            n % d3 == 0 && n % d4 == 0;

                        if (isSpecial)
                        {
                            Console.Write(temp ? $" {d1}{d2}{d3}{d4}" :
                                $"{d1}{d2}{d3}{d4}");
                            temp = true;
                        }
                    }
                }
            }
        }

        Console.WriteLine();
    }
}