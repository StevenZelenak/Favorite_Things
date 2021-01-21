using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.F_Things
{
    class Game
    {
        //Properties
        public string Name { get; set; }
        public string GameSystem { get; set; }

        //constructor
        public Game(string name, string gamesytem)
        {
            Name = name;
            GameSystem = gamesytem;
            Console.WriteLine($"My favorite game is {name} on the {gamesytem}");
        }

        //Methods
        public void IsItGameTime(string answer)
        {
            if (answer == "yes" || answer == "Yes")
            {
                Console.WriteLine($"It is a Game TIME BOIS!");
            }
            else
            {
                Console.WriteLine($"Homework time.");
            }
        }

        public void GameSystemResponse(string answer)
        {
            if (answer == "xbox" || answer == "Xbox" || answer == "Playstation" || answer == "playstation")
            {
                Console.WriteLine($"This Console Sucks");
            }
            else if (answer == "switch" || answer == "Switch")
            {
                Console.WriteLine($"This Console is ok");
            }
            else
            {
                Console.WriteLine($"PC MASTER RACE");
            }
        }
    }
}
