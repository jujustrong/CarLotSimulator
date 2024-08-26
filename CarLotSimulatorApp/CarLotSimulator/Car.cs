using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool IsDriveable { get; set; }
    public Car(int year, string make, string model, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        IsDriveable = isDriveable;
        CarLot.NumberOfCars++;
    }
    public void MakeEngineNoise(string engineNoise)
    {
        Console.WriteLine($"{engineNoise}");
    }
        
    public void MakeHonkNoise(string honk)
    {
        Console.WriteLine($"{honk}");
    }
}