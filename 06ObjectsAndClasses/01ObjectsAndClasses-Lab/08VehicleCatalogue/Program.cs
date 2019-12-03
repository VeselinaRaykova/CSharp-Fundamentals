using System;
using System.Collections.Generic;
using System.Linq;

namespace _08VehicleCatalogue
{
    class Program
    {
        public static Catalog catalog = new Catalog();

        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split('/').ToArray();


            while (data[0] != "end")
            {
                string type = data[0];
                string brand = data[1];
                string model = data[2];


                if (type == "Car")
                {
                    int horsePower = int.Parse(data[3]);
                    Car car = new Car(brand, model, horsePower);
                    catalog.Cars.Add(car);
                }
                else
                {
                    int weight = int.Parse(data[3]);
                    Truck truck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(truck);
                }

                data = Console.ReadLine().Split('/').ToArray();
            }

            PrintVehicles();
        }

        private static void PrintVehicles()
        {
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car c in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{c.Brand}: {c.Model} - {c.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck t in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{t.Brand}: {t.Model} - {t.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public string Brand;
        public string Model;
        public int Weight;

        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
    }

    public class Car
    {
        public string Brand;
        public string Model;
        public int HorsePower;

        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
    }

    public class Catalog
    {
        public List<Truck> Trucks;
        public List<Car> Cars;

        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
    }
}
