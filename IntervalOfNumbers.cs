using System;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int smaller = Math.Min(a, b);
            int bigger = Math.Max(a, b);
            for (int i = smaller; i <= bigger; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
