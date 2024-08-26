using System;
using System.Collections.Generic;
using CarLotSimulator;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();   //property list of type Car. Add cars this list.

    public static int NumberOfCars = 0;
    
    public void ShowLot()
    {
        Console.WriteLine("This lot currently contains: ");
        foreach (var car in ParkingLot)
        {
            Console.WriteLine($"A {car.Year} {car.Make} {car.Model}.");
        }
    }
}