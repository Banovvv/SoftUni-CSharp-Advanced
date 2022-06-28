using NUnit.Framework;
using System;

namespace ExtendedDatabase.Tests
{
    public class ExtendedDatabaseTests
    {
        [TestCase(3)]
        [TestCase(12)]
        [TestCase(16)]
        [TestCase(0)]
        public void AddMethodShouldAddNewElementsWhileCountIsLessThanSixteen(int count)
        {
            
        }
    }
}