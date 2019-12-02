using System;
using System.Collections.Generic;
using System.Linq;

namespace _09PokemonDontGo
{
    class Program
    {
        public static List<int> pokemons = new List<int>();
        static void Main(string[] args)
        {
            pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> removedElements = new List<int>();

            while (pokemons.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int removed = RemovePokemon(index);
                removedElements.Add(removed);

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= removed)
                    {
                        pokemons[i] += removed;
                    }
                    else if (pokemons[i] >= removed)
                    {
                        pokemons[i] -= removed;
                    }
                }
            }

            Console.WriteLine(removedElements.Sum());
        }

        private static int RemovePokemon(int index)
        {
            int removedEl;

            if (index < 0)
            {
                removedEl = pokemons[0];
                pokemons.RemoveAt(0);
                pokemons.Insert(0, pokemons[pokemons.Count - 1]);
            }
            else if (index > pokemons.Count - 1)
            {
                int last = pokemons.Count - 1;
                removedEl = pokemons[last];
                pokemons.RemoveAt(last);
                pokemons.Insert(last, pokemons[0]);
            }
            else
            {
                removedEl = pokemons[index];
                pokemons.RemoveAt(index);
            }

            return removedEl;
        }
    }
}
