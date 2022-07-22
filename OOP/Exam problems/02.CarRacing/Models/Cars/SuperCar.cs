namespace CarRacing.Models.Cars
{
    public class SuperCar : Car
    {
        private static readonly double fuelAvailable = 80;
        private static readonly double fuelConsumptionPerRace = 10;

        public SuperCar(string make, string model, string vin, int horsePower) : base(make, model, vin, horsePower, fuelAvailable, fuelConsumptionPerRace)
        {
        }
    }
}
