using System;
using System.Collections.Generic;

namespace _06.EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
            HashSet<Person> peopleHashSet = new HashSet<Person>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] personArgs = Console.ReadLine().Split();
                
                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                peopleSortedSet.Add(new Person(name, age));
                peopleHashSet.Add(new Person(name, age));
            }

            Console.WriteLine(peopleSortedSet.Count);
            Console.WriteLine(peopleHashSet.Count);
        }
    }
}
