using System;

namespace StrangeAnimals
{
    public class Program
    {
        static void Main(string[] args)
        { 
            var animalNames = ConfigsDomain.GetWordsArrayFromFile("animals.json");
            var adjectives = ConfigsDomain.GetWordsArrayFromFile("adjectives.json");

            for(int i = 0; i < 500; i++)
            {
                if (i % 2 == 1)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.White;

                var name = NamesDomain.GenerateName(animalNames, adjectives);
                Console.WriteLine($"{name}\n");
            }

            Console.ReadLine();
        }
    }
}
