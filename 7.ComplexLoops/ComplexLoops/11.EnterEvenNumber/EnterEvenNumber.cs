using System;

public class EnterEvenNumber
{
    public static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter even number: ");

                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {n}");
                    return;
                }

                Console.WriteLine("The number is not even.");
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}