using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main()
        {
            int endOfRange = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Predicate<Tuple<int, int>> predicate = x => x.Item1 % x.Item2 == 0;
            Func<int, int[], Predicate<Tuple<int, int>>,List<int>> func = FindDivisibles;

            Console.WriteLine(string.Join(" ", func(endOfRange, dividers, predicate)));
        }

        private static List<int> FindDivisibles(int endOfRange, int[] dividers, Predicate<Tuple<int, int>> predicate)
        {
            List<int> result = new List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                bool isDivisible = false;

                foreach(int divider in dividers)
                {
                    if (predicate(new Tuple<int, int>(i, divider)))
                    {
                        isDivisible = true;
                    }
                    else
                    {
                        isDivisible = false;
                    }
                }

                if (isDivisible)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
