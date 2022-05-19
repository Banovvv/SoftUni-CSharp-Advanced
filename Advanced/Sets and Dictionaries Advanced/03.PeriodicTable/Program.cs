using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main()
        {
            int countOfElements = int.Parse(Console.ReadLine());

            SortedSet<string> periodicTable = new SortedSet<string>();

            for (int i = 0; i < countOfElements; i++)
            {
                string[] elements = Console.ReadLine().Split();

                foreach (string element in elements)
                {
                    periodicTable.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
