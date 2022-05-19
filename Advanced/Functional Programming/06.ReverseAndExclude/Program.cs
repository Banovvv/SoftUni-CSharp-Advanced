using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());

            Predicate<int> predicate = x => x % divider == 0;
            Func<List<int>, Predicate<int>, List<int>> func = ReverseAndExclude;

            Console.WriteLine(string.Join(" ", func(numbers, predicate)));
        }

        static List<int> ReverseAndExclude(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (!predicate(number))
                {
                    newNumbers.Add(number);
                }
            }

            newNumbers.Reverse();

            return newNumbers;
        }
    }
}
