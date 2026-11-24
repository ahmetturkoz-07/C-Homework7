
using System;


enum FuelType
{
    Petrol,
    Diesel,
    Electric
}


class Vehicle
{
    public string Brand;
    public string Model;
    public int Year;
    public FuelType Fuel;

    public static int Count = 0;

    public Vehicle(string brand, string model, int year, FuelType fuel)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Fuel = fuel;

        Count++;
    }

    
    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle engine is starting...");
    }

    
    public string Info()
    {
        return $"{Brand} {Model} ({Year}, {Fuel})";
    }
}


class Car : Vehicle
{
    public Car(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }

    public override void StartEngine()
    {
        Console.WriteLine("Car engine is starting...");
    }
}


class Truck : Vehicle
{
    public Truck(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }

    public override void StartEngine()
    {
        Console.WriteLine("Truck engine is starting...");
    }
}


class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model, int year, FuelType fuel)
        : base(brand, model, year, fuel)
    {
    }

    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine is starting...");
    }
}


class Program
{
    static void Main()
    {
        Vehicle[] fleet =
        {
            new Car("Togg", "T10X", 2024, FuelType.Electric),
            new Truck("Ford", "Cargo", 2022, FuelType.Diesel),
            new Motorcycle("Yamaha", "MT-07", 2023, FuelType.Petrol)
        };

        foreach (Vehicle vehicle in fleet)
        {
            Console.WriteLine(vehicle.Info());
            vehicle.StartEngine();
            Console.WriteLine();
        }

        
        Console.WriteLine("Total vehicles: " + Vehicle.Count);
    }
}
