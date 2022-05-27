using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stones = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            var lake = new Lake(stones);

            var stoneOrder = new List<int>();

            foreach (var stone in lake)
            {
                stoneOrder.Add(stone);
            }

            Console.WriteLine(string.Join(", ", stoneOrder));
        }
    }
}
