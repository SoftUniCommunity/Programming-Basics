using System;

public class Harvest
{
    public static void Main()
    {
        int vineyardArea = int.Parse(Console.ReadLine());
        double grapePerSquare = double.Parse(Console.ReadLine());
        int neededLiters = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double vine = vineyardArea * grapePerSquare;
        double litersWine = 0.40 * vine / 2.5;
        double litersLeft = Math.Abs(litersWine - neededLiters);

        if (litersWine < neededLiters)
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                Math.Floor(litersLeft));
        }
        else
        {
            double litersPerPerson = litersLeft / workers;

            Console.WriteLine("Good harvest this year! Total wine: {0} liters.",
                Math.Floor(litersWine));
            Console.WriteLine("{0} liters left -> {1} liters per person.",
                Math.Ceiling(litersLeft),
                Math.Ceiling(litersPerPerson));
        }
    }
}