using System;

class Engine
{
    public string Model { get; }
    public int Power { get; }
    public int? Displacement { get; }
    public string Efficiency { get; }

    public Engine(string model, int power, int? displacement = null, string efficiency = "n/a")
    {
        Model = model;
        Power = power;
        Displacement = displacement;
        Efficiency = efficiency;
    }
}

class Car
{
    public string Model { get; }
    public Engine Engine { get; }
    public int? Weight { get; }
    public string Color { get; }

    public Car(string model, Engine engine, int? weight = null, string color = "n/a")
    {
        Model = model;
        Engine = engine;
        Weight = weight;
        Color = color;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Model}:");
        Console.WriteLine($"  {Engine.Model}:");
        Console.WriteLine($"    Power: {Engine.Power}");
        Console.WriteLine($"    Displacement: {(Engine.Displacement.HasValue ? Engine.Displacement.ToString() : "n/a")}");
        Console.WriteLine($"    Efficiency: {Engine.Efficiency}");
        Console.WriteLine($"  Weight: {(Weight.HasValue ? Weight.ToString() : "n/a")}");
        Console.WriteLine($"  Color: {Color}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість двигунів:");
        int n = int.Parse(Console.ReadLine());

        Engine[] engines = new Engine[n];

        for (int i = 0; i < n; i++)
        {
            string[] engineInput = Console.ReadLine().Split(' ');
            string model = engineInput[0];
            int power = int.Parse(engineInput[1]);
            int? displacement = null;
            string efficiency = "n/a";

            if (engineInput.Length > 2)
            {
                if (int.TryParse(engineInput[2], out int disp))
                {
                    displacement = disp;
                }
                else
                {
                    efficiency = engineInput[2];
                }
            }
            if (engineInput.Length > 3)
            {
                efficiency = engineInput[3];
            }

            engines[i] = new Engine(model, power, displacement, efficiency);
        }
        Console.WriteLine("Введіть кількість автомобілів:");
        int m = int.Parse(Console.ReadLine()); 
        Car[] cars = new Car[m];

        for (int i = 0; i < m; i++)
        {
            string[] carInput = Console.ReadLine().Split(' ');
            string model = carInput[0];
            string engineModel = carInput[1];
            int? weight = null;
            string color = "n/a";

            Engine carEngine = Array.Find(engines, e => e.Model == engineModel);

            if (carInput.Length > 2)
            {
                if (int.TryParse(carInput[2], out int carWeight))
                {
                    weight = carWeight;
                }
                else
                {
                    color = carInput[2];
                }
            }

            if (carInput.Length > 3)
            {
                color = carInput[3];
            }

            cars[i] = new Car(model, carEngine, weight, color);
        }

        foreach (var car in cars)
        {
            car.PrintInfo();
        }
    }
}
