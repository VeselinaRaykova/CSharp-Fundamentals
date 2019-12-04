using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06VehicleCatalogue
{
    class Program
    {
        public static Catalog catalog = new Catalog();

        static void Main(string[] args)
        {
            ReadVehicles();
            PrintModels();
        }

        private static void ReadVehicles()
        {
            string[] data = Console.ReadLine().Split().ToArray();

            while (data[0] != "End")
            {
                string type = data[0];
                string model = data[1];
                string color = data[2];
                int hp = int.Parse(data[3]);

                Vehicle vehicle = new Vehicle(type, model, color, hp);
                catalog.Vehicles.Add(vehicle);

                data = Console.ReadLine().Split().ToArray();
            }
        }

        private static void PrintModels()
        {
            string model = Console.ReadLine();

            while (model != "Close the Catalogue")
            {
                foreach (Vehicle v in catalog.Vehicles.Where(v => v.Model == model))
                {
                    Console.WriteLine($"Type: {v.Type}");
                    Console.WriteLine($"Model: {v.Model}");
                    Console.WriteLine($"Color: {v.Color}");
                    Console.WriteLine($"Horsepower: {v.HorsePower}");
                }

                model = Console.ReadLine();
            }

            Console.WriteLine($"Cars have average horsepower of: {catalog.GetCarsAverage():f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {catalog.GetTrucksAverage():f2}.");
        }
    }

    public class Vehicle
    {
        public string Type;
        public string Model;
        public string Color;
        public int HorsePower;

        public Vehicle(string type, string model, string color, int hp)
        {
            this.Type = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(type.ToLower());
            this.Model = model;
            this.Color = color;
            this.HorsePower = hp;
        }
    }

    public class Catalog
    {
        public List<Vehicle> Vehicles;

        public Catalog()
        {
            this.Vehicles = new List<Vehicle>();
        }

        public double GetCarsAverage()
        {
            double average = 0;
            List<Vehicle> cars = Vehicles.Where(v => v.Type == "Car").ToList();

            foreach (Vehicle car in cars)
            {
                average += car.HorsePower;
            }
            average = cars.Count > 0 ? average / cars.Count * 1.00 : 0;

            return average;
        }

        public double GetTrucksAverage()
        {
            double average = 0;
            List<Vehicle> trucks = Vehicles.Where(v => v.Type == "Truck").ToList();

            foreach (Vehicle truck in trucks)
            {
                average += truck.HorsePower;
            }

            average = trucks.Count > 0 ? average / trucks.Count * 1.00 : 0;

            return average;
        }
    }
}
