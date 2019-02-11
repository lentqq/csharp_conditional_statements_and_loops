using System;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maximumSumBoundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int multiply = 0;
            int counter = 0;
            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    multiply = 3 * (i * j);
                    sum += multiply;
                    counter++;
                    if (sum >= maximumSumBoundary)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maximumSumBoundary}");
                        return;
                    }
                }             
            }
            if (sum < maximumSumBoundary)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}


