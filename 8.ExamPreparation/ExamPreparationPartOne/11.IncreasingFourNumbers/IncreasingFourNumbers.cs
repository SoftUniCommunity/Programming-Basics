﻿using System;

public class IncreasingFourNumbers
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int count = 0;

        for (int n1 = a; n1 <= b; n1++)
        {
            for (int n2 = a; n2 <= b; n2++)
            {
                for (int n3 = a; n3 <= b; n3++)
                {
                    for (int n4 = a; n4 <= b; n4++)
                    {
                        bool validSequence = a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 <= b;

                        if (validSequence)
                        {
                            Console.WriteLine($"{n1} {n2} {n3} {n4}");
                            count++;
                        }
                    }
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}