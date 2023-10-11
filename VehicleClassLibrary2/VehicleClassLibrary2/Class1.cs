using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary2
{

    // Defining IPassengerCarrier 
    public interface IPassengerCarrier
    {
        void LoadPassenger(); //Part of the interface
    }

    // Defining IHeavyLoadCarrier 
    public interface IHeavyLoadCarrier
    {

    }

    //  Vehicle class
    public class Vehicle
    {
        public virtual void LoadPassenger()
        {
            //Empty as instructed
        }
    }

    public class _424DoubleBogey : Vehicle, IHeavyLoadCarrier
    {
        public void LoadPassenger()
        {
            //Loading heavy load.
        }
    }

    // Setting up car
    public class Car : Vehicle, IPassengerCarrier
    {
        public void LoadPassenger()
        {
            //Loading passengers into car
        }
    }

    // Train is part of Vehicle
    public class Train : Vehicle, IPassengerCarrier, IHeavyLoadCarrier
    {
        public void LoadPassenger()
        {
            //Loading passengers into train
        }

        public void LoadHeavyLoad()
        {
            //Loading heavy load
        }
    }

    // Specific vehicle classes linked to Car
    public class Compact : Car
    {
    }

    public class Pickup : Car
    {
    }

    public class SUV : Car
    {
    }

    // Specific vehicle classes linked to Train
    public class PassengerTrain : Train
    {
    }

    public class FreightTrain : Train
    {
    }

}

