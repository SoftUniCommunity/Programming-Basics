using System;

public class TradeComissions
{
    public static void Main()
    {
        string town = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());

        double comission = -1;

        if (town == "sofia")
        {
            if (sales > 10000)
            {
                comission = 12;
            }
            else if (sales > 1000)
            {
                comission = 8;
            }
            else if (sales > 500)
            {
                comission = 7;
            }
            else if (sales >= 0)
            {
                comission = 5;
            }
        }
        else if (town == "varna")
        {
            if (sales > 10000)
            {
                comission = 13;
            }
            else if (sales > 1000)
            {
                comission = 10;
            }
            else if (sales > 500)
            {
                comission = 7.5;
            }
            else if (sales >= 0)
            {
                comission = 4.5;
            }
        }
        else if (town == "plovdiv")
        {
            if (sales > 10000)
            {
                comission = 14.5;
            }
            else if (sales > 1000)
            {
                comission = 12;
            }
            else if (sales > 500)
            {
                comission = 8;
            }
            else if (sales >= 0)
            {
                comission = 5.5;
            }
        }

        if (comission != -1)
        {
            Console.WriteLine("{0:F2}", sales * comission / 100);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}