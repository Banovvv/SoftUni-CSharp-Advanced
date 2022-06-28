using NUnit.Framework;
using System;
using System.Linq;

namespace Database.Tests
{
    public class DatabaseTests
    {
        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(0)]
        public void AddMethodShouldAddNewElementsWhileCountIsLessThanSixteen(int count)
        {
            //Arrange
            Database database = new Database();

            //Act
            for (int i = 0; i < count; i++)
            {
                database.Add(i);
            }

            //Assert
            Assert.AreEqual(count, database.Count);

        }

        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(0)]
        public void AddMethodShouldThrowExceptionWhenItemsAreAboveSixteen(int count)
        {
            //Arrange
            Database database = new Database();

            //Act
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(count), "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(1, 4)]
        [TestCase(1, 15)]
        [TestCase(1, 16)]
        public void ConstructorShouldAddItemsWhileTheyAreBelowSixteen(int start, int count)
        {
            //Arrange
            int[] elements = Enumerable.Range(start, count).ToArray();

            //Act
            Database database = new Database(elements);

            //Assert
            Assert.AreEqual(count, database.Count);
        }

        [TestCase(1, 17)]
        [TestCase(1, 25)]
        public void ConstructorShouldThrowExceptionWhenItemsAreAboveSixteen(int start, int count)
        {
            //Arrange
            int[] elements = Enumerable.Range(start, count).ToArray();

            //Act
            Assert.Throws<InvalidOperationException>(() => new Database(elements));
        }

        [TestCase(1, 10, 3, 7)]
        [TestCase(1, 5, 4, 1)]
        public void RemoveMethodShoudlRemoveElementsWhenTheyAreAboveZero(int start, int count, int toRemove, int result)
        {
            int[] elements = Enumerable.Range(start, count).ToArray();
            Database database = new Database(elements);

            for (int i = 0; i < toRemove; i++)
            {
                database.Remove();
            }

            Assert.AreEqual(result, database.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowExceptionWhenElementsAreZero()
        {
            //Arrange
            Database database = new Database();

            //Act
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void FetchShouldReturnAllValidItems()
        {
            //Arrange
            Database database = new Database(1, 2, 3);

            //Act
            database.Add(4);
            database.Add(5);

            database.Remove();
            database.Remove();
            database.Remove();

            int[] fetchedData = database.Fetch();

            int[] expectedData = new int[] { 1, 2 };
            Assert.AreEqual(expectedData, fetchedData);
        }
    }
}