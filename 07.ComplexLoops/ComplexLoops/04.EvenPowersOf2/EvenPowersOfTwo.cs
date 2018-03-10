using System;

public class EvenPowersOfTwo
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double num = 1;

        for (int power = 0; power <= n; power += 2)
        {
            Console.WriteLine(num);
            num *= 4;
        }
    }
}