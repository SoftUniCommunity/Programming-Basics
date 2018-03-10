using System;

public class HotelRoom
{
    public static void Main()
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        decimal studioPrice = 50.00M;
        decimal apartmentPrice = 65.00M;
        decimal studioRent = 0.00M;
        decimal apartmentRent = 0.00M;

        switch (month)
        {
            case "May":
            case "October":
                studioPrice = 50.00M;
                apartmentPrice = 65.00M;
                studioRent = studioPrice * nights;
                apartmentRent = apartmentPrice * nights;
                if (nights > 14)
                {
                    apartmentRent -= 0.10M * apartmentRent;
                    studioRent -= 0.30M * studioRent;
                }
                else if (nights > 7)
                {
                    studioRent -= 0.05M * studioRent;
                }
                break;
            case "June":
            case "September":
                studioPrice = 75.20M;
                apartmentPrice = 68.70M;
                studioRent = studioPrice * nights;
                apartmentRent = apartmentPrice * nights;
                if (nights > 14)
                {
                    apartmentRent -= 0.10M * apartmentRent;
                    studioRent -= 0.20M * studioRent;
                }
                break;
            case "July":
            case "August":
                studioPrice = 76.00M;
                apartmentPrice = 77.00M;
                studioRent = studioPrice * nights;
                apartmentRent = apartmentPrice * nights;
                if (nights > 14)
                {
                    apartmentRent -= 0.10M * apartmentRent;
                }
                break;
        }

        Console.WriteLine($"Apartment: {apartmentRent:F2} lv.");
        Console.WriteLine($"Studio: {studioRent:F2} lv.");
    }
}