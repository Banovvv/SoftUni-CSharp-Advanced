using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetCharSum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> lengthFunc = CheckLength;
            Func<Func<string, int, bool>, List<string>, int, string> nameFunc = GetName;

            Console.WriteLine(nameFunc(lengthFunc, names, targetCharSum));
        }

        private static string GetName(Func<string, int, bool> lengthFunc, List<string> names, int targetCharSum) => names.Where(x => lengthFunc(x, targetCharSum)).First();

        private static bool CheckLength(string word, int targetCharSum)
        {
            int charSum = 0;

            foreach (char letter in word)
            {
                charSum += letter;
            }

            return charSum >= targetCharSum;
        }
    }
}
