using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    public class Program
    {
        static void Main()
        {
            int numberOfPumps = int.Parse(Console.ReadLine());

            Queue<PetrolPump> truckTour = new Queue<PetrolPump>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] pumpArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int petrol = pumpArgs[0];
                int distance = pumpArgs[1];

                truckTour.Enqueue(new PetrolPump(petrol, distance));
            }

            int index = 0;

            while (true)
            {
                int currentPetrol = 0;

                foreach(var pump in truckTour)
                {
                    int pumpPetrol = pump.Petrol;
                    int pumpDistance = pump.Distance;

                    currentPetrol += pumpPetrol;
                    currentPetrol -= pumpDistance;

                    if(currentPetrol < 0)
                    {
                        truckTour.Enqueue(truckTour.Dequeue());
                        index++;
                        break;
                    }
                }

                if (currentPetrol >= 0)
                {
                    Console.WriteLine(index);
                    break;
                }
            }
        }
    }

    public class PetrolPump
    {
        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            Distance = distance;
        }
        public int Petrol { get; set; }
        public int Distance { get; set; }
    }
}
