using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] setLengts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> firstSet = new List<int>();
            List<int> secondSet = new List<int>();

            HashSet<int> uniqueRepeatingNumbers = new HashSet<int>();

            for (int i = 0; i < setLengts[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < setLengts[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int i in firstSet)
            {
                if (secondSet.Contains(i))
                {
                    uniqueRepeatingNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", uniqueRepeatingNumbers));
        }
    }
}
