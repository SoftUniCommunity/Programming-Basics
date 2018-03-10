using System;
using System.Text;

public class StringRepeater
{
    public static void Main()
    {
        var text = Console.ReadLine();
        var count = int.Parse(Console.ReadLine());

        var repeated = RepeatString(text, count);

        Console.WriteLine(repeated);
    }

    public static string RepeatString(string text, int count)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            sb.Append(text);
        }

        return sb.ToString();
    }
}