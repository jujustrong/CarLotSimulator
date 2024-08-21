using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class Car
{
    public Car(string year, string make, string model, bool isDriveable)
    {
        var Year = year;
        var Make = make;
        var Model = model;
        var Driveable = isDriveable;
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