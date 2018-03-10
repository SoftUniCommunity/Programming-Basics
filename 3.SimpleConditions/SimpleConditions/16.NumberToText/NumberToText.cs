using System;

public class NumberToText
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        if (a >= 0 && a <= 9)
        {
            switch (a)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }
        else if (a >= 10 && a <= 19)
        {
            switch (a)
            {
                case 10:
                    Console.WriteLine("ten");
                    break;
                case 11:
                    Console.WriteLine("eleven");
                    break;
                case 12:
                    Console.WriteLine("twelve");
                    break;
                case 13:
                    Console.WriteLine("thirteen");
                    break;
                case 14:
                    Console.WriteLine("fourteen");
                    break;
                case 15:
                    Console.WriteLine("fifteen");
                    break;
                case 16:
                    Console.WriteLine("sixteen");
                    break;
                case 17:
                    Console.WriteLine("seventeen");
                    break;
                case 18:
                    Console.WriteLine("eighteen");
                    break;
                case 19:
                    Console.WriteLine("nineteen");
                    break;
            }
        }
        else if (a >= 20 && a <= 99)
        {
            int tens = a / 10;
            int ones = a % 10;

            switch (tens)
            {
                case 2:
                    Console.Write("twenty");
                    break;
                case 3:
                    Console.Write("thirty");
                    break;
                case 4:
                    Console.Write("fourty");
                    break;
                case 5:
                    Console.Write("fifty");
                    break;
                case 6:
                    Console.Write("sixty");
                    break;
                case 7:
                    Console.Write("seventy");
                    break;
                case 8:
                    Console.Write("eighty");
                    break;
                case 9:
                    Console.Write("ninety");
                    break;
            }

            switch (ones)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine(" one");
                    break;
                case 2:
                    Console.WriteLine(" two");
                    break;
                case 3:
                    Console.WriteLine(" three");
                    break;
                case 4:
                    Console.WriteLine(" four");
                    break;
                case 5:
                    Console.WriteLine(" five");
                    break;
                case 6:
                    Console.WriteLine(" six");
                    break;
                case 7:
                    Console.WriteLine(" seven");
                    break;
                case 8:
                    Console.WriteLine(" eight");
                    break;
                case 9:
                    Console.WriteLine(" nine");
                    break;
            }
        }

        if (a == 100)
        {
            Console.WriteLine("one hundred");
        }
        else if (a < 0 || a > 100)
        {
            Console.WriteLine("number must be in range 0-100");
        }
    }
}