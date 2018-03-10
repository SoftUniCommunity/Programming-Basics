using System;

public class ConcatenateData
{
    public static void Main()
    {
        string firstName = Console.ReadLine();
        string secondName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string town = Console.ReadLine();

        Console.WriteLine($"You are {firstName} {secondName}, a {age}-years old person from {town}.");
    }
}