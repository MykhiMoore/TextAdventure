using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class TextAdventure
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hilarious Pirate Treasure Hunt Adventure!");
            Console.WriteLine("You find yourself on a deserted island. A pirate approaches you.");

            while (true)
            {
                Console.Write("Do you (1) Talk to the pirate, (2) Run away, or (3) Offer him a rubber chicken? Choose 1, 2, or 3 (or type 'exit' to quit): ");
                string choice = Console.ReadLine().ToLower();

                if (choice == "1")
                {
                    Console.WriteLine("You start a conversation with the pirate, and he offers to share his treasure with you.");
                    Console.WriteLine("Congratulations! You're now a pirate with a rubber chicken.");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You try to run away but trip over a coconut and end up in the pirate's arms.");
                    Console.WriteLine("He finds it amusing and gives you a rubber chicken as a parting gift.");
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You offer the pirate a rubber chicken. He bursts into laughter and hands you a treasure map!");
                    Console.WriteLine("You're now on a quest to find the legendary rubber chicken treasure.");
                }
                else if (choice == "exit")
                {
                    Console.WriteLine("Thanks for playing! It was a hilarious adventure.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please choose 1, 2, 3, or type 'exit' to quit.");
                }
            }
        }
    }
}

