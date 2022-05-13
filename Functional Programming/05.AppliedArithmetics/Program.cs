using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, List<int>> func;

            string commnad = Console.ReadLine();

            while(commnad != "end")
            {
                if(commnad == "add")
                {
                    func = Add;

                    numbers = func(numbers);
                }
                else if(commnad == "subtract")
                {
                    func = Subtract;

                    numbers = func(numbers);
                }
                else if (commnad == "multiply")
                {
                    func = Multiply;

                    numbers = func(numbers);
                }
                else if (commnad == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }

                commnad = Console.ReadLine();
            }
        }

        static List<int> Add(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                result.Add(number + 1);
            }

            return result;
        }

        static List<int> Subtract(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                result.Add(number - 1);
            }

            return result;
        }

        static List<int> Multiply(List<int> numbers)
        {
            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                result.Add(number * 2);
            }

            return result;
        }
    }
}
