using System;
using System.Linq;

namespace _06.Quicksort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            QuickSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
        static void QuickSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int low = i;
                int minNumber = int.MaxValue;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i] && array[j] < minNumber)
                    {
                        low = j;
                        minNumber = array[j];
                    }
                }

                SwapValues(array, low, i);
            }
        }

        static void SwapValues(int[] array, int low, int high)
        {
            int temp = array[low];
            array[low] = array[high];
            array[high] = temp;
        }
    }

    public class QuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {

        }

        private static void SwapValues<T>(T[] array, int low, int high)
        {

        }
    }
}
