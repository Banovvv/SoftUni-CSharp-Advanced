using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>> action = PrintNames;

            action(names);
        }
        static void PrintNames(List<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
