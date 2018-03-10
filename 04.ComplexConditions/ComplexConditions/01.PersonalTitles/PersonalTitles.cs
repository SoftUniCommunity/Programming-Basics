using System;

public class PersonalTitles
{
    public static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if (age >= 16)
        {
            Console.WriteLine(gender == "m" ? "Mr." : "Ms.");
        }
        else
        {
            Console.WriteLine(gender == "m" ? "Master" : "Miss");
        }
    }
}