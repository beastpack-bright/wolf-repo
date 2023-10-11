using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using VehicleClassLibrary; 

namespace VehicleTraffic
{
    internal class Program
    {
            static void Main(string[] args)
            {
                // Create instances of various vehicles from the Vehicles.dll assembly
                Car car = new Car();
                Train train = new Train();
                Compact compactCar = new Compact();
                PassengerTrain passengerTrain = new PassengerTrain();

                // Call the AddPassenger function and test with different objects
                AddPassenger(car);
                AddPassenger(train);
                AddPassenger(compactCar);
                AddPassenger(passengerTrain);

                // Try passing an object that does not inherit the IPassengerCarrier interface
                object nonPassengerObject = new object();
                AddPassenger(nonPassengerObject);

                Console.ReadLine();
            }

            static void AddPassenger(object vehicleObject)
            {
                if (vehicleObject is IPassengerCarrier passengerCarrier)
                {
                    // Call the LoadPassenger method using the interface reference
                    passengerCarrier.LoadPassenger();
                    Console.WriteLine(vehicleObject.ToString()); // Calling ToString() method

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("This object does not implement the IPassengerCarrier interface.");
                }
            }
        }
    }
}
    }
}
