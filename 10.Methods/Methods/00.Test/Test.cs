using System;

public class Methods
{
    public static void Main()
    {
        string output = "I am a local function";

        void Print()
        {
            Console.WriteLine(output); 
        }
    }

    public static double PlusOne(double n)
    {
        return (int)(n + 1);
    }

    public static void PrintNumbers(int start = 0, int end = 100)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }

    public static double GetSquare(double num)
    {
        return num * num;
    }

    public static void Print(string text)
    {
        Console.WriteLine(text);
    }

    public static void Print(int number)
    {
        Console.WriteLine(number);
    }

    public static void Print(string text, int number)
    {
        Console.WriteLine(text + " " + number);
    }
}