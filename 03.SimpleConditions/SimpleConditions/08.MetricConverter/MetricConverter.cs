using System;

public class MetricConverter
{
    public static void Main()
    {
        double size = double.Parse(Console.ReadLine());
        string sourceMetric = Console.ReadLine().ToLower();
        string destMetric = Console.ReadLine().ToLower();

        //Converting size to meters
        if (sourceMetric == "mm")
        {
            size /= 1000;
        }
        else if (sourceMetric == "cm")
        {
            size /= 100;
        }
        else if (sourceMetric == "mi")
        {
            size /= 0.000621371192;
        }
        else if (sourceMetric == "in")
        {
            size /= 39.3700787;
        }
        else if (sourceMetric == "km")
        {
            size /= 0.001;
        }
        else if (sourceMetric == "ft")
        {
            size /= 3.2808399;
        }
        else if (sourceMetric == "yd")
        {
            size /= 1.0936133;
        }

        if (destMetric == "mm")
        {
            size *= 1000;
        }
        else if (destMetric == "cm")
        {
            size *= 100;
        }
        else if (destMetric == "mi")
        {
            size *= 0.000621371192;
        }
        else if (destMetric == "in")
        {
            size *= 39.3700787;
        }
        else if (destMetric == "km")
        {
            size *= 0.001;
        }
        else if (destMetric == "ft")
        {
            size *= 3.2808399;
        }
        else if (destMetric == "yd")
        {
            size *= 1.0936133;
        }

        Console.WriteLine($"{size} {destMetric}");
    }
}