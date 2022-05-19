using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main()
        {
            int[] clothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> delivery = new Stack<int>(clothes);

            int currentRack = rackCapacity;
            int currentCloth = 0;
            int rackCounter = 1;

            while (delivery.Count > 0)
            {
                currentCloth = delivery.Peek();
                if (currentRack >= currentCloth)
                {
                    currentRack -= currentCloth;
                    delivery.Pop();
                }
                else
                {
                    rackCounter++;
                    currentRack = rackCapacity;
                    
                }
            }

            Console.WriteLine(rackCounter);
        }
    }
}
