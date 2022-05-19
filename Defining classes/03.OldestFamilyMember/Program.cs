using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < numberOfMembers; i++)
            {
                string[] memberArgs = Console.ReadLine().Split();

                string memberName = memberArgs[0];
                int memberAge = int.Parse(memberArgs[1]);

                Person member = new Person(memberName, memberAge);

                family.AddMember(member);
            }

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

    public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age) : this()
        {
            Age = age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }

        public List<Person> Members { get; set; }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            return Members.Where(x => x.Age == Members.Max(x => x.Age)).FirstOrDefault();
        }
    }
}