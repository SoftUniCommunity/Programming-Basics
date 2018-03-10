using System;

public class Money
{
    public static void Main()
    {
        int bitcoins = int.Parse(Console.ReadLine());
        double chineseYuan = double.Parse(Console.ReadLine());
        double commission = double.Parse(Console.ReadLine()) / 100;

        double bitcoinsToLeva = bitcoins * 1168;
        double chineseYuanToDollar = chineseYuan * 0.15;
        double chineseYuanToLeva = chineseYuanToDollar * 1.76;
        double totalMoneyToLeva = bitcoinsToLeva + chineseYuanToLeva;
        double totalMoneyToEuro = totalMoneyToLeva / 1.95;
        double totalComission = totalMoneyToEuro * commission;
        double moneyLeft = totalMoneyToEuro - totalComission;

        Console.WriteLine(moneyLeft);
    }
}