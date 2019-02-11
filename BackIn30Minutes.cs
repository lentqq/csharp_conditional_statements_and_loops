using System;

namespace _03.BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = minutes + 30;
            if (totalMinutes > 59)
            {
                totalMinutes -= 60;
                hours++;
                if (hours > 23)
                {
                    hours -= 24;
                }
            }
            Console.WriteLine($"{hours}:{totalMinutes:d2}");
        }
    }
}
