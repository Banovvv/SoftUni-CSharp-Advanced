using System;
using System.Diagnostics.CodeAnalysis;

namespace _06.EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name.ToLowerInvariant(); // to make sure that John == john
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

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
                return Age.CompareTo(other.Age);
            }
        }
        public override bool Equals(object obj)
        {
            Person other = obj as Person;

            if (Name == other.Name && Age == other.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }
}
