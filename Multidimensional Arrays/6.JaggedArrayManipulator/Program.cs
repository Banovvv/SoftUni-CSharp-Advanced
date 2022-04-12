using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            #region Initialization
            int rows = int.Parse(Console.ReadLine());

            double[][] arrays = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] colArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                arrays[i] = new double[colArgs.Length];

                for (int j = 0; j < colArgs.Length; j++)
                {
                    arrays[i][j] = colArgs[j];
                }
            }
            #endregion

            // Modify based on adjesent row length
            #region Modification
            for (int i = 0; i < rows - 1; i++)
            {
                if (arrays[i].Length == arrays[i + 1].Length)
                {
                    for (int j = 0; j < arrays[i].Length; j++)
                    {
                        arrays[i][j] *= 2;
                        arrays[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < arrays[i].Length; j++)
                    {
                        arrays[i][j] /= 2;
                    }

                    for (int j = 0; j < arrays[i + 1].Length; j++)
                    {
                        arrays[i + 1][j] /= 2;
                    }
                }
            }
            #endregion

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);

                if (row < 0 || row >= rows || col < 0 || col >= arrays[row].Length)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (action == "Add")
                {
                    arrays[row][col] += value;
                }
                else if (action == "Subtract")
                {
                    arrays[row][col] -= value;
                }

                command = Console.ReadLine();
            }

            // Print the jagged array
            foreach (var array in arrays)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
