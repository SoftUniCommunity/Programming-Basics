using System;

public class TrainingLab
{
    public static void Main()
    {
        double length = double.Parse(Console.ReadLine()) * 100; // centimeters
        double width = double.Parse(Console.ReadLine()) * 100; // centimeters

        int rows = (int)length / 120;
        int cols = ((int)width - 100) / 70;
        int seats = rows * cols - 3;

        Console.WriteLine(seats);
    }
}