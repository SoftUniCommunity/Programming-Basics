using System;

public class PointInTheFigure
{
    public static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool firstRectangle = x > 0 && x < 3 * h && y > 0 && y < h;       // Inside
        bool secondRectangle = x > h && x < 2 * h && y >= h && y < 4 * h; // Inside

        bool firstLeft = x == 0 && y >= 0 && y <= h;
        bool firstRight = x == 3 * h && y >= 0 && y <= h;
        bool firstLeftUp = y == h && x >= 0 && x <= h;
        bool firstRightUp = y == h && x >= 2 * h && x <= 3 * h;
        bool firstDown = y == 0 && x >= 0 && x <= 3 * h;
        bool secondTop = y == 4 * h && x >= h && x <= 2 * h;
        bool secondLeft = x == h && y >= h && y <= 4 * h;
        bool secondRight = x == h && y >= h && y <= 4 * h;
        bool onBorder = firstLeft || firstRight || firstLeftUp || firstDown ||
                        firstRightUp || secondTop || secondLeft || secondRight;

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