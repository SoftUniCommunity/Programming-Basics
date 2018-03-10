using System;

public class MagicCombinations
{
    public static void Main()
    {
        var magicNum = int.Parse(Console.ReadLine());

        bool temp = false;

        int d1 = 1;
        while (true)
        {
            int d2 = 1;
            while (true)
            {
                int d3 = 1;
                while (true)
                {
                    int d4 = 1;
                    while (true)
                    {
                        int d5 = 1;
                        while (true)
                        {
                            int d6 = 1;
                            while (true)
                            {
                                int product = d1 * d2 * d3 * d4 * d5 * d6;

                                if (product == magicNum)
                                {
                                    int combination = int.Parse($"{d1}{d2}{d3}{d4}{d5}{d6}");

                                    Console.Write(temp ? $" {combination}" : $"{combination}");
                                    temp = true;
                                }

                                d6++;

                                if (d6.Equals(10)) break;
                            }

                            d5++;

                            if (d5.Equals(10)) break;
                        }

                        d4++;

                        if (d4.Equals(10)) break;
                    }

                    d3++;

                    if (d3.Equals(10)) break;
                }

                d2++;

                if (d2.Equals(10)) break;
            }

            d1++;

            if (d1.Equals(10)) break;
        }

        Console.WriteLine();
    }
}