﻿namespace PassionDays
{
    using System;

    class PassionDays
    {
        static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());

            int countPurchases = 0;
            string command = string.Empty;

            // skip any commands before "mall.Enter"
            do
            {
                command = Console.ReadLine();
            } while (command != "mall.Enter");

            // process commands until "mall.Exit"
            while (true)
            {
                command = Console.ReadLine();

                if (command == "mall.Exit") break;

                foreach (char action in command)
                {
                    if (action == '*') { money += 10; continue; }

                    decimal price = 0;
                    if (char.IsLetter(action) && char.IsUpper(action)) { price = 0.5m * (int)action; }
                    else if (char.IsLetter(action) && char.IsLower(action)) { price = 0.3m * (int)action; }
                    else if (action == '%') { price = money / 2; }
                    else { price = (int)action; }

                    if (money < price || money == 0) continue;

                    money -= price;
                    countPurchases++;
                }
            }

            string purchases = countPurchases == 0 ? "No" : countPurchases.ToString();
            Console.WriteLine($"{purchases} purchases. Money left: {money:f2} lv.");
        }
    }
}