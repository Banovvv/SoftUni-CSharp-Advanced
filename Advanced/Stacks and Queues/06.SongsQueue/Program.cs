using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main()
        {
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Queue<string> playlist = new Queue<string>();

            foreach (string song in songs)
            {
                playlist.Enqueue(song);
            }

            while (playlist.Count > 0)
            {
                List<string> commandArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string command = commandArgs[0];

                if (command == "Play")
                {
                    Play(playlist);
                }
                else if (command == "Add")
                {
                    commandArgs.RemoveAt(0);

                    string song = string.Join(" ", commandArgs);

                    Add(playlist, song);
                }
                else if (command == "Show")
                {
                    Show(playlist);
                }
            }

            Console.WriteLine("No more songs!");
        }

        static void Play(Queue<string> playlist)
        {
            playlist.Dequeue();
        }

        static void Add(Queue<string> playlist, string song)
        {
            if (!playlist.Contains(song))
            {
                playlist.Enqueue(song);
            }
            else
            {
                Console.WriteLine($"{song} is already contained!");
            }
        }

        static void Show(Queue<string> playlist)
        {
            Console.WriteLine(string.Join(", ", playlist));
        }
    }
}
