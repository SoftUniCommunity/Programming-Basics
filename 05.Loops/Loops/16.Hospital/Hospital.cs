using System;

public class Hospital
{
    public static void Main()
    {
        int period = int.Parse(Console.ReadLine());

        int treatedPatients = 0;
        int untreatedPatients = 0;
        int doctorsCount = 7;

        for (int day = 1; day <= period; day++)
        {
            if (day % 3 == 0 && untreatedPatients > treatedPatients)
            {
                doctorsCount++;
            }

            int patients = int.Parse(Console.ReadLine());

            if (patients <= doctorsCount)
            {
                treatedPatients += patients;
            }
            else
            {
                untreatedPatients += patients - doctorsCount;
                treatedPatients += doctorsCount;
            }
        }

        Console.WriteLine($"Treated patients: {treatedPatients}.");
        Console.WriteLine($"Untreated patients: {untreatedPatients}.");
    }
}