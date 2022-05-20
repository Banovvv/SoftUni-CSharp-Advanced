using System;

namespace _01.GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string value = Console.ReadLine();

                var box = new Box<string>(value);

                Console.WriteLine(box);
            }
        }
    }
}
