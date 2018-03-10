using System;

public class InvalidNumber
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool inRange = number >= 100 && number <= 200 || number == 0;

        if (!inRange)
        {
            Console.WriteLine("invalid");
        }
    }
}