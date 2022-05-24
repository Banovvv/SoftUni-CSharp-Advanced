using System;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] lineOne = Console.ReadLine().Split();
            var namesAddressTown = new Threeuple<string, string, string>(lineOne[0] + " " + lineOne[1], lineOne[2], lineOne[3]);

            string[] lineTwo = Console.ReadLine().Split();
            var nameBeerDrunk = new Threeuple<string, int, bool>(lineTwo[0], int.Parse(lineTwo[1]), lineTwo[2] == "drunk" ? true : false);

            string[] lineThree = Console.ReadLine().Split();
            var nameBalanceBank = new Threeuple<string, double, string>(lineThree[0], double.Parse(lineThree[1]), lineThree[2]);

            Console.WriteLine(namesAddressTown);
            Console.WriteLine(nameBeerDrunk);
            Console.WriteLine(nameBalanceBank);
        }
    }
}
