using System;
using System.Linq;

namespace _5.SnakeMoves
{
    internal class Program
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string snake = Console.ReadLine();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            char[,] matrix = new char[rows, cols];

            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[col];
                    }
                }
                else
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[cols - col];
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
