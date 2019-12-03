using System;
using System.Collections.Generic;
using System.Linq;

namespace _07StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split().ToArray();
            List<Box> boxes = new List<Box>();

            while (data[0] != "end")
            {
                string serialNumber = data[0];
                string name = data[1];
                int quantity = int.Parse(data[2]);
                decimal price = decimal.Parse(data[3]);

                Item item = new Item(name, price);
                Box box = new Box(item, serialNumber, quantity);
                boxes.Add(box);

                data = Console.ReadLine().Split().ToArray();
            }

            List<Box> orderedBoxes =  boxes.OrderByDescending(b => b.PriceBox).ToList();

            foreach (Box b in orderedBoxes)
            {
                Console.WriteLine(b.SerialNumber);
                Console.WriteLine($"-- {b.Item.Name} - ${b.Item.Price:f2}: {b.Quantity}");
                Console.WriteLine($"-- ${b.PriceBox:f2}");
            }
        }
    }

    public class Item
    {
        public string Name;
        public decimal Price;

        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Item()
        {
        }
    }

    public class Box
    {
        public string SerialNumber;
        public Item Item;
        public int Quantity;
        public decimal PriceBox;

        public Box(Item item, string serialNumber, int quantity)
        {
            this.Item = item;
            this.SerialNumber = serialNumber;
            this.Quantity = quantity;
            this.PriceBox = quantity * item.Price;
        }

        public Box()
        {
            this.Item = new Item();
        }
    }
}
