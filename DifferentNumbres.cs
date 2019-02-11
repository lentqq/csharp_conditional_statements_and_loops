using System;

namespace _11.DifferentNumbres
{
    class DifferentNumbres
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool num = false;
            for (int i = a; i <= b; i++)
            {
                for (int i2 = a; i2 <= b; i2++)
                {
                    for (int i3 = a; i3 <= b; i3++)
                    {
                        for (int i4 = a; i4 <= b; i4++)
                        {
                            for (int i5 = a; i5 <= b; i5++)
                            {
                                if (i >= a && i < i2 && i2 < i3 && i3 < i4 && i4 < i5 && i5 <= b)
                                {
                                    num = true;
                                    Console.WriteLine($"{i} {i2} {i3} {i4} {i5} ");
                                }
                            }
                           
                        }
                           
                    }
                }              
            }
            if (num != true)
            {
                Console.WriteLine("No");
            }
        }
    }
}
