using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehiclesExtension
{
    public interface IVehicle
    {
        void Drive(decimal kilometers);
        void Refuel(decimal liters);
    }
}
