using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main()
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            Stack<string> commandsDone = new Stack<string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string command = commandArgs[0];

                if (command == "1")
                {
                    commandsDone.Push(sb.ToString());

                    string input = commandArgs[1];

                    sb.Append(input);
                }
                else if (command == "2")
                {
                    commandsDone.Push(sb.ToString());

                    int toErase = int.Parse(commandArgs[1]);

                    while (toErase > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        toErase--;
                    }
                }
                else if (command == "3")
                {
                    int index = int.Parse(commandArgs[1]) - 1;

                    Console.WriteLine(sb.ToString().ElementAt(index));
                }
                else if (command == "4")
                {
                    sb.Clear();
                    sb.Append(commandsDone.Pop());
                }
            }
        }
    }
}
