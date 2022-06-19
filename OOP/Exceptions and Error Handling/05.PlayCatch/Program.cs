using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PlayCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exceptionCount = 0;

            while (exceptionCount < 3)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];

                try
                {

                    if (command == "Replace")
                    {
                        int index = int.Parse(commandArgs[1]);
                        string element = commandArgs[2];

                        Replace(array, index, element);
                    }
                    else if (command == "Print")
                    {
                        int startIndex = int.Parse(commandArgs[1]);
                        int endIndex = int.Parse(commandArgs[2]);

                        Print(array, startIndex, endIndex);
                    }
                    else if (command == "Show")
                    {
                        int index = int.Parse(commandArgs[1]);

                        Show(array, index);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }

        private static void Replace(int[] array, int index, string element)
        {
            if (index < 0 || index > array.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            if (!int.TryParse(element, out int elementToInsert))
            {
                throw new FormatException();
            }

            array[index] = elementToInsert;
        }

        private static void Print(int[] array, int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex > array.Length - 1 || endIndex < 0 || endIndex > array.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            IList<int> arrayToPrint = new List<int>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                arrayToPrint.Add(array[i]);
            }

            Console.WriteLine(string.Join(", ", arrayToPrint));
        }

        private static void Show(int[] array, int index)
        {
            if (index < 0 || index > array.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            Console.WriteLine(array[index]);
        }
    }
}
