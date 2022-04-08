using System;
using System.Linq;

namespace _1.DiagonalDifference
{
    internal class Program
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] numbers = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] lineNumns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    numbers[row, col] = lineNumns[col];
                }
            }

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                firstDiagonalSum += numbers[i, i]; // 0, 0 > 1,1> 2,2
                secondDiagonalSum += numbers[i, matrixSize - 1 - i]; // 0, 2 > 1, 1 > 2, 0
            }

            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}
