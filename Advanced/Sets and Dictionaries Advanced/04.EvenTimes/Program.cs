using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            Console.WriteLine(numbers.Where(x => x.Value % 2 == 0).First().Key);
        }
    }
}
