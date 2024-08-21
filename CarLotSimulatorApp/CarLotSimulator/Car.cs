using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class Car
{
    public Car(string Year, string Make, string Model, bool IsDriveable)
    {
        var year = Year;
        var make = Make;
        var model = Model;
        var driveable = IsDriveable;
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