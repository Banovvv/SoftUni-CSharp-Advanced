using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> characters = new SortedDictionary<char, int>();

            foreach (char c in input)
            {
                if (!characters.ContainsKey(c))
                {
                    characters.Add(c, 0);
                }

                characters[c]++;
            }

            foreach (var character in characters)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
