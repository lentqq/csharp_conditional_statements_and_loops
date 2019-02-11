using System;

namespace _05.ForeigenLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            string cuntryName = Console.ReadLine();

            switch (cuntryName)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
