using System;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    var num = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
