using System;

namespace _02.Choose2
{
    class Choose2
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;
            switch (profession)
            {
                case "Athlete":
                    {
                       // Console.WriteLine("Water");
                        price = 0.70;
                    }
                    break;
                case "Businessman":
                case "Businesswoman":
                    {
                       // Console.WriteLine("Coffee");
                        price = 1.00;
                    }
                    break;
                case "SoftUni Student":
                    {
                       // Console.WriteLine("Beer");
                        price = 1.70;
                    }
                    break;
                default:
                    {
                       // Console.WriteLine("Tea");
                        price = 1.20;
                    }
                    break;
            }
            double totalPrice = quantity * price;
            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
