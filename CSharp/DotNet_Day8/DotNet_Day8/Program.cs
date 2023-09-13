using System;

namespace DotNet_Day8
{
    class Engine
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public double Power { get; set; }

        public Engine(string model,string make, double power)
        {
            Model = model;
            Make = make;
            Power = power;
        }
    }

    class Car
    {
        public string carType { get; set; }
        public string carName { get; set; }
        public double carCost { get; set; }
        public Engine carEngine { get; set; }

        public Car(string carType,string carName, double carCost, Engine carEngine)
        {
            this.carType = carType;
            this.carName = carName;
            this.carCost = carCost;
            this.carEngine = carEngine; // will call the Engine class constructor
        }

        public void DisplayCar()
        {
            Console.WriteLine($"Car Name {carName}, Car cost {carCost}, Engine Make {carEngine.Make}, Car Model {carEngine.Model}");
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Engine e = new Engine("E1", "Ford", 1235667);
            Car c = new Car("SUV", "EcoSport", 1700000, e);
            c.DisplayCar();           
            Console.Read();
        }
    }
       
}
