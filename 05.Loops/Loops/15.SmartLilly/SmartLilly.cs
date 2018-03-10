using System;

public class SmartLilly
{
    public static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double machinePrice = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        const int brotherTax = 1;
        int savedMoney = 0;
        int moneyForBirthday = 10;
        int numberOfToys = 0;

        for (int birthday = 1; birthday <= age; birthday++)
        {
            if (birthday % 2 != 0)
            {
                numberOfToys++;
            }
            else
            {
                savedMoney += moneyForBirthday - brotherTax;
                moneyForBirthday += 10;
            }
        }

        int moneyFromPresents = numberOfToys * toyPrice;
        savedMoney += moneyFromPresents;
        bool enoughMoney = savedMoney >= machinePrice;
        double difference = Math.Abs(savedMoney - machinePrice);

        Console.WriteLine(enoughMoney ? $"Yes! {difference:F2}" : 
            $"No! {difference:F2}");
    }
}