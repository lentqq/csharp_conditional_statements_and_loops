using System;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = secondNumber; i >= firstNumber; i--)
            { 
                for (int j = secondNumber; j >= firstNumber; j--)
                {
                    if (i + j == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicalNumber} ");
                        return;
                    }
                    counter++;
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
        }
    }
}
