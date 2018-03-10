using System;

public class Startup
{
    public static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool firstRectangle = x > h && x < 2 * h && y >= h && y < 4 * h; // Inside
        bool secondRectangle = x > 0 && x < 3 * h && y > 0 && y < h;     // Inside

        bool firstTop = y == 4 * h && x >= h && x <= 2 * h;
        bool firstLeft = x == h && y >= h && y <= 4 * h;
        bool firstRight = x == 2 * h && y >= h && y <= 4 * h;
        bool secondLeft = x == 0 && y >= 0 && y <= h;
        bool secondRight = x == 3 * h && y >= 0 && y <= h;
        bool secondDown = y == 0 && x >= 0 && x <= 3 * h;
        bool secondUpLeft = y == h && x >= 0 && x <= h;
        bool secondUpRight = y == h && x >= 2 * h && x <= 3 * h;
        bool onBorder = firstTop || firstLeft || firstRight || secondLeft ||
            secondRight || secondDown || secondUpLeft || secondUpRight; // Border

        if (firstRectangle || secondRectangle)
        {
            Console.WriteLine("inside");
        }
        else if (onBorder)
        {
            Console.WriteLine("border");
        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}
