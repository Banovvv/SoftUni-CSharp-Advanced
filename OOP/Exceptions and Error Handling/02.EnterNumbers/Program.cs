using System;

namespace _02.EnterNumbers
{
    public class Program
    {
        private static int start = 1;
        private static readonly int end = 100;

        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                start = ReadNumbers(start, end);

                if (start != 0)
                {
                    numbers[i - 1] = start;
                }
                else
                {
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static int ReadNumbers(int start, int end)
        {
            string input = Console.ReadLine();

            try
            {
                int n = int.Parse(input);
                if (!(start < n && n < end))
                {
                    while (!(start < n && n < end))
                    {
                        Console.WriteLine($"Your number is not in range {start} - {end}!");
                        n = int.Parse(Console.ReadLine());
                    }
                }

                return n;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }

            return 0;
        }
    }
}
