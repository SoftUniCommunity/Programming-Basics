using System;

public class VowelsSum
{
    public static void Main()
    {
        string str = Console.ReadLine();

        int vowelsSum = 0;

        for (int i = 0; i < str.Length; i++)
        {
            char letter = str[i];

            switch (letter)
            {
                case 'a':
                    vowelsSum += 1;
                    break;
                case 'e':
                    vowelsSum += 2;
                    break;
                case 'i':
                    vowelsSum += 3;
                    break;
                case 'o':
                    vowelsSum += 4;
                    break;
                case 'u':
                    vowelsSum += 5;
                    break;
            }
        }

        Console.WriteLine($"Vowels sum = {vowelsSum}");
    }
}