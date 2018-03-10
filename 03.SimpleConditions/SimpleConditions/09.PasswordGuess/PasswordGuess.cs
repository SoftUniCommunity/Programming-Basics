using System;

public class PasswordGuess
{
    public static void Main()
    {
        string password = Console.ReadLine();
        string secretPassword = "s3cr3t!P@ssw0rd";

        if (password == secretPassword)
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}