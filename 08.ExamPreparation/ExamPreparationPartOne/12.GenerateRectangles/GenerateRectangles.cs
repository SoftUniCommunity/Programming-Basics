using System;

public class Generate_Rectangles
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int count = 0;

        for (int left = -n; left <= n; left++)
        {
            for (int top = -n; top <= n; top++)
            {
                for (int right = n; right > left; right--)
                {
                    for (int bottom = n; bottom > top; bottom--)
                    {
                        int area = (right - left) * (bottom - top);

                        if (area >= m)
                        {
                            Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",
                                left, top, right, bottom, area);
                            count++;
                        }
                    }
                }
            }
        }

        if (count.Equals(0))
        {
            Console.WriteLine("No");
        }
    }
}