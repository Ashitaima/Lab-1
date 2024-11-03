using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08_01.Model
{
    abstract class Vehicle
    {
        public double FuelQuantity { get; protected set; }
        public double FuelConsumption { get; protected set; }
        public double TankCapacity { get; protected set; }

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity; 
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public virtual bool Drive(double distance)
        {
            double requiredFuel = distance * FuelConsumption;

            if (FuelQuantity >= requiredFuel)
            {
                FuelQuantity -= requiredFuel;
                return true;
            }

            return false;
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                return;
            }

            FuelQuantity += liters;
        }
    }

    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity): base(fuelQuantity, fuelConsumption + 0.9, tankCapacity) { }
    }

    class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption + 1.6, tankCapacity) { }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (FuelQuantity + liters * 0.95 > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                return;
            }

            FuelQuantity += liters * 0.95;
        }
    }

    class Bus : Vehicle
    {
        private bool hasPeople=true;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity) { }

        public void UnloadPassengers()
        {
            hasPeople = false;
        }

        public override bool Drive(double distance)
        {
            double additionalConsumption = hasPeople ? 1.4 : 0;
            double requiredFuel = distance * (FuelConsumption + additionalConsumption);

            if (FuelQuantity >= requiredFuel)
            {
                FuelQuantity -= requiredFuel;
                return true;
            }

            return false;
        }
    }
}
