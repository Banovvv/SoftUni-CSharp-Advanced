using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    internal class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\text.txt";
            string outputPath = @"..\..\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] inputLines = File.ReadAllLines(inputFilePath);
            string[] outputLines = new string[inputLines.Length];

            for (int i = 1; i <= inputLines.Length; i++)
            {
                int lettersCount = inputLines[i - 1].Where(x => char.IsLetter(x)).Count();
                int puncuationCount = inputLines[i - 1].Where(x => char.IsPunctuation(x)).Count();

                outputLines[i - 1] = $"Line {i}: {inputLines[i - 1]} ({lettersCount})({puncuationCount})";
            }

            File.WriteAllLines(outputFilePath, outputLines);
        }
    }
}
