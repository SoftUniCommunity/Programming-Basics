using System;
using System.Collections.Generic;

public class CrossingSequences
{
    public static void Main()
    {
        long tribFirst = long.Parse(Console.ReadLine());
        long tribSecond = long.Parse(Console.ReadLine());
        long tribThird = long.Parse(Console.ReadLine());
        long spiralCurrent = long.Parse(Console.ReadLine());
        long increment = long.Parse(Console.ReadLine());

        List<long> tribSequence = new List<long> { tribFirst, tribSecond, tribThird };
        List<long> spiralSequence = new List<long> { spiralCurrent };

        while (tribThird <= 1000000)
        {
            long temp = tribThird;
            tribThird = tribFirst + tribSecond + tribThird;
            tribFirst = tribSecond;
            tribSecond = temp;
            tribSequence.Add(tribThird);
        }

        int spiralStepMul = 1;
        int turnsCount = 1;

        while (spiralCurrent <= 1000000)
        {
            spiralCurrent += spiralStepMul * increment;

            if (turnsCount % 2 == 0)
            {
                spiralStepMul++;
            }

            spiralSequence.Add(spiralCurrent);
            turnsCount++;
        }

        foreach (var number in tribSequence)
        {
            if (spiralSequence.Contains(number))
            {
                Console.WriteLine(number);
                return;
            }
        }

        Console.WriteLine("No");
    }
}
