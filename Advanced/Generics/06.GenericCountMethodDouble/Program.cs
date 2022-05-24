using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<double> lines = new List<double>();

            for (int i = 0; i < numberOfLines; i++)
            {
                double value = double.Parse(Console.ReadLine());

                lines.Add(value);
            }

            double compareTo = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(lines);

            Console.WriteLine(box.CountEqualElements(compareTo));
        }
    }
}
