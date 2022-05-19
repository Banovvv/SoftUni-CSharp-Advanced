using System;
using System.Linq;

namespace _2.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = matrixArgs[0];
            int cols = matrixArgs[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] colArgs = Console.ReadLine().Split();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colArgs[col];
                }
            }

            int squaresCount = 0;
            int squareSize = 2;

            for (int row = 0; row < rows - squareSize + 1; row++)
            {
                for (int col = 0; col < cols - squareSize + 1; col++)
                {
                    if(matrix[row, col] == matrix[row, col+1] && matrix[row+1, col] == matrix[row+1, col+1] && matrix[row, col] == matrix[row+1, col+1])
                    {
                        squaresCount++;
                    }
                }
            }

            Console.WriteLine(squaresCount);
        }
    }
}
