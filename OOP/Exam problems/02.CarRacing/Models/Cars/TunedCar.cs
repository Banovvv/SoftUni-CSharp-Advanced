namespace CarRacing.Models.Cars
{
    public class TunedCar : Car
    {
        private static readonly double fuelAvailable = 65;
        private static readonly double fuelConsumptionPerRace = 7.5;

        public TunedCar(string make, string model, string vin, int horsePower) : base(make, model, vin, horsePower, fuelAvailable, fuelConsumptionPerRace)
        {
        }
    }
}
