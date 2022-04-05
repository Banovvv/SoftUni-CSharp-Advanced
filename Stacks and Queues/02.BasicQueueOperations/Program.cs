using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    internal class Program
    {
        static void Main()
        {
            int[] nsx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int elementsToQueue = nsx[0];
            int elementsToDequeue = nsx[1];
            int elementToLookFor = nsx[2];

            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < elementsToQueue; i++)
			{
                numbers.Enqueue(elements[i]);
			}

            for (int i = 0; i < elementsToDequeue; i++)
			{
                numbers.Dequeue();
			}

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numbers.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
