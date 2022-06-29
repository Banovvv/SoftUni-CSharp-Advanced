using NUnit.Framework;
using System;

namespace FightingArena.Tests
{
    [TestFixture]
    public class ArenaTests
    {
        //You should test all the constructors
        //You should test all properties(getters and setters)
        //You should test all the methods and validations inside the class}
        private Arena _arena;

        [SetUp]
        public void Initialize()
        {

            _arena = new Arena();
        }
        [Test]
        public void ConstructorShouldWork()
        {
            Assert.True(_arena.Warriors != null);
            Assert.AreEqual(0, _arena.Warriors.Count);
        }

        #region Enroll Tests
        [Test]
        public void EnrollShouldWorkWithValidparameters()
        {
            var _arena = new Arena();

            _arena.Enroll(new Warrior("Pesho", 10, 30));
            _arena.Enroll(new Warrior("Gosho", 10, 30));
            _arena.Enroll(new Warrior("Tosho", 10, 30));

            Assert.AreEqual(3, _arena.Count);
            Assert.AreEqual(3, _arena.Warriors.Count);
        }

        [Test]
        public void EnrollShouldThrowExceptionWhenWarriorNameIsRepeated()
        {
            _arena.Enroll(new Warrior("Pesho", 10, 30));

            Assert.Throws<InvalidOperationException>(() => _arena.Enroll(new Warrior("Pesho", 10, 30)), "Warrior is already enrolled for the fights!");
            Assert.AreEqual(1, _arena.Count);
            Assert.AreEqual(1, _arena.Warriors.Count);
        }
        #endregion

        #region Figth Tests
        [TestCase("Pesho", 20, 60, "Gosho", 20, 60)]
        [TestCase("Gosho", 15, 90, "Tosho", 20, 80)]
        [TestCase("Tosho", 20, 150, "Losho", 10, 70)]
        public void FightShouldWorkWithValidparameters(string attackerName, int attackerDamage, int attackerHp, string defenderName, int defenderDamage, int defenderHp)
        {
            Warrior attacker = new Warrior(attackerName, attackerDamage, attackerHp);
            Warrior defender = new Warrior(defenderName, defenderDamage, defenderHp);

            _arena.Enroll(attacker);
            _arena.Enroll(defender);

            _arena.Fight(attackerName, defenderName);

            Assert.AreEqual(defenderHp - attackerDamage, defender.HP);
        }

        [TestCase("Pesho", 20, 60, "Gosho", 20, 60)]
        [TestCase("Gosho", 15, 90, "Tosho", 20, 80)]
        [TestCase("Tosho", 20, 150, "Losho", 10, 70)]
        public void FightShouldThrowExceptionWhenWarriorNameIsMissing(string attackerName, int attackerDamage, int attackerHp, string defenderName, int defenderDamage, int defenderHp)
        {
            Warrior attacker = new Warrior(attackerName, attackerDamage, attackerHp);
            Warrior defender = new Warrior(defenderName, defenderDamage, defenderHp);

            _arena.Enroll(attacker);
            _arena.Enroll(defender);

            string missingWarrior = "Ivancho";

            Assert.Throws<InvalidOperationException>(() => _arena.Fight(attackerName, missingWarrior));
        }
        #endregion
    }
}