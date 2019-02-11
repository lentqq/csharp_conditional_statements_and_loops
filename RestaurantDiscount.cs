using System;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            double hallPrice = 0.0;
            double packagePrice = 0.0;
            double totalPrice = 0.0;
            double discount = 0.0;
            switch (package)
            {
                case "normal":
                    packagePrice = 500.0;
                    if (groupSize <= 50)
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        hallPrice = 2500.0;
                    }
                    if (groupSize > 50 && groupSize <= 100)
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        hallPrice = 5000.0;
                    }
                    if (groupSize > 100 && groupSize <= 120)
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        hallPrice = 7500.0;
                    }
                    totalPrice = packagePrice + hallPrice;
                    discount = totalPrice - totalPrice * 0.05;
                    break;
                case "gold":
                    packagePrice = 750.0;
                    if (groupSize <= 50)
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        hallPrice = 2500.0;
                    }
                    if (groupSize > 50 && groupSize <= 100)
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        hallPrice = 5000.0;
                    }
                    if (groupSize > 100 && groupSize <= 120)
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        hallPrice = 7500.0;
                    }
                    totalPrice = packagePrice + hallPrice;
                    discount = totalPrice - totalPrice * 0.10;
                    break;
                case "platinum":
                    packagePrice = 1000.0;
                    if (groupSize <= 50)
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        hallPrice = 2500.0;
                    }
                    if (groupSize > 50 && groupSize <= 100)
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        hallPrice = 5000.0;
                    }
                    if (groupSize > 100 && groupSize <= 120)
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        hallPrice = 7500.0;
                    }
                    totalPrice = packagePrice + hallPrice;
                    discount = totalPrice - totalPrice * 0.15;
                    break;
            }
            double pricePerPerson = discount / groupSize;
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}
