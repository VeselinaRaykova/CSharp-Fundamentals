using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> orders = new Dictionary<string, Product>();

            string[] data = Console.ReadLine().Split().ToArray();

            while (data[0] != "buy")
            {
                string name = data[0];
                double price = double.Parse(data[1]);
                int quantity = int.Parse(data[2]);

                if (!orders.ContainsKey(name))
                {
                    orders.Add(name, new Product(name, price, quantity));
                }
                else
                {
                    Product p = orders[name];
                    p.Price = price;
                    p.Quantity += quantity;
                }

                data = Console.ReadLine().Split().ToArray();
            }

            foreach (var p in orders)
            {
                Console.WriteLine($"{p.Value.Name} -> {p.Value.GetTotalPrice():f2}");
            }
        }
    }

    public class Product
    {
        public string Name;
        public int Quantity;
        public double Price;

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double GetTotalPrice()
        {
            double total = this.Quantity * this.Price * 1.00;
            return total;
        }
    }
}
