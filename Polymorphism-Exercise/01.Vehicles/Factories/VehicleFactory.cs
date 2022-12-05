﻿namespace Vehicles.Factories
{
    using Exceptions;
    using Interfaces;
    using Models;
    using Models.Interfaces;

    //This should not be static!!!
    public class VehicleFactory : IVehicleFactory
    {
        public VehicleFactory()
        {

        }

        public IVehicle CreateVehicle(string type, double fuelQty, double fuelConsumption)
        {
            IVehicle vehicle;
            if (type == "Car")
            {
                vehicle = new Car(fuelQty, fuelConsumption);
            }
            else if (type == "Truck")
            {
                vehicle = new Truck(fuelQty, fuelConsumption);
            }
            else
            {
                throw new InvalidVehicleTypeException();
            }

            return vehicle;
        }
    }
}