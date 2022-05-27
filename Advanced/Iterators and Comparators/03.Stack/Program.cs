using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> createCommand = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Stack<string> customStack = new Stack<string>(createCommand.Skip(1).ToArray());

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (command.Contains("Push"))
                {
                    customStack.Push(command.Split().Last());
                }
                else if (command == "Pop")
                {
                    customStack.Pop();
                }
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
