using System;

namespace _10.TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}");
                for (int i2 = 2; i2 <= i; i2++)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine();
            }
        }
    }
}
 