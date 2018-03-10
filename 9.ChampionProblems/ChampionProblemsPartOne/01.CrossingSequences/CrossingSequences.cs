using System;
using System.Collections.Generic;

public class Demo
{
    public static void Main()
    {
        int tribonacciFirst = int.Parse(Console.ReadLine());
        int tribonacciSecond = int.Parse(Console.ReadLine());
        int tribonacciThird = int.Parse(Console.ReadLine());
        int spiralCurrent = int.Parse(Console.ReadLine());
        int spiralIncrement = int.Parse(Console.ReadLine());

        if (spiralCurrent == tribonacciFirst || spiralCurrent == tribonacciSecond || spiralCurrent == tribonacciThird)
        {
            Console.WriteLine(spiralCurrent);
            return;
        }

        int tribonacciCurrent = 0;
        int spiralStepMul = 1;
        int turnsCount = 1;

        while (tribonacciCurrent <= 1000000 && spiralCurrent <= 1000000)
        {
            if (tribonacciCurrent == spiralCurrent)
            {
                Console.WriteLine(tribonacciCurrent);
                return;
            }

            if (tribonacciCurrent > spiralCurrent)
            {
                spiralCurrent += spiralStepMul * spiralIncrement;

                if (turnsCount % 2 == 0)
                {
                    spiralStepMul++;
                }

                turnsCount++;
            }
            else
            {
                tribonacciCurrent = tribonacciFirst + tribonacciSecond + tribonacciThird;
                tribonacciFirst = tribonacciSecond;
                tribonacciSecond = tribonacciThird;
                tribonacciThird = tribonacciCurrent;
            }
        }

        Console.WriteLine("No");
    }
}