using System;

public class PassionDays
{
    public static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());

        string command = string.Empty;
        int purchases = 0;

        while (true)
        {
            command = Console.ReadLine();

            if (command == "mall.Enter") { break; }
        }

        while (true)
        {
            command = Console.ReadLine();

            if (command == "mall.Exit") { break; }

            foreach (char action in command)
            {
                if (action == '*')
                {
                    budget += 10;
                    continue;
                }

                decimal productPrice;

                if (char.IsLetter(action) && char.IsUpper(action))
                {
                    productPrice = (decimal)action / 2;
                }
                else if (char.IsLetter(action) && char.IsLower(action))
                {
                    productPrice = 0.3m * action;
                }
                else if (action == '%')
                {
                    productPrice = budget / 2;
                }
                else
                {
                    productPrice = action;
                }

                if (productPrice > budget || budget == 0) { continue; }

                budget -= productPrice;
                purchases++;
            }
        }

        Console.Write(purchases != 0 ? $"{purchases} " : "No ");
        Console.WriteLine($"purchases. Money left: {budget:F2} lv.");
    }
}