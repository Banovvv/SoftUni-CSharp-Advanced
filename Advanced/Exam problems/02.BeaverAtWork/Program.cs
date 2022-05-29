using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BeaverAtWork
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[,] pond = new string[n, n];
            int totalBranches = 0;
            Beaver beaver = new Beaver();

            for (int row = 0; row < n; row++)
            {
                string[] pondAgrs = Console.ReadLine().Split();

                for (int col = 0; col < n; col++)
                {
                    pond[row, col] = pondAgrs[col];

                    if(pondAgrs[col] == "B")
                    {
                        beaver.X = row;
                        beaver.Y = col;
                    }

                    if (pondAgrs[col] != "B" && pondAgrs[col] != "F" && pondAgrs[col] != "-")
                    {
                        totalBranches++;
                    }
                }
            }

            List<char> collectedBranches = new List<char>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end" || totalBranches == 0)
                {
                    break;
                }

                if(command == "up")
                {
                    if(beaver.X - 1 < 0)
                    {
                        if (collectedBranches.Any())
                        {
                            collectedBranches.RemoveAt(collectedBranches.Count - 1);
                        }
                    }
                    else
                    {
                        pond[beaver.X, beaver.Y] = "-";
                        beaver.MoveUp();

                        char newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                        if (char.IsLower(newPosition))
                        {
                            collectedBranches.Add(newPosition);
                            totalBranches--;

                            pond[beaver.X, beaver.Y] = "B";
                        }
                        else if (newPosition == 'F')
                        {
                            pond[beaver.X, beaver.Y] = "-";

                            if (beaver.X != 0)
                            {
                                beaver.X = 0;

                                newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                                if (char.IsLower(newPosition))
                                {
                                    collectedBranches.Add(newPosition);
                                    totalBranches--;
                                }

                                pond[beaver.X, beaver.Y] = "B";
                            }
                            else
                            {
                                beaver.X = pond.GetLength(0) - 1;

                                newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                                if (char.IsLower(newPosition))
                                {
                                    collectedBranches.Add(newPosition);
                                    totalBranches--;
                                }

                                pond[beaver.X, beaver.Y] = "B";
                            }
                        }
                    }
                }
                else if (command == "down")
                {
                    if (beaver.X + 1 > pond.GetLength(0) - 1)
                    {
                        if (collectedBranches.Any())
                        {
                            collectedBranches.RemoveAt(collectedBranches.Count - 1);
                        }
                    }
                    else
                    {
                        pond[beaver.X, beaver.Y] = "-";
                        beaver.MoveDown();

                        char newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                        if (char.IsLower(newPosition))
                        {
                            collectedBranches.Add(newPosition);
                            totalBranches--;

                            pond[beaver.X, beaver.Y] = "B";
                        }
                        else if (newPosition == 'F')
                        {
                            pond[beaver.X, beaver.Y] = "-";

                            if (beaver.X != pond.GetLength(0) - 1)
                            {
                                beaver.X = pond.GetLength(0) - 1;

                                newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                                if (char.IsLower(newPosition))
                                {
                                    collectedBranches.Add(newPosition);
                                    totalBranches--;
                                }

                                pond[beaver.X, beaver.Y] = "B";
                            }
                            else
                            {
                                beaver.X = 0;

                                newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                                if (char.IsLower(newPosition))
                                {
                                    collectedBranches.Add(newPosition);
                                    totalBranches--;
                                }

                                pond[beaver.X, beaver.Y] = "B";
                            }
                        }
                    }
                }
                else if (command == "left")
                {
                    if (beaver.Y - 1 < 0)
                    {
                        if (collectedBranches.Any())
                        {
                            collectedBranches.RemoveAt(collectedBranches.Count - 1);
                        }
                    }
                    else
                    {
                        pond[beaver.X, beaver.Y] = "-";
                        beaver.MoveLeft();

                        char newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                        if (char.IsLower(newPosition))
                        {
                            collectedBranches.Add(newPosition);
                            totalBranches--;

                            pond[beaver.X, beaver.Y] = "B";
                        }
                        else if (newPosition == 'F')
                        {
                            pond[beaver.X, beaver.Y] = "-";

                            if (beaver.Y != 0)
                            {
                                beaver.Y = 0;

                                newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                                if (char.IsLower(newPosition))
                                {
                                    collectedBranches.Add(newPosition);
                                    totalBranches--;
                                }

                                pond[beaver.X, beaver.Y] = "B";
                            }
                            else
                            {
                                beaver.Y = pond.GetLength(0) - 1;

                                newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                                if (char.IsLower(newPosition))
                                {
                                    collectedBranches.Add(newPosition);
                                    totalBranches--;
                                }

                                pond[beaver.X, beaver.Y] = "B";
                            }
                        }
                    }
                }
                else if (command == "right")
                {
                    if (beaver.Y + 1 > pond.GetLength(0) - 1)
                    {
                        if (collectedBranches.Any())
                        {
                            collectedBranches.RemoveAt(collectedBranches.Count - 1);
                        }
                    }
                    else
                    {
                        pond[beaver.X, beaver.Y] = "-";
                        beaver.MoveRigth();

                        char newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                        if (char.IsLower(newPosition))
                        {
                            collectedBranches.Add(newPosition);
                            totalBranches--;

                            pond[beaver.X, beaver.Y] = "B";
                        }
                        else if (newPosition == 'F')
                        {
                            pond[beaver.X, beaver.Y] = "-";

                            if (beaver.Y != pond.GetLength(0) - 1)
                            {
                                beaver.Y = pond.GetLength(0) - 1;

                                newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                                if (char.IsLower(newPosition))
                                {
                                    collectedBranches.Add(newPosition);
                                    totalBranches--;
                                }

                                pond[beaver.X, beaver.Y] = "B";
                            }
                            else
                            {
                                beaver.Y = 0;

                                newPosition = pond[beaver.X, beaver.Y].ToCharArray().First();

                                if (char.IsLower(newPosition))
                                {
                                    collectedBranches.Add(newPosition);
                                    totalBranches--;
                                }

                                pond[beaver.X, beaver.Y] = "B";
                            }
                        }
                    }
                }
            }

            var remainingBranches = GetRemainingBranches(pond);

            if (remainingBranches.Any())
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {remainingBranches.Count} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {collectedBranches.Count} wood branches: {(string.Join(", ", collectedBranches))}.");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{pond[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        static List<string> GetRemainingBranches(string[,] pond)
        {
            List<string> remainingBranches = new List<string>();

            for (int row = 0; row < pond.GetLength(0); row++)
            {
                for (int col = 0; col < pond.GetLength(1); col++)
                {
                    if(pond[row, col] != "B" && pond[row, col] != "F" && pond[row, col] != "-")
                    {
                        remainingBranches.Add(pond[row, col]);
                    }
                }
            }

            return remainingBranches;
        }
    }

    public class Beaver
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void MoveUp()
        {
            X -= 1;
        }

        public void MoveDown()
        {
            X += 1;
        }

        public void MoveLeft()
        {
            Y -= 1;
        }

        public void MoveRigth()
        {
            Y += 1;
        }
    }

}
