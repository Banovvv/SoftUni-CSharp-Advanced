using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Peter";
            person.Age = 20;
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
