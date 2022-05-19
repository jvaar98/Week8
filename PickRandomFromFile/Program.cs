using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomMovie, randomDrink;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");

            Console.WriteLine($"Täna sa sööd {randomFood}, ning selle kõrvale jood {randomDrink} ning samal ajal vaatada {randomMovie}");


            string filePath = @"/Users/jaagupvaar/Desktop/foods.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);

        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"/Users/jaagupvaar/Desktop/{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];
            return randomElement;

        }

    }
}