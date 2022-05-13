using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Predicate<string> predicate = x => x.Length <= length;
            Action<List<string>, Predicate<string>> func = CheckLength;

            func(names, predicate);
        }

        static void CheckLength(List<string> names, Predicate<string> predicate)
        {

            foreach (string name in names)
            {
                if (predicate(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
