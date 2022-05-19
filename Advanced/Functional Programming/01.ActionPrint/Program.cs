using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<List<string>> action = PrintList;

            action(words);
        }

        static void PrintList(List<string> words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
