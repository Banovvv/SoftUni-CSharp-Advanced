using System;
using System.Linq;

namespace _07.BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int key = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch.IndexOf(numbers, key));
        }
    }

    public class BinarySearch
    {
        public static int IndexOf(int[] array, int key)
        {
            int center = 0 + (array.Length - 0) / 2;

            if (key < array[center])
            {
                for (int i = 0; i <= center; i++)
                {
                    if(array[i] == key)
                    {
                        return i;
                    }
                }
            }
            else if (key > array[center])
            {
                for (int i = center; i < array.Length - 1; i++)
                {
                    if(array[i] == key)
                    {
                        return i;
                    }
                }
            }
            else
            {
                return center;
            }

            return -1;
        }
    }
}
