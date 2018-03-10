using System;

public class MatchTickets
{
    public static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string ticketType = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());

        decimal transportCharges = 0.00M;

        if (people >= 50)
        {
            transportCharges = 0.25M * budget;
        }
        else if (people >= 25)
        {
            transportCharges = 0.40M * budget;
        }
        else if (people >= 10)
        {
            transportCharges = 0.50M * budget;
        }
        else if (people >= 5)
        {
            transportCharges = 0.60M * budget;
        }
        else if (people >= 1)
        {
            transportCharges = 0.75M * budget;
        }

        decimal moneyForTickets = budget - transportCharges;
        decimal ticketPrice = ticketType == "VIP" ? 499.99M : 249.99M;
        decimal allTicketsPrice = people * ticketPrice;
        decimal moneyDiff = Math.Abs(moneyForTickets - allTicketsPrice);
        bool enoughMoney = moneyForTickets >= allTicketsPrice;

        if (enoughMoney)
        {
            Console.WriteLine("Yes! You have {0:F2} leva left.",
                moneyDiff);
        }
        else
        {
            Console.WriteLine("Not enough money! You need {0:F2} leva.",
                moneyDiff);
        }
    }
}