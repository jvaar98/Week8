using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomJoke;
            randomJoke = GetRandomFromFile("chuck.txt");

            Console.WriteLine($"Üks Chuck N naljadest kõlab :{randomJoke} .");

            string filePath = @"/Users/jaagupvaar/Desktop/chuck.txt";

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
