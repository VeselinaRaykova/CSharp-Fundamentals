using System;
using System.Collections.Generic;
using System.Linq;

namespace _03WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allCards = Console.ReadLine().Split(':').ToList();
            List<string> deck = new List<string>();
            string[] commandArgs = Console.ReadLine().Split().ToArray();

            while (commandArgs[0] != "Ready")
            {
                string command = commandArgs[0];

                if (command == "Add")
                {
                    string cardName = commandArgs[1];

                    if (allCards.IndexOf(cardName) >= 0)
                    {
                        deck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Insert")
                {
                    string cardName = commandArgs[1];
                    int index = int.Parse(commandArgs[2]);

                    if (allCards.IndexOf(cardName) >= 0 &&
                        index >= 0 && index < deck.Count)
                    {
                        deck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (command == "Remove")
                {
                    string cardName = commandArgs[1];
                    int index = deck.IndexOf(cardName);

                    if (index >= 0)
                    {
                        deck.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }

                }
                else if (command == "Swap")
                {
                    string firstCardName = commandArgs[1];
                    string secondCardName = commandArgs[2];
                    int firstCardIndex = deck.IndexOf(firstCardName);
                    int secondCardIndex = deck.IndexOf(secondCardName);

                    string temp = deck[secondCardIndex];
                    deck[secondCardIndex] = firstCardName;
                    deck[firstCardIndex] = temp;
                }
                else if (command == "Shuffle")
                {
                    deck.Reverse();
                }

                commandArgs = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ", deck));
        }
    }
}
