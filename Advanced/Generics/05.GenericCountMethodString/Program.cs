using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<string> lines = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string value = Console.ReadLine();

                lines.Add(value);
            }

            string compareTo = Console.ReadLine();

            Box<string> box = new Box<string>(lines);

            Console.WriteLine(box.CountEqualElements(compareTo));
        }
    }
}
