using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main()
        {
            string[] lineOne = Console.ReadLine().Split();
            Tuple<string, string> nameAndAddress = new Tuple<string, string>(lineOne[0] + " " + lineOne[1], lineOne[2]);

            string[] lineTwo = Console.ReadLine().Split();
            Tuple<string, int> nameAndLiters = new Tuple<string, int>(lineTwo[0], int.Parse(lineTwo[1]));

            string[] lineThree = Console.ReadLine().Split();
            Tuple<int, double> intAndDouble = new Tuple<int, double>(int.Parse(lineThree[0]), double.Parse(lineThree[1]));

            Console.WriteLine(nameAndAddress);
            Console.WriteLine(nameAndLiters);
            Console.WriteLine(intAndDouble);
        }
    }
}
