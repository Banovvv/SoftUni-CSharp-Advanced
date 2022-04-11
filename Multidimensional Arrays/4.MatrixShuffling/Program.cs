using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    internal class Program
    {
        static void Main()
        {
            #region Initialization
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] colArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colArgs[col];
                }
            }
            #endregion

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "swap" && commandArgs.Length == 5)
                {
                    int rowOne = int.Parse(commandArgs[1]);
                    int colOne = int.Parse(commandArgs[2]);
                    int rowTwo = int.Parse(commandArgs[3]);
                    int colTwo = int.Parse(commandArgs[4]);

                    if (rowOne < 0 || rowOne > rows - 1 || rowTwo < 0 || rowTwo > rows - 1 ||
                        colOne < 0 || colOne > cols - 1 || colTwo < 0 || colTwo > cols - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string temp = matrix[rowOne, colOne];
                        matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                        matrix[rowTwo, colTwo] = temp;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }

                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
