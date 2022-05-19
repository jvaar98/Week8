using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();

        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }
        private static void DisplayRandomFood()
        {
            string[] foods = { " kala", "pasta", "kurk", "mari", "oks" };

            Console.WriteLine($"Arvuti valis:{foods[GenerateRandomIndex(foods)]}");

        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "piim", "vesi", "koka", "marjajook", "oksa vesi" };

            Console.WriteLine($"Arvuti valis:{drinks[GenerateRandomIndex(drinks)]}");
        }
        private static void DisplayRandomMovie()
        {
            string[] Movie = { "SF1", "SF2", "SM1", "SM2", "Kevade" };

            Console.WriteLine($"Arvuti valis:{Movie[GenerateRandomIndex(Movie)]}");
        }
    }
}