using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EvenLines
{
    internal class EvenLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader sr = new StreamReader(inputFilePath);
            string contents = sr.ReadToEnd();

            string[] lines = contents.Split(new string[] { @"\r\n" }, StringSplitOptions.RemoveEmptyEntries);



            return sr.ReadToEnd();
        }
        private static string ReverseWords(string replacedSymbols)
        {
            throw new NotImplementedException();
        }

        private static string ReplaceSymbols(string line)
        {
            throw new NotImplementedException();
        }
    }
}
