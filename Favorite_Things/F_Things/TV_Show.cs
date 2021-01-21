using System;
using System.Collections.Generic;
using System.Text;

namespace Favorite_Things.F_Things
{
    class TV_Show
    {
        //Properties
        public string Name { get; set; }
        public int YearReleased { get; set; }

        //Fields
        private bool _isNew = false;

        //constructor
        public TV_Show(string name, int yearreleased)
        {
            Name = name;
            YearReleased = yearreleased;

            Console.WriteLine($"{name} is the best show ever it was realesed in the year {yearreleased}");

        }

        //Methods
        public void IsItNew()
        {
            if(_isNew)
            {
                Console.WriteLine("This is def a newer tv show");
                _isNew = false;
            }
            else
            {
                Console.WriteLine("This show is as old as dirt");
                _isNew = true;

            }
        }

        public void MessageFromOurSponsers()
        {
            Console.WriteLine("Do you feel old? Can you not remember any code ever? Well do I have a product for you!!! For just 3 ez payments of $999 I can give you the chance of a lifetime....");
        }
    }
}
