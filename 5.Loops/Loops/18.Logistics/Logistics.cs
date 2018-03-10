using System;

public class Logistics
{
    public static void Main()
    {
        int countOfLoads = int.Parse(Console.ReadLine());

        double sumOfTons = 0;
        int microbusTons = 0;
        int truckTons = 0;
        int trainTons = 0;

        for (int i = 0; i < countOfLoads; i++)
        {
            int currentLoad = int.Parse(Console.ReadLine());
            sumOfTons += currentLoad;

            if (currentLoad > 11)
            {
                trainTons += currentLoad;
            }
            else if (currentLoad > 3)
            {
                truckTons += currentLoad;
            }
            else
            {
                microbusTons += currentLoad;
            }
        }

        double averagePrice = (200 * microbusTons + 175 * truckTons + 120 * trainTons) / sumOfTons;
        double microbusPercentage = microbusTons * 100 / sumOfTons;
        double truckPercentage = truckTons * 100 / sumOfTons;
        double trainPercentage = trainTons * 100 / sumOfTons;

        Console.WriteLine($"{averagePrice:F2}");
        Console.WriteLine($"{microbusPercentage:F2}%");
        Console.WriteLine($"{truckPercentage:F2}%");
        Console.WriteLine($"{trainPercentage:F2}%");
    }
}