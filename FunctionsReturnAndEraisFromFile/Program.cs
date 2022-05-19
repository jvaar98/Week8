using System;

namespace FunctionsReturnAndEraisFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }
        private static void DisplayRandomFood()
        {
            string[] foods = { " kala", "pasta", "kurk", "mari", "oks" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Arvuti valis:{randomFood}");

        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "piim", "vesi", "koka", "marjajook", "oksa vesi" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string randomDrink = drinks[randomIndex];
            Console.WriteLine($"Arvuti valis:{randomDrink}");
        }
        private static void DisplayRandomMovie()
        {
            string[] Movie = { "SF1", "SF2", "SM1", "SM2", "Kevade" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Movie.Length);

            string randomMovie = Movie[randomIndex];
            Console.WriteLine($"Arvuti valis:{randomMovie}");
        }

    }

}