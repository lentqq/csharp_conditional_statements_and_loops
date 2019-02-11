using System;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int numIngredients = int.Parse(Console.ReadLine());
            int caloriesAmount = 0;
            for (int i = 1; i <= numIngredients; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                switch (ingredients)
                {
                    case "cheese":
                        int cheese = 500;
                        caloriesAmount += cheese;
                        break;
                    case "tomato sauce":
                        int tomatoSauce = 150;
                        caloriesAmount += tomatoSauce;
                        break;
                    case "salami":
                        int salami = 600;
                        caloriesAmount += salami;
                        break;
                    case "pepper":
                        int pepper = 50;
                        caloriesAmount += pepper;
                        break;
                }
            }
            Console.WriteLine($"Total calories: {caloriesAmount}");
        }
    }
}
