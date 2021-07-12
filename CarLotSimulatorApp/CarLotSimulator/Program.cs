using System;
using System.Collections.Generic;
using System.Text;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var andresCar = new Car();
            andresCar.Make = "Hyundai";
            andresCar.Model = "Sonata";
            andresCar.Year = 2018;
            andresCar.EngineNoise = "broom";
            andresCar.HonkNoise = "beep";
            andresCar.IsDriveable = true;
            


            var ariCar = new Car();
            ariCar.Make = "Nissian";
            ariCar.Model = "Altima";
            ariCar.Year = 2018;
            ariCar.EngineNoise = "Caroom";
            ariCar.HonkNoise = "vereep";
            ariCar.IsDriveable = true;

            var axelCar = new Car();
            axelCar.Make = "Dodge";
            axelCar.Model = "Challenger";
            axelCar.Year = 2022;
            axelCar.EngineNoise = "God noise!";
            axelCar.HonkNoise = "Polite God noise!";
            axelCar.IsDriveable = true;

            andresCar.MakeEngineNoise(andresCar.EngineNoise);
            ariCar.MakeEngineNoise(ariCar.EngineNoise);
            axelCar.MakeEngineNoise(axelCar.EngineNoise);

            andresCar.MakeHonkNoise(andresCar.HonkNoise);
            ariCar.MakeHonkNoise(ariCar.HonkNoise);
            axelCar.MakeHonkNoise(axelCar.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
