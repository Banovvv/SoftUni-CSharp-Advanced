using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    internal class Program
    {
        static void Main()
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orderQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>();

            for (int i = 0; i < orderQuantity.Length; i++)
			{
                orders.Enqueue(orderQuantity[i]);
			}

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (foodQuantity - orders.Peek() >= 0)
                {
                    foodQuantity -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
