using NUnit.Framework;
using System;

namespace ExtendedDatabase.Tests
{
    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(0)]
        public void AddMethodShouldAddNewElementsWhileCountIsLessThanSixteen(int count)
        {
            ExtendedDatabase database = new ExtendedDatabase();

            for (int i = 0; i < count; i++)
            {
                database.Add(new Person(i, $"Person{i}"));
            }

            Assert.AreEqual(count, database.Count);
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenItemsAreAboveSixteen()
        {
            ExtendedDatabase database = new ExtendedDatabase();

            for (int i = 0; i < 16; i++)
            {
                database.Add(new Person(i, $"Person{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(17, "Person17")), "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(20)]
        [TestCase(25)]
        public void ConstructorShouldThrowExceptionWhenItemsAreAboveSixteen(int count)
        {
            Person[] people = new Person[count];

            for (int i = 0; i < count; i++)
            {
                people[i] = new Person(i, $"Person{i}");
            }

            Assert.Throws<ArgumentException>(() => new ExtendedDatabase(people));
        }
    }
}