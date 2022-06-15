namespace _02.VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private bool people;
        public Bus(decimal fuel, decimal fuelConsumption) : base(fuel, fuelConsumption)
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

        public void DriveEmpty()
        {
            people = false;
            Drive();
        }
    }
}
