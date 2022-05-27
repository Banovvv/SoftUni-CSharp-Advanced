using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> createCommand = Console.ReadLine().Split().ToList();

            ListyIterator<string> customList = new ListyIterator<string>(createCommand.Skip(1).ToList());

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (command == "HasNext")
                {
                    Console.WriteLine(customList.HasNext());
                }
                else if (command == "Move")
                {
                    Console.WriteLine(customList.Move());
                }
                else if (command == "Print")
                {
                    customList.Print();
                }
                else if (command == "PrintAll")
                {
                    customList.PrintAll();
                }
            }
        }
    }
}
