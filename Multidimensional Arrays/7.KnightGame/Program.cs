using System;

namespace _7.KnightGame
{
    internal class Program
    {
        static void Main()
        {
            int boardSize = int.Parse(Console.ReadLine());

            char[,] board = new char[boardSize, boardSize];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                string colArgs = Console.ReadLine();

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = colArgs[col];
                }
            }

            // Shortcut for when the board is too small for the knight to move
            if (boardSize < 3)
            {
                Console.WriteLine(0);
                return;
            }

            int maxNumberOfAttacks = 0;
            int[] knightCoordinates = new int[2];
            int knightsRemoved = 0;

            while (true)
            {
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int numberOfAtacks = 0;

                        // All possible knight moves
                        if (board[row, col] == 'K')
                        {
                            if (IsInRange(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                            {
                                numberOfAtacks++;
                            }

                            if (IsInRange(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                            {
                                numberOfAtacks++;
                            }

                            if (IsInRange(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                            {
                                numberOfAtacks++;
                            }

                            if (IsInRange(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                            {
                                numberOfAtacks++;
                            }

                            if (IsInRange(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                            {
                                numberOfAtacks++;
                            }

                            if (IsInRange(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                            {
                                numberOfAtacks++;
                            }

                            if (IsInRange(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                            {
                                numberOfAtacks++;
                            }

                            if (IsInRange(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                            {
                                numberOfAtacks++;
                            }
                        }

                        if (numberOfAtacks > maxNumberOfAttacks)
                        {
                            maxNumberOfAttacks = numberOfAtacks;
                            knightCoordinates[0] = row;
                            knightCoordinates[1] = col;
                        }
                    }
                }

                if (maxNumberOfAttacks > 0)
                {
                    board[knightCoordinates[0], knightCoordinates[1]] = '0';
                    knightsRemoved++;
                    maxNumberOfAttacks = 0;
                }
                else
                {
                    // If there are no more possibe knight moves, end the while loop
                    break;
                }
            }

            Console.WriteLine(knightsRemoved);
        }

        static bool IsInRange(char[,] board, int row, int col)
        {
            return row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
        }
    }
}
