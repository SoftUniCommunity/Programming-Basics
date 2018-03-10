using System;

public class Trip
{
    public static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destinationResult = string.Empty;
        string holidayInformation = string.Empty;
        decimal moneySpent = 0.00M;

        if (budget > 1000)
        {
            destinationResult = "Somewhere in Europe";
            moneySpent = 0.90M * budget;
            holidayInformation = string.Format("Hotel - {0:F2}",
                moneySpent);
        }
        else if (budget > 100)
        {
            destinationResult = "Somewhere in Balkans";

            if (season == "summer")
            {
                moneySpent = 0.40M * budget;
                holidayInformation = string.Format("Camp - {0:F2}",
                    moneySpent);
            }
            else
            {
                moneySpent = 0.80M * budget;
                holidayInformation = string.Format("Hotel - {0:F2}", moneySpent);

            }
        }
        else
        {
            destinationResult = "Somewhere in Bulgaria";

            if (season == "summer")
            {
                moneySpent = 0.30M * budget;
                holidayInformation = string.Format("Camp - {0:F2}",
                    moneySpent);
            }
            else
            {
                moneySpent = 0.70M * budget;
                holidayInformation = string.Format("Hotel - {0:F2}",
                    moneySpent);
            }
        }

        Console.WriteLine(destinationResult);
        Console.WriteLine(holidayInformation);
    }
}