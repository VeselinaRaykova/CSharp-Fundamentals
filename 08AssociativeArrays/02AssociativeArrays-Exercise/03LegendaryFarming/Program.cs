using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>() {
            {"shards", 0 }, {"fragments", 0}, {"motes", 0}
        };
            Dictionary<string, string> items = new Dictionary<string, string>() {
            { "motes", "Dragonwrath"}, { "shards", "Shadowmourne"}, { "fragments", "Valanyr"}
        };

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>() { };

            while (true)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < data.Length; i += 2)
                {
                    int quantity = int.Parse(data[i]);
                    string material = data[i + 1].ToLower();

                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;

                        if (materials[material] >= 250)
                        {
                            materials[material] -= 250;

                            Console.WriteLine($"{items[material]} obtained!");

                            foreach (var p in materials.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
                            {
                                Console.WriteLine($"{p.Key}: {p.Value}");
                            }

                            foreach (var p in junkMaterials.OrderBy(p => p.Key))
                            {
                                Console.WriteLine($"{p.Key}: {p.Value}");
                            }

                            return;
                        }

                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }
        }
    }
}
