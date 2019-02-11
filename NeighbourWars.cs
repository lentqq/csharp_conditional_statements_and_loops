using System;

namespace _14.NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealthPoints = 100;
            int goshoHealthPoints = 100;
            int numberOfTheRound = 0;

            while (peshoHealthPoints > 0 && goshoHealthPoints > 0)
            {
                numberOfTheRound++;
                if (numberOfTheRound % 2 != 0)
                {
                    goshoHealthPoints -= peshoDamage;
                    if (goshoHealthPoints > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealthPoints} health.");
                    }
                }
                else
                {
                    peshoHealthPoints -= goshoDamage;
                    if (peshoHealthPoints > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealthPoints} health.");
                    }
                }
                if (numberOfTheRound % 3 == 0 && goshoHealthPoints > 0 && peshoHealthPoints > 0)
                {
                    goshoHealthPoints += 10;
                    peshoHealthPoints += 10;
                }
            }
            if (numberOfTheRound % 2 == 0)
            {
                Console.WriteLine($"Gosho won in {numberOfTheRound}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {numberOfTheRound}th round.");
            }
        }
    }
}
