using System;

public class BullsAndCows
{
    public static void Main()
    {
        int guessNumber = int.Parse(Console.ReadLine());
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCaws = int.Parse(Console.ReadLine());

        bool found = false;

        int guessDigit1 = guessNumber / 1000;
        int guessDigit2 = guessNumber / 100 % 10;
        int guessDigit3 = guessNumber / 10 % 10;
        int guessDigit4 = guessNumber % 10;

        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        int combination = int.Parse($"{i}{j}{k}{l}");

                        int digitToCheck1 = i;
                        int digitToCheck2 = j;
                        int digitToCheck3 = k;
                        int digitToCheck4 = l;

                        int currentBulls = 0;
                        int currentCaws = 0;

                        if (digitToCheck1 == guessDigit1)
                        {
                            currentBulls++;
                            guessDigit1 = -1;
                            digitToCheck1 = -2;
                        }

                        if (digitToCheck2 == guessDigit2)
                        {
                            currentBulls++;
                            guessDigit2 = -1;
                            digitToCheck2 = -2;
                        }

                        if (digitToCheck3 == guessDigit3)
                        {
                            currentBulls++;
                            guessDigit3 = -1;
                            digitToCheck3 = -2;
                        }

                        if (digitToCheck4 == guessDigit4)
                        {
                            currentBulls++;
                            guessDigit4 = -1;
                            digitToCheck4 = -2;
                        }

                        if (digitToCheck1 == guessDigit2)
                        {
                            currentCaws++;
                            guessDigit2 = -1;
                        }
                        else if (digitToCheck1 == guessDigit3)
                        {
                            currentCaws++;
                            guessDigit3 = -1;
                        }
                        else if (digitToCheck1 == guessDigit4)
                        {
                            currentCaws++;
                            guessDigit4 = -1;
                        }

                        if (digitToCheck2 == guessDigit1)
                        {
                            currentCaws++;
                            guessDigit1 = -1;
                        }
                        else if (digitToCheck2 == guessDigit3)
                        {
                            currentCaws++;
                            guessDigit3 = -1;
                        }
                        else if (digitToCheck2 == guessDigit4)
                        {
                            currentCaws++;
                            guessDigit4 = -1;
                        }

                        if (digitToCheck3 == guessDigit1)
                        {
                            currentCaws++;
                            guessDigit1 = -1;
                        }
                        else if (digitToCheck3 == guessDigit2)
                        {
                            currentCaws++;
                            guessDigit2 = -1;
                        }
                        else if (digitToCheck3 == guessDigit4)
                        {
                            currentCaws++;
                            guessDigit4 = -1;
                        }

                        if (digitToCheck4 == guessDigit1)
                        {
                            currentCaws++;
                            guessDigit1 = -1;
                        }
                        else if (digitToCheck4 == guessDigit2)
                        {
                            currentCaws++;
                            guessDigit2 = -1;
                        }
                        else if (digitToCheck4 == guessDigit3)
                        {
                            currentCaws++;
                            guessDigit3 = -1;
                        }

                        if (currentBulls == targetBulls && currentCaws == targetCaws)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(combination);
                            found = true;
                        }
                    }
                }
            }
        }

        Console.WriteLine(found ? "" : "No");
    }
}