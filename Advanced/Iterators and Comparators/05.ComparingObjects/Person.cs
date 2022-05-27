using System;
using System.Diagnostics.CodeAnalysis;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo([AllowNull] Person other)
        {
            if (Name.CompareTo(other.Name) > 0)
            {
                return 1;
            }
            else if (Name.CompareTo(other.Name) < 0)
            {
                return -1;
            }
            else
            {
                if (Age > other.Age)
                {
                    return 1;
                }
                else if (Age < other.Age)
                {
                    return -1;
                }
                else
                {
                    if (Town.CompareTo(other.Town) > 0)
                    {
                        return 1;
                    }
                    else if (Town.CompareTo(other.Town) < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
