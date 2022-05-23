using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();   

            for (int i = 0; i < numberOfLines; i++)
            {
                string value = Console.ReadLine();

                var box = new Box<string>(value);

                boxes.Add(box);
            }

            int[] indices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(boxes, indices);

            foreach (Box<string> box in boxes)
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
