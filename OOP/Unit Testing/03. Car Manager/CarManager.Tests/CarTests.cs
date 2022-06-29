using NUnit.Framework;
using System;

namespace CarManager.Tests
{
    [TestFixture]
    public class CarTests
    {
        //You should test all the constructors
        //You should test all properties(getters and setters)
        //You should test all the methods and validations inside the class}

        [TestCase("Lada", "Niva", 15.5, 80)]
        [TestCase("Tesla", "Model X", 0.1, 0.1)]
        public void ConstructorShouldWorkWithValidParameters(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }

        #region Setter Tests
        [TestCase("", "Niva", 15.5, 80)]
        [TestCase(null, "Model X", 0.1, 0.1)]
        public void ConstructorShouldThrowExceptionWithInvalidMake(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity), "Make cannot be null or empty!");
        }

        [TestCase("Lada", "", 15.5, 80)]
        [TestCase("Tesla", null, 0.1, 0.1)]
        public void ConstructorShouldThrowExceptionWithInvalidModel(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity), "Model cannot be null or empty!");
        }

        [TestCase("Lada", "Niva", 0, 80)]
        [TestCase("Tesla", "Model X", -1, 0.1)]
        public void ConstructorShouldThrowExceptionWithInvalidFuelConsumption(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity), "Fuel consumption cannot be zero or negative!");
        }

        [TestCase("Lada", "Niva", 15.5, 0)]
        [TestCase("Tesla", "Model X", 0.1, -1)]
        public void ConstructorShouldThrowExceptionWithInvalidFuelCapacity(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity), "Fuel capacity cannot be zero or negative!");
        }
        #endregion

        #region Refuel Tests
        [TestCase(20)]
        [TestCase(80)]
        public void RefuelShouldWorkWithValidParameters(double amount)
        {
            Car car = new Car("Lada", "Niva", 15.5, 80);
            car.Refuel(amount);

            Assert.AreEqual(amount, car.FuelAmount);

        }

        [TestCase(100)]
        [TestCase(1000)]
        public void RefuelShouldCorrectAmountIfOverFuelCapacity(double amount)
        {
            Car car = new Car("Lada", "Niva", 15.5, 80);
            car.Refuel(amount);

            Assert.AreEqual(car.FuelAmount, car.FuelCapacity);

        }

        [TestCase(0)]
        [TestCase(-1)]
        public void RefuelShouldThrowExceptionWithInvalidParameters(double amount)
        {
            Car car = new Car("Lada", "Niva", 15.5, 80);

            Assert.Throws<ArgumentException>(() => car.Refuel(amount), "Fuel amount cannot be zero or negative!");
        }
        #endregion
    }
}