using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main()
        {
            int[] nsx = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int elementsToAdd = nsx[0];
            int elementsToPop = nsx[1];
            int elementToLookFor = nsx[2];

            var elements = Console.ReadLine().Split(' ');

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < elementsToAdd; i++)
            {
                int element = int.Parse(elements[i]);

                numbers.Push(element);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                numbers.Pop();
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
