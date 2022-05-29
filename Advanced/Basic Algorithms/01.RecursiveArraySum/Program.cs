using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Sum(array, 0));
        }

        static int Sum(int[] array, int index)
        {
            if (index == array.Length)
            {
                return 0;
            }

            int result = Sum(array, index + 1);

            return array[index] + result;
        }
    }
}
