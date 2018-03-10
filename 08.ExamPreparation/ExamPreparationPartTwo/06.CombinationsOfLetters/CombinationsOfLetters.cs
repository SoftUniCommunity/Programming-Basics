using System;

public class CombinationsOfLetters
{
    public static void Main()
    {
        char startLetter = Console.ReadLine()[0];
        char endLetter = Console.ReadLine()[0];
        char exceptLetter = Console.ReadLine()[0];

        int totalCombinations = 0;
        bool temp = false;

        for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
        {
            for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
            {
                for (char thirdLetter = startLetter; thirdLetter <= endLetter; thirdLetter++)
                {
                    bool isValidCombination =
                        firstLetter != exceptLetter &&
                        secondLetter != exceptLetter &&
                        thirdLetter != exceptLetter;

                    if (isValidCombination)
                    {
                        string combination = $"{firstLetter}{secondLetter}{thirdLetter}";
                        Console.Write(temp ? " " + combination : combination);
                        totalCombinations++;
                        temp = true;
                    }
                }
            }
        }

        Console.WriteLine(" " + totalCombinations);
    }
}