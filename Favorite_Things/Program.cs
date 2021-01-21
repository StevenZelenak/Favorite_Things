using Favorite_Things.F_Things;
using System;

namespace Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book Class
            Book Book1 = new Book("Hyperion", 1989);
            Book1.CheckIfOlderBook();
            Book1.BookYearStatement();
            Book Book2 = new Book("Odysseus", 1178);
            Book2.CheckIfOlderBook();
            Book2.BookYearStatement();

            Console.WriteLine("----------------------------------\n");

            //Car Class
            Car car1 = new Car("Nissan", "Kicks", 2019);
            car1.IsTheCarDamaged(true);
            Car car2 = new Car("Toyota", "Scion", 2016);
            car2.IsTheCarDamaged(false);

            Console.WriteLine("----------------------------------\n");

            //Game
            Game game1 = new Game("League of Legends", "PC");
            game1.GameSystemResponse("PC");
            game1.IsItGameTime("Yes");
            Game game2 = new Game("Apex", "Xbox");
            game2.GameSystemResponse("Xbox");
            game2.IsItGameTime("No");

            Console.WriteLine("----------------------------------\n");

            //Tv Show
            TV_Show tvshow1 = new TV_Show("Stargate SG-1", 1997);
            tvshow1.IsItNew();
            tvshow1.MessageFromOurSponsers();
            TV_Show tvshow2 = new TV_Show("Rick n Morty", 2013);
            tvshow2.IsItNew();

        }
    }
}
