using System;

public class EnterEvenNumberWithTextInput
{
    public static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Enter even number: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"Even number entered: {num}");
                    break;
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