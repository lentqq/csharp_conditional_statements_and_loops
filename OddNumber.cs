using System;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 9; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else if (n % 2 != 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
            }
        }
    }
}
