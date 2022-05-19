namespace _07.RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargotType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargotType);
            Tires = new Tires[4]
            {
                new Tires(tire1Pressure, tire1Age),
                new Tires(tire2Pressure, tire2Age),
                new Tires(tire3Pressure, tire3Age),
                new Tires(tire4Pressure, tire4Age)
            };
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tires { get; set; }
    }
}
