using System;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1; i <= 20; i++)
            {
                string ingredients = Console.ReadLine();
                if (ingredients == "Bake!")
                {
                    break;
                }              
                Console.WriteLine($"Adding ingredient {ingredients}.");
                count++;              
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
