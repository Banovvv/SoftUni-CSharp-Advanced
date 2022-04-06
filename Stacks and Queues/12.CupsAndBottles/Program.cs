using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            Queue<int> cups = new Queue<int>(inputCups);
            Stack<int> bottles = new Stack<int>(inputBottles);

            int currentCup = 0;
            bool isEmpty = true;
            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                if (isEmpty)
                {
                    currentCup = cups.Peek();
                    isEmpty = false;
                }

                int currentBottle = bottles.Pop();

                if (currentCup - currentBottle <= 0)
                {
                    wastedWater += Math.Abs(currentCup - currentBottle);
                    cups.Dequeue();
                    isEmpty = true;
                }
                else
                {
                    currentCup -= currentBottle;
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
