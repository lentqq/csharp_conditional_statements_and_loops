using System;

namespace _13.MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter ; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i == skipLetter || j == skipLetter || k == skipLetter)
                        {
                            continue;
                        }
                        Console.Write($"{i}{j}{k} ");
                    }
                }
            }
        }
    }
}
