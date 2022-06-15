namespace _02.VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private bool people = true;
        private decimal conditioner;

        public Bus(decimal fuel, decimal fuelConsumption, decimal tankCapacity) : base(fuel, fuelConsumption, tankCapacity)
        {
        }

        protected override decimal Conditioner
        {
            get
            {
                if (people)
                {
                    return 1.6M;
                }

                return 0;
            }
        }

        public void DriveEmpty(decimal kilometers)
        {
            people = false;
            Drive(kilometers);
        }
    }
}
