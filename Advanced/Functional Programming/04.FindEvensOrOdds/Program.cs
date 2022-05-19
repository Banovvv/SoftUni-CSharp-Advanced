using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> bounds = Console.ReadLine().Split().Select(int.Parse).ToList();
            string condition = Console.ReadLine();

            Console.WriteLine(string.Join(" ", ListNumbers(bounds, condition)));
        }

        static List<int> ListNumbers(List<int> list, string condition)
        {
            List<int> newList = new List<int>();

            Predicate<int> predicate = FindPredicate(condition);


            if (predicate != null)
            {
                for (int i = list.First(); i <= list.Last(); i++)
                {
                    if (predicate(i))
                    {
                        newList.Add(i);
                    }
                }
            }

            return newList;
        }

        private static Predicate<int> FindPredicate(string condition)
        {
            if (condition == "even")
            {
                return IsEven;
            }
            else if (condition == "odd")
            {
                return IsOdd;
            }

            return null;
        }
        static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
    }
}
