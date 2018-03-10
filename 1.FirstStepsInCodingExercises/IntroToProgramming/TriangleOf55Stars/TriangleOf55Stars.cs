using System;

namespace TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main()
        {
            for (int row = 1; row <= 10; row++)
            {
                Console.WriteLine(new string('*', row));
            }
        }
    }
}