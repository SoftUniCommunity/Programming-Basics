using System;

public class Notifications
{
    public static void Main()
    {
        ReadAndProcessMessage();
    }

    public static void ReadAndProcessMessage()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var messageType = Console.ReadLine();

            switch (messageType)
            {
                case "success":
                    var operation = Console.ReadLine();
                    var successMessage = Console.ReadLine();
                    ShowSuccessMessage(operation, successMessage);
                    break;
                case "warning":
                    var warningMessage = Console.ReadLine();
                    ShowWarningMessage(warningMessage);
                    break;
                case "error":
                    var errorOperation = Console.ReadLine();
                    var errorMessage = Console.ReadLine();
                    var errorCode = int.Parse(Console.ReadLine());
                    ShowErrorMessage(errorOperation, errorMessage, errorCode);
                    break;
            }
        }
    }

    public static void ShowErrorMessage(string operation, string message, int code)
    {
        var errorString = $"Error: Failed to execute {operation}.";
        Console.WriteLine(errorString);
        Console.WriteLine(new string('=', errorString.Length));
        Console.WriteLine($"Reason: {message}.");
        Console.WriteLine($"Error code: {code}.");
        Console.WriteLine();
    }

    public static void ShowSuccessMessage(string operation, string message)
    {
        var operationString = $"Successfully executed {operation}.";

        Console.WriteLine(operationString);
        Console.WriteLine(new string('=', operationString.Length));
        Console.WriteLine($"{message}.");
        Console.WriteLine();
    }

    public static void ShowWarningMessage(string message)
    {
        var warningString = $"Warning: {message}.";

        Console.WriteLine(warningString);
        Console.WriteLine(new string('=', warningString.Length));
        Console.WriteLine();
    }
}