using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Func<int[], int> func = FindMin;

            Console.WriteLine(func(numbers));
        }

        static int FindMin(int[] numbers)
        {
            return numbers.Min(x => x);
        }
    }
}
