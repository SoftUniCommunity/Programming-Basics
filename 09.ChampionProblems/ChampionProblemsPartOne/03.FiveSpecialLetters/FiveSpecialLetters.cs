using System;
using System.Linq;

public class FiveSpecialLetters
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        bool printed = false;

        for (char i = 'a'; i <= 'e'; i++)
        {
            for (char j = 'a'; j <= 'e'; j++)
            {
                for (char k = 'a'; k <= 'e'; k++)
                {
                    for (char l = 'a'; l <= 'e'; l++)
                    {
                        for (char m = 'a'; m <= 'e'; m++)
                        {
                            string combination = $"{i}{j}{k}{l}{m}";
                            int weight = CalculateWeight(combination);

                            if (weight >= start && weight <= end)
                            {
                                Console.Write(printed ? $" {combination}" : $"{combination}");
                                printed = true;
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine(printed ? "" : "No");
    }

    public static int CalculateWeight(string combination)
    {
        const int weightA = 5;
        const int weightB = -12;
        const int weightC = 47;
        const int weightD = 7;
        const int weightE = -32;

        char[] combArray = combination
            .Distinct()
            .ToArray();

        int weight = 0;

        for (int i = 0; i < combArray.Length; i++)
        {
            char letter = combArray[i];
            int add = 0;

            switch (letter)
            {
                case 'a':
                    add = weightA;
                    break;
                case 'b':
                    add = weightB;
                    break;
                case 'c':
                    add = weightC;
                    break;
                case 'd':
                    add = weightD;
                    break;
                case 'e':
                    add = weightE;
                    break;
            }

            weight += (i + 1) * add;
        }

        return weight;
    }
}