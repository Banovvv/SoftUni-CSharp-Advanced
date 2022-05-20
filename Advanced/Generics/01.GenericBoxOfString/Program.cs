using System;

namespace _01.GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>("TEST");
            Console.WriteLine(box);
        }
    }
}
