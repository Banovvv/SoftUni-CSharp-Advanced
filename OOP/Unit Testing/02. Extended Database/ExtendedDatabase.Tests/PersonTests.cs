using NUnit.Framework;

namespace ExtendedDatabase.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [TestCase(1, "Robot00")]
        [TestCase(1234124151, "Robot01")]
        [TestCase(1234124151142, "Robot02")]
        public void ConstructorShouldWorkWithValidParameters(long id, string username)
        {
            var person = new Person(id, username);
            Assert.AreEqual(id, person.Id);
            Assert.AreEqual(username, person.UserName);
        }
    }
}
