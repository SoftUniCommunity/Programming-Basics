using System;

public class GreaterOfTwoValues
{
    public static void Main()
    {
        string type = Console.ReadLine().ToLower();

        if (type.Equals("int"))
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            GetMax(firstNum, secondNum);
        }
        else if (type.Equals("char"))
        {
            char firstChar = Console.ReadLine()[0];
            char secondChar = Console.ReadLine()[0];
            GetMax(firstChar, secondChar);
        }
        else if (type.Equals("string"))
        {
            string firsStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            GetMax(firsStr, secondStr);
        }
    }

    public static void GetMax(int firstNum, int secondNum)
    {
        int max = Math.Max(firstNum, secondNum);
        Console.WriteLine(max);
    }

    public static void GetMax(char firstChar, char secondChar)
    {
        char max = (char)Math.Max(firstChar, secondChar);
        Console.WriteLine(max);
    }

    public static void GetMax(string firstStr, string secondStr)
    {
        Console.WriteLine(firstStr.CompareTo(secondStr) >= 0 ? firstStr : secondStr);
    }
}