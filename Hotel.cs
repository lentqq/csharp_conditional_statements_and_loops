using System;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;
           
            switch (month)
            {
                case "may":
                case "october":
                    studioPrice = 50.0;
                    doublePrice = 65.0;
                    suitePrice = 75.0;
                    if (nightsCount > 7)
                    {
                        studioPrice *= 0.95;
                    }
                    break;
                case "june":
                case "september":
                    studioPrice = 60.0;
                    doublePrice = 72.0;
                    suitePrice = 82.0;
                    if (nightsCount > 14)
                    {
                        doublePrice *= 0.90;
                    }
                    break;
                case "july":
                case "august":
                case "december":
                    studioPrice = 68.0;
                    doublePrice = 77.0;
                    suitePrice = 89.0;
                    if (nightsCount > 14)
                    {
                        suitePrice *= 0.85;
                    }
                    break;
            }
            double studioTotalPrice = nightsCount * studioPrice;
            double doubleTotalPrice = nightsCount * doublePrice;
            double suiteTotalPrice = nightsCount * suitePrice;
            if (nightsCount > 7 && month == "september" || month == "october")
            {
                studioTotalPrice = studioTotalPrice - studioPrice;
            }
            Console.WriteLine($"Studio: {studioTotalPrice:f2} lv.");
            Console.WriteLine($"Double: {doubleTotalPrice:f2} lv.");
            Console.WriteLine($"Suite: {suiteTotalPrice:f2} lv.");
        }
    }
}
