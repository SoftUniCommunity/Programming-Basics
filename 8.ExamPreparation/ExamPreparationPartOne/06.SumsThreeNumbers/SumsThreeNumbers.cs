using System;

public class SumsThreeNumbers
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        string output = string.Empty;

        if (a + b == c)
        {
            output = DoStuff(a, b, c);
        }
        else if (b + c == a)
        {
            output = DoStuff(b, c, a);
        }
        else if (a + c == b)
        {
            output = DoStuff(a, c, b);
        }
        else
        {
            output = "No";
        }

        Console.WriteLine(output);
    }

    public static string DoStuff(int firstNum, int secondNum, int thirdNum)
    {
        string output = string.Empty;
        int smallestNum = Math.Min(firstNum, secondNum);
        int middleNum = Math.Max(firstNum, secondNum);
        output = $"{smallestNum} + {middleNum} = {thirdNum}";
        return output;
    }
}