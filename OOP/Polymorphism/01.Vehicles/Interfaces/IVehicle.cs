using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles
{
    public interface IVehicle
    {
        void Drive(decimal kilometers);
        void Refuel(decimal liters);
    }
}
