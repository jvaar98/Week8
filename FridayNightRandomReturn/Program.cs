using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { " kala", "pasta", "kurk", "mari", "oks" };
            string[] drinks = { "piim", "vesi", "koka", "marjajook", "oksa vesi" };
            string[] Movie = { "SF1", "SF2", "SM1", "SM2", "Kevade" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drinks);
            randomMovie = PickRandomElementFromArray(Movie);

            Console.WriteLine($"Täna sa sööd{randomFood}, ning selle kõrvale jood {randomDrink} ning samal ajal vaatada{randomMovie}.");
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static void string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;
        }


    }
}