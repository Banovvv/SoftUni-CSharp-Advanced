using System;

namespace _05.DateModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            DateModifier modifier = new DateModifier(dateOne, dateTwo);

            Console.WriteLine(modifier.DateDifference());
        }
    }

    public class DateModifier
    {
        public DateModifier(string dateOne, string dateTwo)
        {
            string[] dateOneArgs = dateOne.Split();
            string[] dateTwoArgs = dateTwo.Split();

            DateOne = new DateTime(int.Parse(dateOneArgs[0]), int.Parse(dateOneArgs[1]), int.Parse(dateOneArgs[2]));
            DateTwo = new DateTime(int.Parse(dateTwoArgs[0]), int.Parse(dateTwoArgs[1]), int.Parse(dateTwoArgs[2]));
        }

        public DateTime DateOne { get; set; }
        public DateTime DateTwo { get; set; }

        public int DateDifference()
        {
            if(DateOne > DateTwo)
            {
                return (DateOne - DateTwo).Days;
            }
            else
            {
                return (DateTwo - DateOne).Days;
            }
        }
    }
}
