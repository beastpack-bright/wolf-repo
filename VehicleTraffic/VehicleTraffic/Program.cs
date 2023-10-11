using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using VehicleClassLibrary;

namespace VehicleTraffic
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating vehicle instances
            Car car = new Car();
            Train train = new Train();
            Compact compact = new Compact();
            PassengerTrain passengerTrain = new PassengerTrain();
            // Trying to pass an object not in the interface
            object wrongObject = new object(); //This object is not included!

            // Calling AddPassenger
            AddPassenger(car);
            AddPassenger(train);
            AddPassenger(compact);
            AddPassenger(passengerTrain);
            AddPassenger(wrongObject);
        }

        static void AddPassenger(object objectVehicle) //Adding passengers 
        {
            if (objectVehicle is IPassengerCarrier passengerCarrier)
            {
                // Callling LoadPassenger using reference
                passengerCarrier.LoadPassenger();
                Console.WriteLine(objectVehicle.ToString()); // string time

                Console.WriteLine();
            }
            else
            { 
                Console.WriteLine("Hey! This object isn't in the interface."); //If item not in interface
            }
        }
    }
}
