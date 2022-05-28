using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();

            array.Sort(new IntegerComparator());

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
