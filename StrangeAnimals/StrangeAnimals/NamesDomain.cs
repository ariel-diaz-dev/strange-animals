using System;
using System.Collections.Generic;

namespace StrangeAnimals
{
    public static class NamesDomain
    {
        static public String GenerateName(List<String> nouns, List<String> adjectives)
        {
            var random = new Random();

            var animalName = nouns[random.Next(nouns.Count - 1)];
            var adjective1 = adjectives[random.Next(adjectives.Count - 1)];
            var adjective2 = adjectives[random.Next(adjectives.Count - 1)];
            var name = adjective1 + adjective2 + animalName;

            return name;
        }
    }
}
