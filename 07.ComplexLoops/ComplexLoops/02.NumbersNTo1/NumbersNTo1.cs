﻿using System;

public class NumbersNTo1
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}