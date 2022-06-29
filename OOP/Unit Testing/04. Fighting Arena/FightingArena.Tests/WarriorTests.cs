using NUnit.Framework;
using System;

namespace FightingArena.Tests
{
    [TestFixture]
    public class WarriorTests
    {
        //You should test all the constructors
        //You should test all properties(getters and setters)
        //You should test all the methods and validations inside the class}
        [TestCase("Mage", 35, 100)]
        [TestCase("Tank", 55, 250)]
        [TestCase("Rogue", 75, 80)]
        public void ConstructorShouldWorkWithValidParameters(string name, int damage, int hp)
        {
            Warrior warrior = new Warrior(name, damage, hp);

            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }

        #region Setter Tests
        [TestCase(null, 35, 100)]
        [TestCase("", 55, 250)]
        [TestCase(" ", 75, 80)]
        public void ConstructorShouldThrowExceptionWithInvalidName(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp), "Name should not be empty or whitespace!");
        }

        [TestCase("Mage", 0, 100)]
        [TestCase("Tank", -1, 250)]
        [TestCase("Rogue", -1421, 80)]
        public void ConstructorShouldThrowExceptionWithInvalidDamage(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp), "Damage value should be positive!");
        }

        [TestCase("Mage", 35, -1)]
        [TestCase("Tank", 55, -9)]
        [TestCase("Rogue", 75, -1421)]
        public void ConstructorShouldThrowExceptionWithInvalidHp(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp), "HP should not be negative!");
        }
        #endregion

        #region Attack Tests
        [TestCase(29)]
        [TestCase(15)]
        [TestCase(1)]
        public void AttackShouldThrowExceptionWhenThisHpIsBelowThreshold(int hp)
        {
            Warrior thisWarrior = new Warrior("Pesho", 25, hp);
            Warrior otherWarrior = new Warrior("Gosho", 25, 100);

            Assert.Throws<InvalidOperationException>(() => thisWarrior.Attack(otherWarrior), "Your HP is too low in order to attack other warriors!");
        }

        [TestCase(29)]
        [TestCase(15)]
        [TestCase(1)]
        public void AttackShouldThrowExceptionWhenOtherHpIsBelowThreshold(int hp)
        {
            Warrior thisWarrior = new Warrior("Pesho", 25, 100);
            Warrior otherWarrior = new Warrior("Gosho", 25, hp);

            Assert.Throws<InvalidOperationException>(() => thisWarrior.Attack(otherWarrior));
        }

        [TestCase(100)]
        [TestCase(200)]
        [TestCase(300)]
        public void AttackShouldThrowExceptionWhenThisHpIsLessThanOtherDamage(int damage)
        {
            Warrior thisWarrior = new Warrior("Pesho", 25, damage - 10);
            Warrior otherWarrior = new Warrior("Gosho", damage, 100);

            Assert.Throws<InvalidOperationException>(() => thisWarrior.Attack(otherWarrior));
        }
        #endregion
    }
}
