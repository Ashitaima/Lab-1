using Task08_01.Model;

namespace Task08_01
{
    using Task08_01.Model;
    internal class Program
    {
        static void Main()
        {
            string[] carData = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carData[1]), double.Parse(carData[2]), double.Parse(carData[3]));

            string[] truckData = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]), double.Parse(truckData[3]));

            string[] busData = Console.ReadLine().Split();
            Bus bus = new Bus(double.Parse(busData[1]), double.Parse(busData[2]), double.Parse(busData[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0];
                string vehicleType = command[1];

                if (action == "Drive")
                {
                    double distance = double.Parse(command[2]);
                    if (vehicleType == "Car")
                    {
                        if (car.Drive(distance))
                        {
                            Console.WriteLine($"Car travelled {distance} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (vehicleType == "Truck")
                    {
                        if (truck.Drive(distance))
                        {
                            Console.WriteLine($"Truck travelled {distance} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                    else if (vehicleType == "Bus")
                    {
                        if (bus.Drive(distance))
                        {
                            Console.WriteLine($"Bus travelled {distance} km");
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                    }
                }
                else if (action == "DriveEmpty" && vehicleType == "Bus")
                {
                    double distance = double.Parse(command[2]);
                    bus.UnloadPassengers();
                    if (bus.Drive(distance))
                    {
                        Console.WriteLine($"Bus travelled {distance} km");
                    }
                    else
                    {
                        Console.WriteLine("Bus needs refueling");
                    }
                }
                else if (action == "Refuel")
                {
                    double liters = double.Parse(command[2]);
                    if (vehicleType == "Car")
                    {
                        car.Refuel(liters);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(liters);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.Refuel(liters);
                    }
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
