using System;

public class AreaOfFigures
{
    public static void Main()
    {
        string figure = Console.ReadLine().ToLower();

        switch (figure)
        {
            case "square":
                double squareSide = double.Parse(Console.ReadLine());
                double squareArea = Math.Pow(squareSide, 2);
                Console.WriteLine($"{squareArea:F3}");
                break;
            case "rectangle":
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double rectArea = length * width;
                Console.WriteLine($"{rectArea:F3}");
                break;
            case "circle":
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine($"{circleArea:F2}");
                break;
            case "triangle":
                double triangleSide = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double triangleArea = triangleSide * height / 2;
                Console.WriteLine($"{triangleArea:F3}");
                break;
        }
    }
}