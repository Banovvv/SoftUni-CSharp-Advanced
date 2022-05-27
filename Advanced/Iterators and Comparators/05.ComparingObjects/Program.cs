using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] personInfo = Console.ReadLine().Split();

                if (personInfo.First() == "END")
                {
                    break;
                }

                people.Add(new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]));
            }

            int index = int.Parse(Console.ReadLine());

            Person personToCompareWith = people[index - 1];

            int matches = 0;

            foreach(Person person in people.Where(x=>x != personToCompareWith))
            {
                if(personToCompareWith.CompareTo(person) == 0)
                {
                    matches++;
                }
            }

            if (matches > 0)
            {
                Console.WriteLine($"{matches + 1} {people.Count - (matches + 1)} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
