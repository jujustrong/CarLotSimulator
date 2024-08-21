using System;
using System.Collections.Generic;
using CarLotSimulator;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            // CarLot MainLot = new CarLot();
            //Now that the Car class is created we can instantiate 3 new cars
            Car car1 = new Car("2018", "Ferrari", "488 GTB", IsDriveable:true);
            Car car2 = new Car("2018", "Porsche", "718 Cayman", IsDriveable:true);
            Car car3 = new Car("2024", "Mercedes-Benz", "AMG GT 63", IsDriveable:true);
            //Set the properties for each of the cars
            //Call each of the methods for each car
            car1.MakeEngineNoise("Rumble");
            car1.MakeHonkNoise("Honk");
            car2.MakeEngineNoise("Revvv");
            car2.MakeHonkNoise("Beep");
            car3.MakeEngineNoise("Hummm");
            car3.MakeHonkNoise("Pew Pew");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instantiate the  Car lot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
