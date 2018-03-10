using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string combination = "bcddc";

        const int weightA = 5;
        const int weightB = -12;
        const int weightC = 47;
        const int weightD = 7;
        const int weightE = -32;

        string uniqueCombination = "" + combination[0];

        for (int i = 1; i < combination.Length; i++)
        {
            char letter = combination[i];

            if (uniqueCombination.IndexOf(letter) == -1)
            {
                uniqueCombination += letter;
            }
        }

        int weight = 0;

        for (int i = 0; i < uniqueCombination.Length; i++)
        {
            char letter = uniqueCombination[i];
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
    }
}