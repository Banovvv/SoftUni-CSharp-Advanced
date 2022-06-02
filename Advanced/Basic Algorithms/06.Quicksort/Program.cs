using System;
using System.Linq;

namespace _06.Quicksort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            QuickSort.Sort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }

    public class QuickSort
    {
        public static void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int low, int high)
        {
            int localPivot = 0;

            if (low < high)
            {
                localPivot = Partition(array, low, high);
                Sort(array, low, localPivot - 1);
                Sort(array, localPivot + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);

            return i + 1;
        }

        private static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
