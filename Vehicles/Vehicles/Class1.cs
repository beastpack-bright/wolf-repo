using System;

namespace Vehicles
{

    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }


    public interface IHeavyLoadCarrier
    {
        void LoadHeavyLoad();
    }


    public class Vehicle
    {
        public virtual void LoadPassenger()
        {
            
        }
    }


    public class Car : Vehicle, IPassengerCarrier
    {
        public void LoadPassenger()
        {
            Console.WriteLine("Passengers are getting into the car.");
        }
    }


    public class Train : Vehicle, IPassengerCarrier, IHeavyLoadCarrier
    {
        public void LoadPassenger()
        {
            Console.WriteLine("Passengers are getting onto the train.");
        }
        public class _424DoubleBogey : Vehicle, IHeavyLoadCarrier
        {
            public void LoadHeavyLoad()
            {
                Console.WriteLine("Loading heavy cargo onto the 424DoubleBogey.");
            }
        }

        public void LoadHeavyLoad()
        {
            Console.WriteLine("Loading heavy cargo onto the train.");
        }
    }

    public class Compact : Car
    {
    }

    public class Pickup : Car
    {
    }

    public class SUV : Car
    {
    }


    public class PassengerTrain : Train
    {
    }

    public class FreightTrain : Train
    {
    }



}
