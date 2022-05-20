using System;

namespace _02.GenericBoxOfInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                int value = int.Parse(Console.ReadLine());

                var box = new Box<int>(value);

                Console.WriteLine(box);
            }
        }
    }
}
