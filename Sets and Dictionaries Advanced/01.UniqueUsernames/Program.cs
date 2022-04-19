using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfUsernames = int.Parse(Console.ReadLine());

            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < numberOfUsernames; i++)
            {
                string username = Console.ReadLine();

                usernames.Add(username);
            }

            foreach (string username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
