using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main()
        {
            int[] delivery = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>();
            
            for (int i = 0; i < delivery.Count(); i++)
			{
                clothes.Push(delivery[i]);
			}

            int racks = 1;

            while (clothes.Count > 0)
            {
                int currentRack = 0;

                while (capacity >= currentRack && clothes.Count > 0)
                {
		           currentRack += clothes.Pop(); 
                }

                racks++;
            }

            Console.WriteLine(racks);
        }
    }
}
