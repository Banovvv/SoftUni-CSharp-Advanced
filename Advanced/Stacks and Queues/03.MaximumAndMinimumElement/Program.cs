using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main()
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] commandArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int command = commandArgs[0];

                if (command == 1)
                {
                    stack.Push(commandArgs[1]);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (command == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
