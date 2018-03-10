using System;

public class Operations
{
    public static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        string operation = Console.ReadLine();

        double result = 0;
        string output = string.Empty;

        if (n2 == 0 && (operation.Equals("/") || operation.Equals("%")))
        {
            output = string.Format("Cannot divide {0} by zero", n1);
        }
        else if (operation.Equals("/"))
        {
            result = n1 / (double)n2;
            output = string.Format("{0} / {1} = {2:F2}", n1, n2, result);
        }
        else if (operation.Equals("%"))
        {
            result = n1 % n2;
            output = string.Format("{0} % {1} = {2}", n1, n2, result);
        }
        else
        {
            if (operation.Equals("+"))
            {
                result = n1 + n2;
            }
            else if (operation.Equals("-"))
            {
                result = n1 - n2;
            }
            else if (operation.Equals("*"))
            {
                result = n1 * n2;
            }

            output = string.Format("{0} {1} {2} = {3} - {4}",
                n1, operation, n2, result, result % 2 == 0 ? "even" : "odd");
        }

        Console.WriteLine(output);
    }
}