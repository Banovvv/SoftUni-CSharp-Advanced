using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _01.EvenLines
{
    internal class EvenLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\text.txt";

            ProcessLines(inputFilePath);
        }

        public static void ProcessLines(string inputFilePath)
        {
            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                List<string> lines = new List<string>();

                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }

                for (int i = 0; i < lines.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(ReverseWords(ReplaceSymbols(lines[i])));
                    }
                }
            }
        }
        private static string ReverseWords(string line)
        {
            string[] words = line.Split();
            Array.Reverse(words);

            return string.Join(" ", words);
        }

        private static string ReplaceSymbols(string line)
        {
            StringBuilder sb = new StringBuilder();

            List<string> symbolsToReplace = new List<string>() { "-", ",", ".", "!", "?" };

            for (int i = 0; i < line.Length; i++)
            {
                char currentChar = line[i];

                if (symbolsToReplace.Contains(currentChar.ToString()))
                {
                    currentChar = '@';
                }
                sb.Append(currentChar);
            }

            return sb.ToString();
        }
    }
}
