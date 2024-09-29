using System;
using System.Text;

class Car
{
    public string Model { get; }
    public double FuelAmount { get; private set; }
    public double FuelConsumptionPerKm { get; }
    public double DistanceTraveled { get; private set; }

    public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKm = fuelConsumptionPerKm;
        DistanceTraveled = 0;
    }

    public void Drive(double distance)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        double fuelNeeded = distance * FuelConsumptionPerKm;
        if (FuelAmount >= fuelNeeded)
        {
            FuelAmount -= fuelNeeded;
            DistanceTraveled += distance;
        }
        else
        {
            Console.WriteLine("Недостатньо палива для руху");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть кількість машин");
        int n = int.Parse(Console.ReadLine());

        Car[] cars = new Car[n];
        Console.WriteLine("Введіть марку,кількість палива та витрати за км");
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string model = input[0];
            double fuelAmount = double.Parse(input[1]);
            double fuelConsumptionPerKm = double.Parse(input[2]);

            cars[i] = new Car(model, fuelAmount, fuelConsumptionPerKm);
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] parts = command.Split();
            if (parts[0] == "Drive")
            {
                string model = parts[1];
                double distance = double.Parse(parts[2]);

                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.Drive(distance);
                        break;
                    }
                }
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
        }
    }
}
