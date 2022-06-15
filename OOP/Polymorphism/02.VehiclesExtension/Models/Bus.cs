namespace _02.VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private bool people;
        private decimal conditioner;

        public Bus(decimal fuel, decimal fuelConsumption, decimal tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        protected override decimal Conditioner
        {
            get => conditioner;
            set
            {
                if (people)
                {
                    conditioner = 1.6M;
                }

                conditioner = 0;
            }
        }

        public void DriveEmpty(decimal kilometers)
        {
            people = false;
            Drive(kilometers);
        }
    }
}
