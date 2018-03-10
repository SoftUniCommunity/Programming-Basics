using System;

public class CurrencyConverter
{
    public static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        string inn = Console.ReadLine();
        string outt = Console.ReadLine();

        const decimal usd = 1.79549m;
        const decimal eur = 1.95583m;
        const decimal gbp = 2.53405m;
        const decimal bgn = 1.0m;

        switch (inn)
        {
            case "USD":
                cash = cash * usd;
                break;
            case "EUR":
                cash = cash * eur;
                break;
            case "GBP":
                cash = cash * gbp;
                break;
        }

        switch (outt)
        {
            case "USD":
                cash = cash / usd;
                break;
            case "EUR":
                cash = cash / eur;
                break;
            case "GBP":
                cash = cash / gbp;
                break;
        }

        Console.WriteLine($"{Math.Round(cash, 2)} {outt}");
    }
}