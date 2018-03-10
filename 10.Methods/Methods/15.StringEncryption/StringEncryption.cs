using System;
using System.Text;

public class StringEncryption
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var finalEncrypted = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            var currentChar = Console.ReadLine()[0];
            var encrypted = Encrypt(currentChar);
            finalEncrypted.Append(encrypted);
        }

        Console.WriteLine(finalEncrypted);
    }

    public static string Encrypt(char currentChar)
    {
        var firstDigit = (int)currentChar;
        var lastDigit = currentChar % 10;

        while (firstDigit >= 10)
        {
            firstDigit /= 10;
        }

        var start = (char)(currentChar + lastDigit);
        var end = (char)(currentChar - firstDigit);

        var encrypted = $"{start}{firstDigit}{lastDigit}{end}";

        return encrypted;
    }
}