using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        private List<Car> cars;

        public Parking(int value)
        {
            capacity = value;
            Cars = new List<Car>();
        }

        public List<Car> Cars { get; set; }
        public int Count { get { return Cars.Count; } }

        public string AddCar(Car car)
        {
            if (Cars.FirstOrDefault(x => x.RegistrationNumber == car.RegistrationNumber) != null)
            {
                return "Car with that registration number, already exists!";
            }
            else if (Cars.Count > capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (Cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber) == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Cars.Remove(Cars.First(x => x.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber) => Cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string registrationNumber in RegistrationNumbers)
            {
                Car car = GetCar(registrationNumber);

                if (car != null)
                {
                    Cars.Remove(car);
                }
            }
        }

    }
}
