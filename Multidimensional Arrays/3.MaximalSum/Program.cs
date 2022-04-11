using System;
using System.Linq;

namespace _3.MaximalSum
{
    internal class Program
    {
        static void Main()
        {
            string[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] colArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colArgs[col];
                }
            }

            int maxSum = int.MinValue;
            int[] startIndex = { 0, 0 };
            int squareSize = 3;

            for (int row = 0; row < rows - squareSize + 1; row++)
            {
                for (int col = 0; col < cols - squareSize + 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startIndex[0] = row;
                        startIndex[1] = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = 0; row < squareSize; row++)
            {
                for (int col = 0; col < squareSize; col++)
                {
                    Console.Write($"{matrix[startIndex[0] + row, startIndex[1] + col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
