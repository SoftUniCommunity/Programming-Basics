using System;

public class StupidPasswordGenerator
{
    public static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        bool temp = false;

        for (int sym1 = 1; sym1 <= firstNum; sym1++)
        {
            for (int sym2 = 1; sym2 <= firstNum; sym2++)
            {
                for (char sym3 = 'a'; sym3 < 'a' + secondNum; sym3++)
                {
                    for (char sym4 = 'a'; sym4 < 'a' + secondNum; sym4++)
                    {
                        for (int sym5 = Math.Max(sym1, sym2) + 1; sym5 <= firstNum; sym5++)
                        {
                            string password = $"{sym1}{sym2}{sym3}{sym4}{sym5}";

                            Console.Write(temp ? $" {password}" : $"{password}");
                            temp = true;
                        }
                    }
                }
            }
        }

        Console.WriteLine();
    }
}