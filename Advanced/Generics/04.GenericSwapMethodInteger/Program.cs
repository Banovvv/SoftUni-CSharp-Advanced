using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                int value = int.Parse(Console.ReadLine());

                var box = new Box<int>(value);

                boxes.Add(box);
            }

            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(boxes, indices);

            foreach (Box<int> box in boxes)
            {
                Console.WriteLine(box);
            }
        }

        static void Swap<T>(List<T> list, int[] indices)
        {
            var tempItem = list[indices[0]];
            list[indices[0]] = list[indices[1]];
            list[indices[1]] = tempItem;
        }
    }
}
