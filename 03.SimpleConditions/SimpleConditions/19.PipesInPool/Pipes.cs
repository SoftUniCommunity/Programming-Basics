using System;

public class Pipes
{
    public static void Main()
    {
        int volume = int.Parse(Console.ReadLine());
        int pipe1 = int.Parse(Console.ReadLine());
        int pipe2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double firstPipeLiters = hours * pipe1;
        double secondPipeLiters = hours * pipe2;
        double water = firstPipeLiters + secondPipeLiters;

        if (water <= volume)
        {
            double fullPercentage = Math.Truncate(water * 100 / volume);
            double pipe1Percentage = Math.Truncate(firstPipeLiters * 100 / water);
            double pipe2Percentage = Math.Truncate(secondPipeLiters * 100 / water);

            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                fullPercentage,
                pipe1Percentage,
                pipe2Percentage);
        }
        else
        {
            double overflow = water - volume;

            Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                hours,
                overflow);
        }
    }
}