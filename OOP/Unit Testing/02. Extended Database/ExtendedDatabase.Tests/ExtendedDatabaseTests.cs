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

        [TestCase(1, "Person1")]
        [TestCase(20, "Person20")]
        public void AddMethodShouldThrowExceptionWhenUsernameAlreadyExists(long id, string username)
        {
            ExtendedDatabase database = new ExtendedDatabase();
            database.Add(new Person(id, username));

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(id, username)), "There is already user with this username!");
        }

        [TestCase(1, "Person1")]
        [TestCase(20, "Person20")]
        public void AddMethodShouldThrowExceptionWhenIdAlreadyExists(long id, string username)
        {
            ExtendedDatabase database = new ExtendedDatabase();
            database.Add(new Person(id, username));

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(id, username)), "There is already user with this Id!");
        }

        [Test]
        public void RemoveShouldThrowExcetionWhenCountIsZero()
        {
            ExtendedDatabase database = new ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [TestCase(1, 1)]
        [TestCase(15, 5)]
        public void RemoveShouldWorkWhenCountIsAboveZero(long count, int toRemove)
        {
            ExtendedDatabase database = new ExtendedDatabase();

            for (int i = 0; i < count; i++)
            {
                database.Add(new Person(i, $"Person{i}"));
            }

            for (int i = 0; i < toRemove; i++)
            {
                database.Remove();
            }

            Assert.AreEqual(count - toRemove, database.Count);
        }

        [TestCase(null)]
        [TestCase("")]
        public void FindByUsernameShouldThrowExceptionForNullOrEmptyString(string username)
        {
            ExtendedDatabase database = new ExtendedDatabase();

            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(username), "Username parameter is null!");
        }

        [TestCase("NqmaMe")]
        [TestCase("NotPresent")]
        public void FindByUsernameShouldThrowExceptionWhenUsernameIsNotPresent(string username)
        {
            ExtendedDatabase database = new ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => database.FindByUsername(username), "No user is present by this username!");
        }

        [TestCase(1, "Person")]
        public void FindByUsernameShouldWorkWhenUsernameIsPresent(long id, string username)
        {
            ExtendedDatabase database = new ExtendedDatabase();
            database.Add(new Person(id, username));

            Assert.AreNotEqual(null, database.FindByUsername(username));
        }

        [TestCase(-1)]
        [TestCase(-99)]
        [TestCase(-9999999999)]
        public void FindByIdShouldThrowExceptionWhenIdIsBelowZero(long id)
        {
            ExtendedDatabase database = new ExtendedDatabase();

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id), "Id should be a positive number!");
        }

        [TestCase(1)]
        [TestCase(99)]
        [TestCase(9999999999)]
        public void FindByIdShouldThrowExceptionWhenIdIsNotPresent(long id)
        {
            ExtendedDatabase database = new ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() => database.FindById(id), "No user is present by this ID!");
        }

        [TestCase(1)]
        [TestCase(99)]
        [TestCase(9999999999)]
        public void FindByIdShouldWorkWhenIdIsPresent(long id)
        {
            ExtendedDatabase database = new ExtendedDatabase();

            database.Add(new Person(id, $"Person{id}"));

            Assert.AreNotEqual(null, database.FindById(id));
        }

        [TestCase(20)]
        [TestCase(25)]
        [TestCase(30)]
        public void ConstructorShouldThrowExceptionWhenItemsAreAboveSixteen(int count)
        {
            Person[] people = new Person[count];

            for (int i = 0; i < count; i++)
            {
                people[i] = new Person(i, $"Person{i}");
            }

            Assert.Throws<ArgumentException>(() => new ExtendedDatabase(people));
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(15)]
        public void ConstructorShouldAddElementsWhileTheyArebelowSixteen(int count)
        {
            Person[] people = new Person[count];

            for (int i = 0; i < count; i++)
            {
                people[i] = new Person(i, $"Person{i}");
            }

            ExtendedDatabase database = new ExtendedDatabase(people);

            Assert.AreEqual(count, database.Count);
        }
    }
}