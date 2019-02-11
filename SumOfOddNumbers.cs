using System;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int SumOfOddNumbers = 0;
            for (int i = 1; i <= n; i++)
            {
               // if (i % 2 != 0)
               // {
                    Console.WriteLine(2 * i - 1);
                    SumOfOddNumbers += 2 * i - 1;
               // }
            }
            Console.WriteLine($"Sum: {SumOfOddNumbers}");
        }
    }
}
