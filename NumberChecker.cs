using System;

namespace _12.NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    {
                        Console.WriteLine("It is a number.");
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
